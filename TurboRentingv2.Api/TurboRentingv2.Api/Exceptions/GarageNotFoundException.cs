﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboRentingv2.Api.Models.Entities;

namespace TurboRentingv2.Api.Exceptions
{
    public class GarageNotFoundException : EntityNotFoundException<Garage>
    {
        public GarageNotFoundException(object? entityId) : base(entityId)
        {
        }
    }
}
