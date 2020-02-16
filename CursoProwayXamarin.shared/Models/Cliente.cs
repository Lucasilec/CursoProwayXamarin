using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProwayXamarin.shared.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public DateTime DateNascimento { get; set; }

        public Cliente GerarCliente()
        {
            this.Id = 1;
            this.Nome = "Lucas ileck";
            this.CPF = "00000000000";
            this.CEP = "128346473";
            this.Endereco = "Rua proximo de alencar";
            this.DateNascimento = DateTime.Today;
            return this;

        }
    }
}
