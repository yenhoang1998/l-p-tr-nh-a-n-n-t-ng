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
	public partial class MH_absolutelayout : ContentPage
	{
		public MH_absolutelayout ()
		{
			InitializeComponent ();
		}
        private void cmdabsolute_clicked(object sender, EventArgs e)
        {
            DisplayAlert("thong bao", "absoluteLayout", "thoat");
        }
	}
}