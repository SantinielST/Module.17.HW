using Module._17.HW;
using Module._17.HW.Accounts;

namespace Module._17.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculateInterestMustReturnCorrectValue()
        {
            var baseAcc = new BaseAccount() { Balance = 0 };
            baseAcc.SetInterest();
            baseAcc.CalculateInterest();
            Assert.Equal(0, baseAcc.Balance);

            var baseAcc2 = new BaseAccount() { Balance = 999 };
            baseAcc2.SetInterest();
            baseAcc2.CalculateInterest();
            Assert.Equal(1198,8, baseAcc2.Balance);

            var baseAcc3 = new BaseAccount() { Balance = 1000 };
            baseAcc3.SetInterest();
            baseAcc3.CalculateInterest();
            Assert.Equal(1400, baseAcc3.Balance);
            
            var baseAcc4 = new BaseAccount() { Balance = 1001 };
            baseAcc4.SetInterest();
            baseAcc4.CalculateInterest();
            Assert.Equal(1401.4, baseAcc4.Balance);

            var salAcc = new SalaryAccount() { Balance = 0 };
            var salAcc2 = new SalaryAccount() { Balance = 500 };
        }
    }
}
