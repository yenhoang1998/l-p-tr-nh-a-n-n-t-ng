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
	public partial class MH_chao : ContentPage
	{
		public MH_chao ()
		{
			InitializeComponent ();
		}
        private void cmdchao_clicked(object sender, EventArgs e)
        {
            string Hoten = txthoten.Text;
            DisplayAlert("chào", "chào bạn :" + Hoten, "thoát");
        }
	}
}