using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisFresadora.Models
{
    public class Servico
    {
        public int ID { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
        public float Modulo { get; set; }
        public int NumeroDentes { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
        }
        public string Observacoes { get; set; }
        public Cliente Cliente { get; set; }

        public Servico()
        {
        }

        public Servico(int iD, int quantidade, string tipo, string material, float modulo, int numeroDentes, float valorUnitario, string observacoes, Cliente cliente)
        {
            ID = iD;
            Quantidade = quantidade;
            Tipo = tipo;
            Material = material;
            Modulo = modulo;
            NumeroDentes = numeroDentes;
            ValorUnitario = valorUnitario;
            Observacoes = observacoes;
            Cliente = cliente;
        }
    }
}
