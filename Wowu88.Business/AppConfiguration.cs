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
        public string WriteServerList { get; set; }
        public string ReadSeverList { get; set; }
        public int MaxWritePoolSize { get; set; }
        public int MaxReadPoolSize { get; set; }
        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            ConnectionString = root.GetSection("ConnectionString:DbBase").Value;
            WriteServerList = root.GetSection("Redis:WriteServerList:list").Value;
            ReadSeverList = root.GetSection("Redis:ReadServerList:list").Value;
            MaxReadPoolSize = int.Parse(root.GetSection("Redis:MaxReadPoolSize:default").Value);
            MaxWritePoolSize = int.Parse(root.GetSection("Redis:MaxReadPoolSize:default").Value);
        }
    }
}
