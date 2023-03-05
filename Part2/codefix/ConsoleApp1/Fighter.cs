namespace ConsoleApp1;

public class Fighter
{
    private int _damage;
    
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    public int FighterHealth
    { get; set; }
    public int FighterDamage
    { get; set; }
    public int WeaponStatus
    { get; set; }

    private void LogStatus(string name, int age, int health, int damage, int weaponStatus)
    {
        var logMessage = $"name:{name}, age:{age}, health:{health}, damage:{damage}, weaponStatus:{weaponStatus}";
        Console.WriteLine(logMessage);
    }
    public int GetDamage()
    {
        // Weapon_Status * 5
        // Console.WriteLine($"Get Damage {iDamage}");
        return _damage;
    }

    private void DoAttack()
    {
        Console.WriteLine("Go Attack!");
        // TODO: implement attack
    }
    public void Attack()
    {
        try
        {
            DoAttack();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Go Attack Exception: {e}");
            throw e;
        }
    }
}