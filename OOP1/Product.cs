﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product //sadece özellik içerir
    {
        public int Id { get; set; }//ana anahtar
        public int CategoryId { get; set; }//referans anahtarı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
           
    }
}
