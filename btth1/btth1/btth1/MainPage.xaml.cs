using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace btth1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        async private void button_clicked_2(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MH_chao());

        }
        async private void button_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_tinhtong());

        }
        async private void cmdlogin_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_login());

        }
        async private void button_clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_stacklayout());

        }
        async private void cmdgridlayout_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_gridlayout());

        }
        async private void cmdabsolutelayout_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_absolutelayout());

        }
        
        
    
    }
}
