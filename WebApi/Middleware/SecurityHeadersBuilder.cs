namespace WebApi.Middleware
{
    public class SecurityHeadersBuilder
    {
        private readonly SecurityHeadersPolicy _policy = new SecurityHeadersPolicy();

        public SecurityHeadersBuilder AddDefaultSecurePolicy()
        {
            RemoveHeader(SecurityHeader.XPoweredBy);
            RemoveHeader(SecurityHeader.XAspNetVersion);
            RemoveHeader(SecurityHeader.XAspNetMvcVersion);
            RemoveHeader(SecurityHeader.Server);
            RemoveHeader(SecurityHeader.XForwardedHost);

            AddFrameOptionsSameOrigin();
            AddXssProtection();
            AddXContentTypeOptions();
            AddReferrerPolicy();
            AddContentSecurityPolicy();
            AddPermissionsPolicy();
            AddExpectCt();

            return this;
        }

        private SecurityHeadersBuilder AddFrameOptionsSameOrigin()
        {
            _policy.SetHeaders[SecurityHeader.XFrameOptions] = SecurityHeaderValues.SameOrigin;
            return this;
        }

        private SecurityHeadersBuilder AddExpectCt()
        {
            _policy.SetHeaders[SecurityHeader.ExpectCt] = SecurityHeaderValues.ExpectCt;
            return this;
        }

        private SecurityHeadersBuilder AddPermissionsPolicy()
        {
            _policy.SetHeaders[SecurityHeader.PermissionsPolicy] = SecurityHeaderValues.PermissionsPolicy;

            //Feature-Policy is an older header that is now deprecated
            _policy.SetHeaders[SecurityHeader.FeaturePolicy] = SecurityHeaderValues.FeaturePolicy;

            return this;
        }

        private SecurityHeadersBuilder AddXssProtection()
        {
            _policy.SetHeaders[SecurityHeader.XXssProtection] = SecurityHeaderValues.XXssProtection;
            return this;
        }

        private SecurityHeadersBuilder AddXContentTypeOptions()
        {
            _policy.SetHeaders[SecurityHeader.XContentTypeOptions] = SecurityHeaderValues.XContentTypeOptions;
            return this;
        }

        private SecurityHeadersBuilder AddReferrerPolicy()
        {
            _policy.SetHeaders[SecurityHeader.ReferrerPolicy] = SecurityHeaderValues.ReferrerPolicy;
            return this;
        }

        //Can be added in this way also
        public SecurityHeadersBuilder AddStrictTransportSecurity()
        {
            _policy.SetHeaders[SecurityHeader.StrictTransportSecurity] = SecurityHeaderValues.StrictTransportSecurity;
            return this;
        }

        private SecurityHeadersBuilder AddContentSecurityPolicy()
        {
            //_policy.SetHeaders["Content-Security-Policy"] = "default-src 'self' 'unsafe-inline'; connect-src 'self' ws:; style-src 'self' 'unsafe-inline'";
            _policy.SetHeaders[SecurityHeader.ContentSecurityPolicy] = SecurityHeaderValues.ContentSecurityPolicy;
            return this;
        }

        public SecurityHeadersBuilder AddCustomHeader(string header, string value)
        {
            _policy.SetHeaders[header] = value;
            return this;
        }

        private SecurityHeadersBuilder RemoveHeader(string header)
        {
            _policy.RemoveHeaders.Add(header);
            return this;
        }

        public SecurityHeadersPolicy Build()
        {
            return _policy;
        }
    }
}
