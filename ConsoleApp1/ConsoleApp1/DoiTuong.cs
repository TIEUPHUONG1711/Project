using System;

namespace ConsoleApp1.Doituong
{
    /*lớp xe : bao gồm các trường: biển số, tên xe, trọng tải, ngày đăng kiểm, tiêu chuẩn bằng
     phương thức : nhập(), và xuất()*/
    public class Car
    {
        private string bienSo;
        private string tenXe;
        private string trongTai;
        private string ngayDangKiem;
        private string tieuChuanBang;

        //prop+tab+tab
        public string BienSo { get => bienSo; set => bienSo = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public string TrongTai { get => trongTai; set => trongTai = value; }
        public string NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
        public string TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

        ////ctor + tab:
        //public Car()
        //{

        //}

        //// ctrl + . :
        //public Car(string bienSo, string tenXe, string trongTai, string ngayDangKiem, string tieuChuanBang)
        //{
        //    this.bienSo = bienSo;
        //    this.tenXe = tenXe;
        //    this.trongTai = trongTai;
        //    this.ngayDangKiem = ngayDangKiem;
        //    this.tieuChuanBang = tieuChuanBang;
        //}

        public void nhap()
        {
            Console.Write("Nhập vào biển số xe :");
            BienSo = Console.ReadLine();
            Console.Write("Nhập vào tên xe :");
            TenXe = Console.ReadLine();
            Console.Write("Trọng tải xe :");
            TrongTai = Console.ReadLine();
            Console.Write("Nhập vào ngày đăng kiểm :");
            NgayDangKiem = Console.ReadLine();
            Console.Write("Nhập vào tiêu chuẩn bằng :");
            TieuChuanBang = Console.ReadLine();
        }


        public void xuat()
        {

            Console.WriteLine($"Biển số xe là : {BienSo}");
            Console.WriteLine($"Tên xe là : {TenXe}");
            Console.WriteLine($"Trọng tải xe là : {TrongTai}");
            Console.WriteLine($"Ngày đăng kiểm là : {NgayDangKiem}");
            Console.WriteLine($"Tiêu chuẩn bằng là : {TieuChuanBang}");
        }
        
    }
}
