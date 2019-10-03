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
	public partial class MH_tinhtong : ContentPage
	{
		public MH_tinhtong ()
		{
			InitializeComponent ();
		}
        private void cmdtinhtong_clicked(object sender, EventArgs e)
        {
            Double soA, soB, tong;
            soA = Double.Parse(txtsoA.Text);
            soB = double.Parse(txtsoB.Text);
            tong = soA + soB;
            txttong.Text = tong.ToString();
            

        }
        private void  cmdvetrangchu_clicked(object sender, EventArgs e)
        {
            DisplayAlert("thông báo", "về trang chủ", "OK");
        }
	}
}