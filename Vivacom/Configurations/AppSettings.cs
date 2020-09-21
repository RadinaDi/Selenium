using Microsoft.Extensions.Configuration;
using System;

namespace Vivacom.Configurations
{
    public class AppSettings
    {
        public AppSettings(IConfiguration config)
        {
            this.Username = config["username"] ?? throw new ArgumentException(nameof(this.Username));
            this.Password = config["password"] ?? throw new ArgumentException(nameof(this.Password));
            this.FromNumber = config["from_number"] ?? throw new ArgumentException(nameof(this.FromNumber));
            this.ToNumber = config["to_number"] ?? throw new ArgumentException(nameof(this.ToNumber));
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FromNumber { get; set; }

        public string ToNumber { get; set; }
    }
}
