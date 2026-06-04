using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class MergeTwoSortedListsTest
{
    [Fact]
    public void MergeTwoLists_BothListsHaveElements_ReturnsMergedList()
    {
        // Arrange
        var list1 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(4) } };
        var list2 = new ListNode(1) { next = new ListNode(3) { next = new ListNode(4) } };

        // Act
        var result = MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        var expected = new[] { 1, 1, 2, 3, 4, 4 };
        AssertListEqual(expected, result);
    }

    [Fact]
    public void MergeTwoLists_FirstListEmpty_ReturnsSecondList()
    {
        // Arrange
        ListNode? list1 = null;
        var list2 = new ListNode(0);

        // Act
        var result = MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        AssertListEqual([0], result);
    }

    [Fact]
    public void MergeTwoLists_SecondListEmpty_ReturnsFirstList()
    {
        // Arrange
        var list1 = new ListNode(1) { next = new ListNode(2) };
        ListNode? list2 = null;

        // Act
        var result = MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        AssertListEqual([1, 2], result);
    }

    [Fact]
    public void MergeTwoLists_BothListsEmpty_ReturnsNull()
    {
        // Arrange
        ListNode? list1 = null;
        ListNode? list2 = null;

        // Act
        var result = MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        Assert.Null(result);
    }

    private static void AssertListEqual(int[] expected, ListNode? actual)
    {
        var current = actual;
        foreach (var value in expected)
        {
            Assert.NotNull(current);
            Assert.Equal(value, current.val);
            current = current.next;
        }
        Assert.Null(current);
    }
}