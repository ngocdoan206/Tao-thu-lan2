public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Add / Sum Two Numbers");
        SumTwoNumbers();
        Console.WriteLine("2.to Swap Values of Two Variables");
        SwapValues();
        Console.WriteLine("3.to Multiply two Floating Point Numbers");
        MultiplyFloats();
        Console.WriteLine("4.to convert feet to meter");
        ConvertFeetToMeter();
        Console.WriteLine("5.to convert Celsius to Fahrenheit and vice versa");
        TempConversion();
        Console.WriteLine("6.to find the Size of data types");
        FindSizeOfDataTypes();
        Console.WriteLine("7.to Print ASCII Value (tip: read character, print number of this char)");
        PrintASCIIValue();
        Console.WriteLine("8.to Calculate Area of Circle");
        AreaCircle();
        Console.WriteLine("9.to Calculate Area of Square");
        AreaSquare();
        Console.WriteLine("10.to convert days to years, weeks and days");
        DaysConversion();
    }

    // 1. Add / Sum Two Numbers.
    public static void SumTwoNumbers()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);
        Console.ReadLine();
    }

    //2. to Swap Values of Two Variables.
    public static void SwapValues()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Before swap values: \n firstNumber: " + num1 + "\n secondNumber: " + num2);

        double temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After swap values: \n firstNumber: " + num1 + "\n secondNumber: " + num2);
        Console.ReadLine();
    }

    //3. to Multiply two Floating Point Numbers.
    public static void MultiplyFloats()
    {
        Console.Write("Enter first number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float product = num1 * num2;
        Console.WriteLine("Product: " + product);
        Console.ReadLine();
    }

    //4. to convert feet to meter.
    public static void ConvertFeetToMeter()
    {
        Console.Write("Enter length in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        double meters = feet * 0.3048;
        Console.WriteLine($"{feet} feet is equal to {meters} meters.");
        Console.ReadLine();
    }

    //5. to convert Celsius to Fahrenheit and vice versa.
    public static void TempConversion()
    {
        Console.Write("Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        double f = (temp * 9 / 5) + 32;
        Console.WriteLine($"{temp}°C = {f}°F");

        double c = (temp - 32) * 5 / 9;
        Console.WriteLine($"{temp}°F = {c}°C");
        Console.ReadLine();
    }

    //6. to find the Size of data types
    public static void FindSizeOfDataTypes()
    {
        Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
        Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
        Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
        Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
        Console.WriteLine("Size of bool: " + sizeof(bool) + " bytes");
        Console.ReadLine();
    }

    //7. to Print ASCII Value (tip: read character, print number of this char)
    public static void PrintASCIIValue()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;

        int asciiValue = (int)ch;
        Console.WriteLine($"\nThe ASCII value of '{ch}' is {asciiValue}.");
        Console.ReadLine();
    }

    //8. to Calculate Area of Circle
    public static void AreaCircle()
    {
        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area = {area}");
        Console.ReadLine();
    }

    //9. to Calculate Area of Square
    public static void AreaSquare()
    {
        Console.Write("Enter side length of square: ");
        double side = Convert.ToDouble(Console.ReadLine());

        double area = side * side;
        Console.WriteLine($"Area = {area}");
        Console.ReadLine();
    }

    //10. to convert days to years, weeks and days
    public static void DaysConversion()
    {
        Console.Write("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        int years = days / 365;
        int weeks = (days % 365) / 7;
        int remainingDays = (days % 365) % 7;

        Console.WriteLine($"{days} days = {years} years, {weeks} weeks, {remainingDays} days");
    }
}