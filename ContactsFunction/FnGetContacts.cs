using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ContactsFunction
{
    public class FnGetContacts
    {
        // add a constructor to inject the DbContext
        private readonly ContactsDbContext _dbContext;
        public FnGetContacts(ContactsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [FunctionName("FnGetContacts")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "contacts")] HttpRequest req)
        {
            var contacts = await _dbContext.Contacts.ToListAsync();

            return new OkObjectResult(contacts);
        }
    }
}
