namespace _2._Add_Two_Numbers
{
    internal class Program
    {
        static void Main()
        {
            // Create solution
            Solution solution = new();

            // Set up the task
            //ListNode lN1 = solution.CreateLinkedList([1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1]);
            //ListNode lN2 = solution.CreateLinkedList([5, 6, 4]);
            ListNode lN1 = solution.CreateLinkedList([3, 7]);
            ListNode lN2 = solution.CreateLinkedList([9, 2]);
            ListNode result = solution.AddTwoNumbers(lN1, lN2);

            // Print result

            Console.ReadKey();
        }
    }
}
