namespace Lab3CSharp;
class Money
{
    protected int nominal;
    protected int num;

    public Money(int nominal, int num)
    {
        this.nominal = nominal;
        this.num = num;
    }

    public void Print() => Console.WriteLine($"Номінал: {nominal}, Кількість: {num}");

    public bool CanBuy(int totalAmount) => totalAmount <= nominal * num;

    public int CalculateItems(int totalAmount) => nominal * num / totalAmount;

    public int Nominal
    {
        get { return nominal; }
        set { nominal = value; }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public int TotalAmount
    {
        get { return nominal * num; }
    }
}

static class Task1
{
    public static void task1()
    {
        Money wallet = new(100, 5);

        Console.WriteLine("Гаманець:");
        wallet.Print();
        Console.WriteLine($"Загальна сума грошей: {wallet.TotalAmount}");

        int itemPrice = 230;
        Console.WriteLine($"\nТовар на {itemPrice} гривень:");

        if (wallet.CanBuy(itemPrice))
        {
            int numItems = wallet.CalculateItems(itemPrice);
            Console.WriteLine($"Можна купити {numItems} штук товару.");
        }
        else
        {
            Console.WriteLine("Недостатньо грошей для покупки товару.");
        }
    }
}
