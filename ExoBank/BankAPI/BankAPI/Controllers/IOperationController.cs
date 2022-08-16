using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    public interface IOperationController
    {
        IActionResult Post([FromBody] OperationController.OperationDTO operation, [FromRoute] int id);
    }
}