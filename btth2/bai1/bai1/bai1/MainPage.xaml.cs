using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bai1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
        public MainPage()
        {
            InitializeComponent();

            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh ="hong.jpg", MoTa = "Hoa cúc các màu:Trắng, hồng " });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "hong.jpg", MoTa = "Hoa cúc hồng " });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "hong.jpg", MoTa = "Hoa cúc tím " });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}
