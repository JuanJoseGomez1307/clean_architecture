using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;
using NorthWindEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependecyInjection;
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
            { 
                services.AddDebugWriter();
                return services;
            }
}
