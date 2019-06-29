﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Entities;

namespace WM.Northwind.Entities.Concrete.EczaneNobet
{
    public class Cozunurluk : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Deger { get; set; }
        public string Aciklama { get; set; }

        public virtual List<Cihaz> Cihazlar { get; set; }

    }
}