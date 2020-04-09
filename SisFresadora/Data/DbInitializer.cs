using System;
using System.Linq;
using SisFresadora.Data;
using SisFresadora.Models;


namespace SisFresadora.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SisFresadoraContext context)
        {
            context.Database.EnsureCreated();

            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente {Nome = "Rosquinel"},
                new Cliente {Nome = "Rafael"}
            };
            foreach (Cliente c in clientes)
            {
                context.Clientes.Add(c);
            }
            context.SaveChanges();

            var servicos = new Servico[]
            {
                new Servico {ClienteID=1, Quantidade=4, Tipo="Engrenagem", Material="Aço", Modulo=3, NumeroDentes=60, ValorUnitario=90, Observacoes="Sem Observações"}
            };
            foreach (Servico s in servicos)
            {
                context.Servicos.Add(s);
            }
            context.SaveChanges();
        }
    }
}
