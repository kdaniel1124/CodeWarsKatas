using CodeWarsKatas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ValidateCreditCardNumber Test1 = new ValidateCreditCardNumber();
        Test1.Validate("477 073 360");
    }
}