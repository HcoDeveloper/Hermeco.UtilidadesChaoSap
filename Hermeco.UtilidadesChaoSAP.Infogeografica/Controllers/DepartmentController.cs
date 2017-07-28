using Hermeco.UtilidadesChaoSAP.Infogeografica.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET api/values        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5  
        public City Get(string id, [FromUri] string cityName)
        {            
            var city = City.GetCity(id, cityName);
            return city;           
        }

       

        // POST api/values
        public void Post([FromBody]string value)        
        {
        }

       


        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}