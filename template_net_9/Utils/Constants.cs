namespace template_net_9.Utils
{
    public class Constants
    {
        public static class CustomClaims
        {
            public const string EMAIL_CLAIM_TYPE = "EmailClaim";
            public const string ID_CLAIM_TYPE = "IdClaim";
            public const string ROLE_CLAIM_TYPE = "RoleClaim";

        }
        public static class Roles
        {
            public const string ADMIN = "Admin";
            public const string USER = "User";
        }

        public static class AWS
        {
            public const string ROOTFOLDER = "admin";
        }
    }
}
