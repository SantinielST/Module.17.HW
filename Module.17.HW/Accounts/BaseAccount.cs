namespace Module._17.HW.Accounts;

// Обычный клиент
public class BaseAccount : Account, ISetInterest
{
    public BaseAccount()
    {
        Type = "Обычный";
    }

    // Метод настройки процентной ставки для обычного аккаунта
    public double SetInterest() 
    {
        if (Balance < 1000)
            Interest = 0.2;
        else if (Balance >= 1000)
            Interest = 0.4;

        return Interest;
    }
}
