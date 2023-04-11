namespace WebApi.Middleware
{
    public static class SecurityHeaderValues
    {

        public const string SameOrigin = "SAMEORIGIN";
        public const string ExpectCt = "max-age=2592000";
        public const string PermissionsPolicy = "accelerometer=(), camera=(), geolocation=(), gyroscope=(), magnetometer=(), microphone=(), payment=(), usb=()";
        public const string FeaturePolicy = "accelerometer=(), camera=(), geolocation=(), gyroscope=(), magnetometer=(), microphone=(), payment=(), usb=()";
        public const string XXssProtection = "1; mode=block";
        public const string XContentTypeOptions = "nosniff";
        public const string ReferrerPolicy = "no-referrer";
        public const string StrictTransportSecurity = "max-age=31536000;includeSubDomains;preload";
        public const string ContentSecurityPolicy = $"{DefaultSrcSelf}; {ScriptSrcSelf}";
        private const string DefaultSrcSelf = "default-src 'self'";
        private const string ScriptSrcSelf = "script-src 'self'";
        public const string ScriptSrcSelfCdnjs = "script-src 'self' https://cdnjs.cloudflare.com";
    }
}
