using ConsoleApp1.Doituong;
using System;
using System.Text;
using ConsoleApp1.QlyXe;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Car obj = new Car();
        //obj.nhap();
        //obj.xuat();
        QlyXe xe = new QlyXe();
        xe.Chay();

    }
}
