﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursTakip.Modeller
{
    public class DbEgitmen
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
