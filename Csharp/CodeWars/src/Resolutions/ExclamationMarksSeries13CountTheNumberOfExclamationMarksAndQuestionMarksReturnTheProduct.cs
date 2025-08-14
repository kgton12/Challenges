namespace CodeWars.src;

public class ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct
{
    public static int Product(string str) =>
        str.Count(x => x.Equals('!')) * str.Count(x => x.Equals('?'));
}
