using Exoentityannuaire;
using Microsoft.AspNetCore.Mvc;
//Ajouter ma dependence AnnuaireEntityFramework
namespace CoursAPI.Controllers
{
    [Route("api/v1[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {



        private DataContext _dataContext;

        public ContactController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataContext.Contacts.ToList());
        }

        [HttpGet("{phone}")]
        public IActionResult Get(string phone)
        {
            Contact contact = _dataContext.Contacts.FirstOrDefault(c => c.Phone == phone);
            if (contact != null)
                return Ok(contact);
            else
                return NotFound();
        }
    }
}
