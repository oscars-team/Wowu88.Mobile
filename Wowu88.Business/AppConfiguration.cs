using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Wowu88.Business
{
    public class AppConfiguration
    {
        public string ConnectionString { get; private set; }
        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            ConnectionString = root.GetSection("ConnectionString:DbBase").Value;
        }
    }
}
