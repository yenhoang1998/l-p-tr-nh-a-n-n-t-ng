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
	public partial class MH_login : ContentPage
	{
		public MH_login ()
		{
			InitializeComponent ();
		}
        private void cmdlogin_clicked (object sender, EventArgs e)
        {
            DisplayAlert("thông báo", "bạn đã đăng nhập thành công ",  "thoát");

        }
	}
}