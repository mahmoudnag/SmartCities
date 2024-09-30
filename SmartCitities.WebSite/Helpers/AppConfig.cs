namespace SmartCitities.WebSite.Helpers
{
    public static class AppConfig
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string GetImagthPathServer()
        {
            return _configuration["MySettings:ImagthPathServer"];
        }

     
    }
}
