using Microsoft.AspNetCore.Mvc;
using Standup.Model;
using Standup.Services;

namespace Standup.Controllers
{
    
    [ApiController]
    [Route("api/{controller}/{action}/")]
    public class Controller : ControllerBase
    {

        readonly ICustomerServcie customerService;
      
        public Controller(ICustomerServcie _customerService)
        {
         this.customerService = _customerService;   
        }

        [HttpGet]
        [ActionName("Customer")]
        public ActionResult<List<Customer>> Get()
        {
           return customerService.getCustomer();    
        }
    }
}