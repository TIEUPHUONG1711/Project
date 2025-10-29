using System;
using ConsoleApp1.Doituong;

namespace ConsoleApp1.QlyXe
{
    class QlyXe
    {
        /*viết chương trình c# qly thông tin xe bằng cach sd lớp Xe từ bài trước, 
         tạo thêm 1 lớp QLXE để qly thông qua Dictionary với Key là Biển số và Value là Xe
        Trong lớp QLXE sẽ có các chức năng : 
        a. ThemXe(): thêm mới xe, ktra biển số ko trùng
        b.XuatDanhSach(): xuất danh sách xe theo dạng Key = Biển số, Value = thông tin xe
        c. suaXe() : sửa thông tin xe theo biển số, nếu đổi biển số, phải cập nhật key
        d. XoaXe() : xóa xe theo biển số
        e. TimKiemXeTheoBienSo() : tìm kiếm xe thoe biển số 
        Trong program tạo ra 1 menu cho người dùng nhập từ 0 để thoat, 1 để thêm xe, 2 để xuất ds xe, 3 để xóa xe,
        5 để tìm kiếm xe theo biển số*/

        private Dictionary<string, Car> dsXe = new Dictionary<string, Car>();

        //a.
       
        public void ThemXe()
        {
            Car obj = new Car();

            obj.nhap();
            if (dsXe.ContainsKey(obj.BienSo))
            {
                Console.WriteLine("Đã tồn tại xe này");
            }
            else
            {
                dsXe.Add(obj.BienSo, obj);
            }               

    }
        //b.
        public void XuatDanhSach()
        {
            foreach(var i in dsXe)
            {
                Console.WriteLine($"Biển số xe là : {i.Key} ");
                Console.WriteLine("Thông tin xe là : ");
                i.Value.xuat();
            }
        }
        //c.
        public void SuaXe()
        {
            Console.WriteLine("Nhập vào biển số xe của xe muốn thay đổi thông tin : ");
            string bienso = Console.ReadLine();
            if (dsXe.ContainsKey(bienso))
            {
                
              
                Console.WriteLine("Nhập vào các thông tin của xe mới : ");
                Car xemoi = new Car();
                xemoi.nhap();
                // nếu đổi biển số phải cập nhật lại
                if(xemoi.BienSo != bienso)
                {
                    dsXe.Remove(bienso);
                    dsXe.Add(xemoi.BienSo, xemoi);
                }
                else
                {
                    dsXe[bienso] = xemoi;
                }


            }
            else
            {
                Console.WriteLine("Không tìm thấy biển số xe này!");
            }
        }
        public void XoaXe()
        {
            Console.WriteLine("Nhập vào biển số xe bạn muốn xóa : ");
            string bienso = Console.ReadLine();
            if (dsXe.ContainsKey(bienso))
            {
                dsXe.Remove(bienso);
                Console.WriteLine("Đã xóa xe thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy biển số xe này!");
            }
        }
        public void TimKiemXeTheoBienSo()
        {
            Console.WriteLine("Nhập vào biển số xe bạn muốn tìm : ");
            string bienso = Console.ReadLine();
            if (dsXe.ContainsKey(bienso))
            {

                Console.WriteLine($"Thông tin xe là : ");
                dsXe[bienso].xuat();
                
            }
            else
            {
                Console.WriteLine("Không tìm thấy biển số xe này!");
            }
        }
        public void Chay()
        {
            while (true)
            {
            
                Console.WriteLine("0. Thoát");
                Console.WriteLine("1. Thêm xe");
                Console.WriteLine("2. Xuất danh sách xe");
                Console.WriteLine("3. Sửa xe");
                Console.WriteLine("4. Xóa xe");
                Console.WriteLine("5. Tìm kiếm xe theo biển số");
                Console.WriteLine("Nhập vào lựa chọn của bạn : ");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Thoát chương trình!");
                        return;
                    case 1:
                        ThemXe();
                        break;
                    case 2:
                        XuatDanhSach();
                        break;
                    case 3:
                        SuaXe();
                        break;
                    case 4:
                        XoaXe();
                        break;
                    case 5:
                        TimKiemXeTheoBienSo();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
            
        }
    }
}
