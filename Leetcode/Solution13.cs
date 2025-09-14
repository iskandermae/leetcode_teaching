
using System.Linq;

namespace Leetcode.Leetcode;

public class Solution14 {

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    public bool IsSymmetric(TreeNode root) {
        if (root == null) return false;

        IEnumerable<int?> left = GetLeft(root.left);
        IEnumerable<int?> right = GetRight(root.right);

        var le = left.GetEnumerator();
        var re = right.GetEnumerator();

        while (true) {
            bool len = le.MoveNext();
            bool ren = re.MoveNext();

            if (!len && !ren) { return true; }
            if (!len || !ren) {return false; }
            if (le.Current != re.Current) return false;
        }
    }

    private IEnumerable<int?> GetLeft(TreeNode node) {
        if (node != null) {
            yield return node.val;
            if (node.left == null) {
                yield return null;
            } else {
                foreach (int? v in GetLeft(node.left)) { yield return v; }
            }
            if (node.right == null) {
                yield return null;
            } else {
                foreach (int? v in GetLeft(node.right)) { yield return v; }
            }
        }
    }

    private IEnumerable<int?> GetRight(TreeNode node) {
        if (node != null) {
            yield return node.val;
            if (node.right == null) {
                yield return null;
            } else {
                foreach (int? v in GetRight(node.right)) { yield return v; }
            }
            if (node.left == null) {
                yield return null;
            } else {
                foreach (int? v in GetRight(node.left)) { yield return v; }
            }
        }
    }

    public bool Run() {
        var root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.left.right = new TreeNode(3);


        root.right = new TreeNode(2);
        root.right.right = new TreeNode(3);

        return IsSymmetric(root);
    }

}
