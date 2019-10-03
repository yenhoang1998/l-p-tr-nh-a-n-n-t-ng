using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace btth1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MH_gridlayout : ContentPage
	{
		public MH_gridlayout ()
		{
			InitializeComponent();
		}
        private void cmdgridlayout_clicked(object sender, EventArgs e)
        {
            DisplayAlert("thong bao", "gridlayout", "thoat");
        }
      

	}
}