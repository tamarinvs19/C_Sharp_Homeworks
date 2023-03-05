using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1;

internal class Row
{
    private string Name { get; set; }
    private string Age { get; set; }
    private string Time { get; set; }

    private const double ageCoefficient = 0.83;

    public Row(string name, double age)
    {
        Name = name;
        Age = $"{age * ageCoefficient}";
        Time = DateTime.Now.ToString();
    }
}

class DataOrg
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    private int _age;
    public int Age
    {
        get => _age;
        set => _age = value;
    }
    
    private int _score;
    public int Score
    {
        get => _score;
        set => _score = value;
    }

    private int _nameLength;
    public int NameLength
    {
        get => _nameLength;
        set => _nameLength = value;
    }

    private const int MIN_NAME_LENGTH = 3;
    private const int MIN_AGE = 18, MAX_AGE = 65;
    
    public Row getRow()
    {
        if (Name == null)
        {
            throw new ArgumentNullException($"Field `name` cannot be null");
        }

        return new Row(Name, Age);
    }

    private bool isValidData()
    {
        var validLength = NameLength >= MIN_NAME_LENGTH;
        var validAge = Age is >= MIN_AGE and <= MAX_AGE;
        var validScore = Score != -1;

        return validLength && validAge && validScore;
    }
    
    public void CalculateNameLength()
    {
        if (Name == null)
        {
            throw new ArgumentNullException($"Field `name` cannot be null");
        }
        if (isValidData()) 
        {
            NameLength = Name.Length * 4;
        }
    }
    
    public void SetValue(string name, int value)
    {
        switch (name)
        {
            case "age":
                Age = value;
                return;
            case "score":
                Score = value;
                return;
        }
    }
}