namespace CodeWars.Completed;

public class Plus1Array
{
    public static int[]? UpArray(int[] num)
    {
        if (num == null || num.Length == 0 || num.Any(d => d < 0 || d > 9))
            return null;

        List<int> result = new([.. num]);
        int carry = 1;

        for (int i = result.Count - 1; i >= 0 && carry > 0; i--)
        {
            int sum = result[i] + carry;
            result[i] = sum % 10;
            carry = sum / 10;
        }

        if (carry > 0)
            result.Insert(0, carry);

        return [.. result];
    }
}
