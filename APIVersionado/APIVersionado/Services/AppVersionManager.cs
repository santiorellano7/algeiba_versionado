using APIVersionado.Entities;
using Microsoft.Extensions.Options;

namespace APIVersionado.Services
{
    public class AppVersionManager
    {
        private readonly AppVersion appVersion;

        public AppVersionManager(IOptions<AppVersion> version)
        {
            this.appVersion = version.Value;
        }

        public string GetVersion()
        {
            return this.appVersion.Version;
        }
    }
}
