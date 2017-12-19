﻿using System;
using System.Collections.Generic;
using System.Text;
using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsulSelfRegistration
{
   public static class ConsulSelfRegistrationExtentions
    {

        public static void UseConsul(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IHostedService, ConsulHostedService>();
            services.Configure<ConsulConfig>(configuration.GetSection("consulConfig"));
            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient());
        }
    }
}
