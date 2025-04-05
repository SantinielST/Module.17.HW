using Module._17.HW.Accounts;

namespace Module._17.HW;

public class Calculator : ICalculateInterest
{
    private Account _account = new Account();

    public Calculator(Account account)
    {
        _account = account;
    }

    public void BaseAccountCalculateInterest()
    {
        if (_account.Type == "Обычный")
        {
            _account.Interest = _account.Balance * 0.4;

            if (_account.Balance < 1000)
                _account.Interest -= _account.Balance * 0.2;

            if (_account.Balance >= 1000)
                _account.Interest -= _account.Balance * 0.4;
        }
    }

    public void SalaryAccountCalculateInterest()
    {
        if (_account.Type == "Зарплатный")
            _account.Interest = _account.Balance * 0.5;
    }
}
