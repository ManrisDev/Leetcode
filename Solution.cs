namespace _2._Add_Two_Numbers
{
    internal class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            int total = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = total / 10;

            return new(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
        }

        public ListNode CreateLinkedList(int[] values)
        {
            ListNode lastNode = new(values[^1]);

            for (int i = values.Length - 2; i >= 0; i--)
                lastNode = new(values[i], lastNode);

            return lastNode;
        }
    }
}
