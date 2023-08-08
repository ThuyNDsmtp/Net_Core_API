namespace NewApp.Models{
    public class Employee{
        public string? HoTen { get; set; }
        public string? DiaChi { get; set; }

        public void NhapThongTin(){
            System.Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();
            
            System.Console.Write("Nhập địa chỉ của {0}: ",HoTen);
            DiaChi = Console.ReadLine();
            
        }
        public void HienThi(){
            System.Console.WriteLine("Bạn đã nhập vào họ và tên [{0}] và địa chỉ [{1}]",HoTen,DiaChi);
        }
    }
}