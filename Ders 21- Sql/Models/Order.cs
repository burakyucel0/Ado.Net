﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21__Sql.Models
{
    public class Order
    {

        public int OrderId { get; set; }



        public int EmployeeId { get; set; }



        public DateTime OrderDate { get; set; }



        public DateTime RequiredDate { get; set; }



        public decimal Freight { get; set; }



        public string ShipCity { get; set; }



        public string ShipCounty { get; set; }


    }
}
