using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Test.Functions;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Test.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            
        }
    }
}
