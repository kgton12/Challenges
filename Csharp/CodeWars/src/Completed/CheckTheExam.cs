namespace CodeWars.Completed;

public class CheckTheExam
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int result = 0;

        for (int index = 0; index < arr1.Length; index++)
        {
            if (arr2[index] == "") continue;
            if (arr1[index] == arr2[index]) result += 4;
            else result--;
        }

        return result < 0 ? 0 : result;
    }
}
