﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Mani : IAlimento
    {
        public string Tipo { get; set; }

        public string Nombre
        {
            get
            {
                return "mani japones";
            }
        }
    }
}
