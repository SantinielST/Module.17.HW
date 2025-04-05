using Module._17.HW.Accounts;

namespace Module._17.HW;

internal class Program
{
    static void Main(string[] args)
    {
        var acc = new BaseAccount()
        {
            Balance = 1000
        };

        acc.SetInterest();
        acc.CalculateInterest();
        Console.WriteLine(acc.Balance);

        var acc2 = new BaseAccount()
        {
            Balance = 450
        };

        acc2.SetInterest();
        acc2.CalculateInterest();
        Console.WriteLine(acc2.Balance);

        var salAcc = new SalaryAccount()
        {
            Balance = 10
        };

        salAcc.SetInterest();
        salAcc.CalculateInterest();
        Console.WriteLine(salAcc.Balance);
    }
}
