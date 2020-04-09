﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisFresadora.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public ICollection<Servico> Servicos { get; set; }

        public Cliente()
        {
        }

        public Cliente(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }
    }
}
