using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App07_Celulas.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void Button_GoTextCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.TextCellPage());
            IsPresented = false;
        }

        private void Button_GoImageCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
            IsPresented = false;
        }
        private void Button_GoEntryCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
            IsPresented = false;
        }
        private void Button_GoSwitchCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
            IsPresented = false;
        }
        private void Button_GoViewCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
            IsPresented = false;
        }
        private void Button_GoListViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ListViewPage());
            IsPresented = false;
        }
        private void Button_GoListViewButtonPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ListViewButtonPage());
            IsPresented = false;
        }
    }
}