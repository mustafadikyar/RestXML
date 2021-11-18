using Microsoft.AspNetCore.Mvc;
using RestXML.Models;

namespace RestXML.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost()]
        [Consumes("application/xml")] //xml request
        [Produces("application/xml")] //xml response
        public IActionResult Post([FromBody] PersonRequestModel requestModel)
        {
            

            PersonResponseModel responseModel = new();
            switch (requestModel.CultureId)
            {
                case 90:
                    responseModel.PersonId = 1;
                    responseModel.Name = "Sample Name";
                    responseModel.Surname = "Sample Surname";
                    return Ok(responseModel);

                //To Do : bla bla bla
            }

            return NotFound();
        }
    }
}
