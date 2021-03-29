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
    public class ProizvodController : ControllerBase
    {
        public IProizvodService _proizvodService { get; set; }

        public ProizvodController(IProizvodService proizvodService) {
            _proizvodService = proizvodService;
        }

        [HttpGet] // Kada server bude zahtjevao Proizvod kontroler kao Get pozvat ce se ova metoda
        public IEnumerable<Proizvod> Get()
        {
           
            return _proizvodService.Get();
        }

        [HttpGet("{Id}")]
        public Proizvod GetById(int Id) {

            return _proizvodService.GetById(Id);
        }

        [HttpPost]
        public Proizvod Insert(Proizvod proizvod) {
        
            return _proizvodService.Insert(proizvod);
        }

        [HttpPut("{Id}")]
        public Proizvod Update(int Id, Proizvod proizvod) {
            return Update(Id, proizvod);
        }
    }

    public class Proizvod {

        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
