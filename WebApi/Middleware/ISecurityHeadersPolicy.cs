using System.Collections.Generic;

namespace WebApi.Middleware
{
    public interface ISecurityHeadersPolicy
    {
        IDictionary<string, string> SetHeaders { get; }
        ISet<string> RemoveHeaders { get; }
    }
}
