using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(ContactsFunction.Startup))]

namespace ContactsFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var connectionString = Environment.GetEnvironmentVariable("AzureDatabaseConnectionString");

            builder.Services.AddDbContext<ContactsDbContext>(
                options => options.UseSqlServer(connectionString));
        }
    }
}
