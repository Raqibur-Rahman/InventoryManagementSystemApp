using Microsoft.AspNetCore.Mvc;
using UserInformationAPI.Data;

namespace UserInformationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;

        public ContactsController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {

            return Ok(dbContext.Contacts.ToList());

           
        }
    }
}
