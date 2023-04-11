namespace WebApi.Middleware
{
    public static class SecurityHeader
    {
        public const string XPoweredBy = "X-Powered-By";
        public const string XAspNetVersion = "X-AspNet-Version";
        public const string XAspNetMvcVersion = "X-AspNetMvc-Version";
        public const string Server = "Server";
        public const string XForwardedHost = "X-Forwarded-Host";

        public const string XFrameOptions = "X-Frame-Options";
        public const string ExpectCt = "Expect-CT";
        public const string PermissionsPolicy = "Permissions-Policy";
        public const string FeaturePolicy = "Feature-Policy";
        public const string XXssProtection = "X-Xss-Protection";
        public const string XContentTypeOptions = "X-Content-Type-Options";
        public const string ReferrerPolicy = "Referrer-Policy";
        public const string StrictTransportSecurity = "Strict-Transport-Security";
        public const string ContentSecurityPolicy = "Content-Security-Policy";
    }
}
