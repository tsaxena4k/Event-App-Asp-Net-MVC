using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSWebApp.Infrastructure.Data
{
    public class EventContextSeed
    {
        public static async Task SeedAsync(EventContext eventContext, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;

            try
            {
                // TODO: Only run this if using a real database
                eventContext.Database.Migrate();
                eventContext.Database.EnsureCreated();


            }
            catch (Exception exception)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<EventContextSeed>();
                    log.LogError(exception.Message);
                    await SeedAsync(eventContext, loggerFactory, retryForAvailability);
                }
                throw;
            }
        }
    }
}
