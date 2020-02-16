using CursoProwayXamarin.shared.Models;
using CursoProwayXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoProwayXamarin.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }
        private void SalvarCliente(object sender, System.EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.DarkSeaGreen;
            (sender as Button).IsEnabled = false;
            (sender as Button).Text = "Cadastro concluido com sucesso";

            var cliente = new Cliente().GerarCliente();
            var clienteViewModel = new ClienteViewMovel(cliente);
            nome.Text = clienteViewModel.Nome;
            endereco.Text = clienteViewModel.Endereco;
            cep.Text = clienteViewModel.CEP;
            cpf.Text = clienteViewModel.CPF;
            dataDeNascimento.Text = clienteViewModel.DateNascimento;


            //Navigation.PushAsync(new MainPage());
        }

    }
}