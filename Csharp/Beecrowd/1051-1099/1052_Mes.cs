using System.Globalization;

namespace Beecrowd._1051_1099
{
    public class _1052_Mes
    {
        public string Mes(string l)
        {
            int monthNumber = int.Parse(l);

            DateTimeFormatInfo formatInfo = DateTimeFormatInfo.CurrentInfo;
            string monthName = formatInfo.GetMonthName(monthNumber);

            monthName = monthName[0].ToString().ToUpper() + monthName.Substring(1);

            return monthName;
        }
    }
}
