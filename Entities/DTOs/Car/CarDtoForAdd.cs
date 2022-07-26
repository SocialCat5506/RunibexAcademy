﻿using Core.Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Car
{
    public class CarDtoForAdd : IDto
    {
        public int SupplierId { get; set; }
        //public int BrandId { get; set; }
        public ModelDto ModelDto { get; set; }
        public int ColorId { get; set; }
        public int FuelTypeId { get; set; }
        public bool? MilageLimit { get; set; }
        public bool Transmission { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
