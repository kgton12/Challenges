namespace CodeWars.Completed;

public class IpValidation
{
    public static bool IsValidIp(string ipAddres)
    {
        List<string> rangeIpList = [.. ipAddres.Split('.')];

        return rangeIpList.All(x =>
                    int.TryParse(x, out int result)
                    && result >= 0
                    && result <= 255
                    && result.ToString().Equals(x)
                    && rangeIpList.Count == 4
        );
    }
}
//IPAddress.TryParse(ipAddres, out var output) ? ipAddres == output.ToString() : false;
