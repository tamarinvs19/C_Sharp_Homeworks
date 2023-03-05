namespace ConsoleApp1;

public class gMethods
{
    private string _name;
    private int _price;
    private int _amount;
    private string _platform;

    private const double AMOUNT_COEFFICIENT = 0.956;
    private const double TEMP_COEFFICIENT = 0.8;

    public void PrintPack()
    {
        PrintBanner();
        PrintDetails();
    }

    private void PrintDetails()
    {
        Console.WriteLine("name: " + _name);
        Console.WriteLine("amount: " + _amount);
        Console.WriteLine("price: " + _price);
        Console.WriteLine("platform: " + _platform);
    }

    private bool checkPlatform()
    {
        return _platform.ToUpper().Contains("PC");
    }

    private bool checkName()
    {
        return _name.ToUpper().Contains("XX");
    }

    private bool checkAmount()
    {
        return _amount > 0;
    }

    private double GetOutstanding()
    {
        if (checkPlatform() && checkName() && checkAmount())
        {
            return _amount * AMOUNT_COEFFICIENT;
        }

        double temp = _amount * _price;
        Console.WriteLine(temp);

        temp = TEMP_COEFFICIENT * temp;
        Console.WriteLine(temp);

        return -1;
    }

    private void PrintBanner()
    {
        throw new NotImplementedException();
    }
}
