namespace knightmoves;

public class Ageable
{
    private int Year;

    public Ageable(int year)
    {
        Year = year;
    }

    public int Age()
    {
        int currentYear = 2026;        
        return currentYear - Year;
    }
}

public class Company : Ageable
{
    private string Name;
    private string Id;
    private decimal TaxRate;

    public Company(string name, string taxId, int yearEstablished, decimal taxRate) 
        : base(yearEstablished)      
    {
        Name = name;
        Id = taxId;
        TaxRate = taxRate;
    }
}

public class Person : Ageable
{
    private string Name;
    private string Id;
    private decimal TaxRate;

    public Person(string name, string ssn, int birthYear, decimal taxRate) 
        : base(birthYear)             
    {
        Name = name;
        Id = ssn;
        TaxRate = taxRate;
    }
}

public class Car : Ageable
{
    private string Name;
    private string Id;

    public Car(string model, string vin, int year) 
        : base(year)                  
    {
        Name = model;
        Id = vin;
    }
}
