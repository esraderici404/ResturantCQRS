using AutoMapper;
using Cqrs_dal.CQRS.Results.Food;
using Cqrs_dal.Dal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs_dal.Mapping
{
    public static class AutoMapperConfig
    {
        public static void service(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
        }
    }
}

