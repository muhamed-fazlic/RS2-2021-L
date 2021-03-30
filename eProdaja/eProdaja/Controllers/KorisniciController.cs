using eProdaja.Model.Requests;
using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        [HttpGet] 
        public IList<Model.Korisnici> Get()
        {

            return _service.Get();
        }

        [HttpPost]
        public Model.Korisnici Insert([FromBody]KorisniciInsertRequest korisniciInsertRequest) {

            return _service.Insert(korisniciInsertRequest);
        }

    }
}
