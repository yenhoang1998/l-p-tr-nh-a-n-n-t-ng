using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class LoaiHoa:List<hoa>
    {
        public string TenLoai { get; set;}
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc")
                {
                    new hoa { TenHoa = "Đón xuân " , Gia = 50000, Hinh = "hong.jpg", MoTa ="Hoa cúc nhiều màu:Trắng, vàng, cam"},
                    new hoa { TenHoa = "Hồn nhiên " , Gia = 60000, Hinh = "hong.jpg", MoTa ="Hoa cúc nhiều màu:Vàng, cam,lá măng"},
                    new hoa { TenHoa = "Tím thủy chung " , Gia = 45000, Hinh = "hong.jpg", MoTa ="Hoa cúc tím"} },
                new LoaiHoa("Hoa cưới")
                {
                    new hoa { TenHoa = "Đón xuân " , Gia = 50000, Hinh = "hong.jpg", MoTa ="Hoa cúc nhiều màu:Trắng, vàng, cam"},
                    new hoa { TenHoa = "Đón xuân " , Gia = 50000, Hinh = "hong.jpg", MoTa ="Hoa cúc nhiều màu:Trắng, vàng, cam"},
                    new hoa { TenHoa = "Đón xuân " , Gia = 50000, Hinh = "hong.jpg", MoTa ="Hoa cúc nhiều màu:Trắng, vàng, cam"}


                }
            };
            Loaihoas = l;
        }
    }
}
