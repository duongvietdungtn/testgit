using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("(Back123)Chào mừng bạn đến với game: ĐI TÌM SỐ BÍ ẨN, kết thúc chương II.");
        Random rd = new Random();
        int x = rd.Next(21);
        Console.WriteLine("Số random: {0}", x);
        int n;
        int mang = 1;
        do
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Mời bạn đoán số lần {0}: ", mang);
            n = int.Parse(Console.ReadLine());
            if (mang <= 7)
            {
                if (n < 0 || n > 20)
                {
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Lưu ý, số cần tìm chỉ nằm trong khoảng từ 0 đến 20, vui lòng nhập lại!");
                    mang++;
                }
                else if (n == x)
                {
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Chúc mừng bạn đã đoán đúng, số bí ẩn của chúng tôi là {0}", x);
                    break;
                }
                else if (n != x && n >= 0 && n <= 20)
                {
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bạn đã nhập sai, vui lòng nhập lại");
                    if (n > x)
                    {
                        Console.WriteLine(" Lưu ý, số bạn vừa nhập lớn hơn số bí ẩn");
                    }
                    else if (n < x)
                    {
                        Console.WriteLine(" Lưu ý, số bạn vừa nhập nhỏ hơn số bí ẩn");
                    }
                    mang++;
                }
            }
        }
        while (mang <8);
        Console.WriteLine("---------------------------------------------------------------------");
        if (mang <=7) {
            Console.WriteLine("Kết thúc game!");
        }
        else
        {
            Console.WriteLine("Bạn đã thua vì đã đoán hết 7 lần mà vẫn chưa tìm ra đáp án");
            Console.WriteLine("Kết thúc game!");
        }
    }
}