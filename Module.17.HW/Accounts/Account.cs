namespace Module._17.HW.Accounts;

public abstract class Account
{
    // тип учетной записи
    public string Type { get; protected set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; protected set; }
}
