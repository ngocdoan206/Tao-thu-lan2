using System;
public class BaiTapNangCaoKieuDuLieu
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap ban kinh hinh cau: ");
        double r = Convert.ToDouble(Console.ReadLine());
        DienTichBeMatVaTheTich(r);

        Console.Write("Nhap so thu nhat: ");
        int so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        int so2 = Convert.ToInt32(Console.ReadLine());
        ToanTu(so1, so2);

        XuLyNgoaiLe();
        XuLyHonHopDuLieu();
        PhanLoaiDuLieu();
    }

    public static void DienTichBeMatVaTheTich(double r)
    {
        double pi = 3.14;
        double surface = 4 * pi * r * r;
        double volume = 4 / 3 * pi * r * r * r;

        Console.WriteLine($"surface = {surface}");
        Console.WriteLine($"volume = {volume}");
        Console.ReadLine();
    }

    public static void ToanTu(int so1, int so2)
    {
        int sum = so1 + so2;
        int sub = so1 - so2;
        int mul = so1 * so2;
        int div = so1 / so2;
        int mod = so1 % so2;

        Console.WriteLine($"{so1} + {so2} = {sum}");
        Console.WriteLine($"{so1} - {so2} = {sub}");
        Console.WriteLine($"{so1} * {so2} = {mul}");
        Console.WriteLine($"{so1} / {so2} = {div}");
        Console.WriteLine($"{so1} mod {so2} = {mod}");
        Console.ReadLine();
    }

    public static void XuLyNgoaiLe()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            Console.WriteLine($"Gia tri sau khi ep kieu: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Chuoi khong hop le, khong the ep kieu sang int.");
        }
        Console.ReadLine();
    }

    public static void XuLyHonHopDuLieu()
    {
        Console.Write("Nhap gia tri thu nhat: ");
        string input1 = Console.ReadLine();

        Console.Write("Nhap gia tri thu hai: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            if (num2 != 0)
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            else
                Console.WriteLine("Khong the chia cho 0.");
        }
        else
        {
            Console.WriteLine("Du lieu nhap vao khong hop le (khong phai so).");
        }
        Console.ReadLine();
    }

    public static void PhanLoaiDuLieu()
    {
        Console.Write("Nhap du lieu: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int i))
        {
            Console.WriteLine("So nguyen");
        }
        else if (double.TryParse(input, out double d))
        {
            Console.WriteLine("So thuc");
        }
        else if (bool.TryParse(input, out bool b))
        {
            Console.WriteLine("Boolean");
        }
        else
        {
            Console.WriteLine("Chuoi ky tu");
        }
    }
}