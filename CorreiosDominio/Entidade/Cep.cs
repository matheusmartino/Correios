﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosDominio.Entidade
{
    public class Cep
    {
        public string ceps { get; set; }
        public string end { get; set; }
        public string  complemento { get; set; }
        public string complemento2 { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }        
    }
}
