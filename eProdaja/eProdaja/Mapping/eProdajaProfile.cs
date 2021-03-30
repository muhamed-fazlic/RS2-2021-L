﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mapping
{
    public class eProdajaProfile: Profile
    {
        public eProdajaProfile()
        {
            CreateMap<Models.Korisnici, Model.Korisnici>().ReverseMap();
        }
    }
}
