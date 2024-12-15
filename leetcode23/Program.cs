using leetcode23;

Solution solution = new Solution();
ListNode[] lists = new ListNode[]
{
    new ListNode(1, new ListNode(4, new ListNode(5))),
    new ListNode(1, new ListNode(3, new ListNode(4))),
    new ListNode(2, new ListNode(6))
};
var node = solution.MergeKLists(lists);
while(node != null)
{
    Console.WriteLine(node.val + "->");
    node = node.next;
}