using CursoProwayXamarin.shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProwayXamarin.ViewModels
{
    class ClienteViewMovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string DateNascimento { get; set; }

        public ClienteViewMovel(Cliente cliente)
        {
            this.Id = cliente.Id;
            this.Endereco = cliente.Endereco;
            this.Nome = cliente.Nome;
            this.CEP = cliente.CEP;
            this.CPF = cliente.CPF;
            this.DateNascimento = cliente.DateNascimento.ToString("dd/mm/yyyy");

        }

    }
}
