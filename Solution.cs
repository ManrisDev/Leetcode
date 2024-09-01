namespace _2._Add_Two_Numbers
{
    internal class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currentL1Node = l1;
            ListNode currentL2Node = l2;

            List<int> digits = [];
            int sum;
            int integer = 0;
            int residue = 0;

            while (currentL1Node != null && currentL2Node != null)
            {
                sum = currentL1Node.val + currentL2Node.val + integer;
                residue = sum % 10;
                integer = sum / 10;

                digits.Add(residue);

                currentL1Node = currentL1Node.next;
                currentL2Node = currentL2Node.next;
            }

            if (currentL1Node == null)
            {
                while (currentL2Node != null)
                {
                    sum = currentL2Node.val + integer;
                    residue = sum % 10;
                    integer = sum / 10;

                    digits.Add(residue);

                    currentL2Node = currentL2Node.next;
                }
            }
            else if (currentL2Node == null)
            {
                while (currentL1Node != null)
                {
                    sum = currentL1Node.val + integer;
                    residue = sum % 10;
                    integer = sum / 10;

                    digits.Add(residue);

                    currentL1Node = currentL1Node.next;
                }
            }
            if (integer != 0)
                digits.Add(integer);

            foreach (var i in digits)
                Console.Write(i);

            return CreateLinkedList([..digits]);
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
