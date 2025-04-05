using Module._17.HW.Accounts;

namespace Module._17.HW;

/// <summary>
/// Класс для подсчёта начислений на баланс клиента
/// </summary>
public static class Calculator
{
    // Метод начисления процентов на баланс клиента
    public static void CalculateInterest(this Account account)
    {
        account.Balance += account.Balance * account.Interest;
    }
}
