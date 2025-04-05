namespace Module._17.HW.Accounts;

// Зарплатный клиент
public class SalaryAccount : Account, ISetInterest
{
    public SalaryAccount()
    {
        Type = "Зарплатный";
    }

    // Метод настройки процентной ставки для зарплатного клиента
    public double SetInterest()
    {
        Interest = 0.5;
        return Interest;
    }
}
