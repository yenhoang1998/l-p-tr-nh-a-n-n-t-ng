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
	public partial class MH_stacklayout : ContentPage
	{
		public MH_stacklayout ()
		{
			InitializeComponent ();
		}
        private void cmdstacklayout(object sender, EventArgs e)
        {
            DisplayAlert("page", "stacklayout", "thoát");
        }
	}
}