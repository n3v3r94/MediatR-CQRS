﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Application.Interfaces.Mapping
{
  public  interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
