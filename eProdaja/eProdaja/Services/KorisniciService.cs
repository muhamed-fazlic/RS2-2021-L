using AutoMapper;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {

        private readonly IMapper _mapper;
    
        public eProdajaContext Context { get; set; }
        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;

        }
        public List<Model.Korisnici> Get()
        {
            return Context.Korisnicis.ToList().Select(x=> _mapper.Map<Model.Korisnici>(x)).ToList();
        }

        public Model.Korisnici Insert(KorisniciInsertRequest korisniciInsertRequest)
        {
            //throw new NotImplementedException();
            throw new UserException("Lozinka nije ispravna");
        }
    }
}
