using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace BecketLee
{
    public class ConfigRoot : IConfigurationRoot
    {
        private IConfigurationRoot _config;

        public ConfigRoot( IHostingEnvironment env )
        {
            _config = new ConfigurationBuilder()
                .SetBasePath( env.ContentRootPath )
                .AddJsonFile( "config.json" )
                .AddEnvironmentVariables()
                .Build();
        }
        public IConfigurationSection GetSection(string key)
        {
            return _config.GetSection(key);
        }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            return _config.GetChildren();
        }

        public IChangeToken GetReloadToken()
        {
            return _config.GetReloadToken();
        }

        public string this[string key]
        {
            get { return _config[key]; }
            set { _config[key] = value; }
        }

        public void Reload()
        {
            _config.Reload();
        }

        public IEnumerable<IConfigurationProvider> Providers { get; }
    }
}