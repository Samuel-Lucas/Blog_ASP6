namespace Blog
{
    public static class Configuration
    {
        // JWT - Token - Json Web Token
        public static string JwtKey = "2314f4041a594f1bb6d9656d53d2ff4e";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
        public static SmtpConfiguration Smtp = new SmtpConfiguration(); // Intanciando classe interna

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;     
            public string UserName { get; set; }
            public string Password { get; set; }
        }    
    }
}