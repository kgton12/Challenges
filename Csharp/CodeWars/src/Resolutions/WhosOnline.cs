namespace CodeWars.src.Resolutions;

public class WhosOnlineClass
{
    public enum UserStatus
    {
        Online,
        Offline,
        Away
    }

    public class User(string username, UserStatus status, int lastActivity)
    {
        public string Username = username;
        public UserStatus Status = status;
        public int LastActivity = lastActivity;
    }

    public static Dictionary<UserStatus, List<string>> WhosOnline(User[] friends)
    {
        return friends
            .Select(u => new
            {
                u.Username,
                Status = u.Status == UserStatus.Online && u.LastActivity > 10 ? UserStatus.Away : u.Status
            })
            .GroupBy(u => u.Status)
            .ToDictionary(
                g => g.Key,
                g => g.Select(u => u.Username).ToList()
            );
    }
}
