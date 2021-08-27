using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleRestfulAPIService.Bussiness;
using SimpleRestfulAPIService.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestfulAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleRestfulAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> Get()
        {
            DataHelper dataHelper = new DataHelper();
      
            List<UserDTO> users = new List<UserDTO>();
            users = (List<UserDTO>)dataHelper.Load_Data();

            return users;
        }
    }
}
