using App07_Celulas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App07_Celulas.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario() { Nome = "José", Cargo = "Presidente" });
            funcionarios.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            funcionarios.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            funcionarios.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            funcionarios.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            ListaFuncionarios.ItemsSource = funcionarios;
        }

        private void ListaFuncionarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario f = (Funcionario)e.SelectedItem;
            Navigation.PushAsync(new Detalhes.DetailPage(f));
        }

        private void Ferias_Clicked(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem) sender;
            Funcionario funcionario = (Funcionario) botao.CommandParameter;
            DisplayAlert("Título: " + funcionario.Nome, "Mensagem: " + funcionario.Nome + " - " + funcionario.Cargo, "Ok");
        }

        private void Abono_Clicked(object sender, EventArgs e)
        {

        }
    }
}