
namespace Hackerrank.Challenges
{
    public class _008_TimeConversion
    {
        public string TimeConversion(string s)
        {
            string[] time = s.Split(':');
            string hour = time[0];
            string minute = time[1];
            string second = time[2].Substring(0, 2);
            string period = time[2].Substring(2, 2);

            if (period == "AM")
            {
                if (hour == "12")
                {
                    hour = "00";
                }
            }
            else
            {
                if (hour != "12")
                {
                    hour = (int.Parse(hour) + 12).ToString();
                }
            }

            return hour + ":" + minute + ":" + second;
        }
    }
}
