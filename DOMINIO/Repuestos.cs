﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Repuestos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public CategoriaRepuestos categoria { get; set; }
        public bool estado { get; set; }
     

    }
}
