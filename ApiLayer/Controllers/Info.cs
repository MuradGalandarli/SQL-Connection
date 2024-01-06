using DataAccessLayer.Abstracte;
using InfoEntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Info : ControllerBase
    {
       private readonly IInfoData _infoData;
        public Info(IInfoData infoData)
        {
            _infoData = infoData;
        }

        [HttpPost]
        public InfoData Postaa([FromBody] InfoData info)
        {
          
                _infoData.infoDataAdd(info);

                return new InfoData();
           
          }



    }
}
