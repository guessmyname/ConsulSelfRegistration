using System;
using System.Collections.Generic;
using System.Text;

namespace ConsulSelfRegistration
{
    public class ConsulConfig
    {
        public string HealthCheckPath { get; set; } = "HealthCheck";
        public string Address { get; set; }
        public string ServiceName { get; set; }
        public string ServiceID { get; set; }

        public List<string> Tags { get; set; }
    }
}
