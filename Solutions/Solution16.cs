namespace Leetcode.Solutions;

public class Solution16 {

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val) : this(val, null, null) { }
        public TreeNode(int val, TreeNode left, TreeNode right) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }



    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null) {
            return false;
        }
        int cur = 0;
        TreeNode curNode = root;
        Stack<(bool, TreeNode) > stack = new Stack<(bool, TreeNode)>();

        while (true) {
            cur += curNode.val;

            if (cur == targetSum && curNode.left == null && curNode.right == null) { return true; }

            if (curNode.left != null) {
                stack.Push((true, curNode));
                curNode = curNode.left;
            } else if (curNode.right != null) {
                stack.Push((false, curNode));
                curNode = curNode.right;
            } else {
                (bool direction, TreeNode node) d;
                while (true) {
                    if (!stack.TryPop(out d))
                        return false;
                    cur -= curNode.val;
                    curNode = d.node;
                    if (d.direction && d.node.right != null) {
                        stack.Push((false, curNode));
                        curNode = d.node.right;
                        break;
                    }
                }
            }
        }
        
    }
}
