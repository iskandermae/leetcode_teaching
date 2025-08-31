namespace Leetcode.Leetcode {

    public class Solution3 {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            

            (ListNode min, ListNode max) = Sort(list1, list2);
            var s = new Stack<int>();

            while (min != null) {
                s.Push(min.val);
                min = min.next;
                (min, max) = Sort(min, max);
            }

            ListNode res = null;
            while (s.TryPop(out int v)) {
                res = new ListNode(v, res);
            }

            return res;
        }

        private (ListNode min, ListNode max) Sort(ListNode? list1, ListNode list2) {
            if (list1 != null && list2 != null && list1.val < list2.val) {
                return (list1, list2);
            }

            return list1 == null ? (list2, list1) : (list1, list2);
        }
    }
}
