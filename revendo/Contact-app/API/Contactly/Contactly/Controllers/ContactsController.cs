using Contactly.Data;
using Contactly.Models;
using Contactly.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contactly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactlyDbContext dbContext;
        public ContactsController(ContactlyDbContext dbContext) {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContacts()
        {
            var contacts = await dbContext.Contacts.ToListAsync();

            return Ok(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequestDTO request)
        {
            var domainModelContact = new Contact
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Favorite = request.Favorite
            };
            await dbContext.Contacts.AddAsync(domainModelContact);
            await dbContext.SaveChangesAsync();

            return Ok(request);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteContact(Guid id)
        {
            var contactId = await dbContext.Contacts.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (contactId != null)
            {
                dbContext.Contacts.Remove(contactId);
                await dbContext.SaveChangesAsync();
            }


            return Ok();
        }

    }
}
