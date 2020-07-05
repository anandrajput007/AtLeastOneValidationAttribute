using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AtLeastOneValidationAttribute.Models;

namespace AtLeastOneValidationAttribute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpPost("AddContacts")]
        public ResultModel<ContactModel> Post([FromBody] ContactModel contactModel)
        {
            ResultModel<ContactModel> oContactModel = new ResultModel<ContactModel>();
            oContactModel.Model = contactModel;
            oContactModel.Success = true;
            oContactModel.Message = string.Empty;
            return oContactModel;
        }
    }
}