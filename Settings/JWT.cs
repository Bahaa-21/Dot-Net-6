namespace DotNet_JWT_6.Settings
{
    public class JWT
    {
        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audinece { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
