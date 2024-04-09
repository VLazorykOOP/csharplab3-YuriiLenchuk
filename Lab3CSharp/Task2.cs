namespace Lab3CSharp;
using System;
using System.Collections.Generic;
using System.Linq;

class Organization
{
    public string Name { get; set; }
    public int YearFounded { get; set; }

    public Organization(string name, int yearFounded)
    {
        Name = name;
        YearFounded = yearFounded;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Назва: {Name}, Рік заснування: {YearFounded}");
    }
}

class InsuranceCompany : Organization
{
    public string InsuranceType { get; set; }

    public InsuranceCompany(string name, int yearFounded, string insuranceType) : base(name, yearFounded)
    {
        InsuranceType = insuranceType;
    }

    public override void Show()
    {
        Console.WriteLine($"Страхова компанія: {Name}, Рік заснування: {YearFounded}, Тип страхування: {InsuranceType}");
    }
}

class OilGasCompany : Organization
{
    public string Industry { get; set; }

    public OilGasCompany(string name, int yearFounded, string industry) : base(name, yearFounded)
    {
        Industry = industry;
    }

    public override void Show()
    {
        Console.WriteLine($"Нафтогазова компанія: {Name}, Рік заснування: {YearFounded}, Галузь: {Industry}");
    }
}

class Factory : Organization
{
    public string Product { get; set; }

    public Factory(string name, int yearFounded, string product) : base(name, yearFounded)
    {
        Product = product;
    }

    public override void Show()
    {
        Console.WriteLine($"Завод: {Name}, Рік заснування: {YearFounded}, Продукція: {Product}");
    }
}

class Task2
{
    public static void task2()
    {
        List<Organization> organizations = new()
        {
            new InsuranceCompany("Страхова компанія 1", 1990, "Авто"),
            new OilGasCompany("Нафтогазова компанія 1", 1950, "Нафтовидобування"),
            new Factory("Завод 1", 2005, "Електроніка"),
            new InsuranceCompany("Страхова компанія 2", 1985, "Медичне"),
            new OilGasCompany("Нафтогазова компанія 2", 1960, "Газовидобування"),
            new Factory("Завод 2", 1998, "Меблі")
        };

        Console.WriteLine("Масив організацій впорядкований за роком заснування:");
        organizations = organizations.OrderBy(org => org.YearFounded).ToList();
        foreach (Organization org in organizations)
        {
            org.Show();
        }
    }
}

