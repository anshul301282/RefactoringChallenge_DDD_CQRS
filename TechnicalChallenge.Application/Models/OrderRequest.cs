﻿using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Application.Models
{
    public class OrderRequest
    {
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? RequiredDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public IEnumerable<OrderDetailRequest> OrderDetails { get; set; }
    }
}
