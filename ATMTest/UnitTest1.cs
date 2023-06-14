namespace ATMTest
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance_ShouldReturnBalance()
        {
            // assemble
            Program.Balance = 500;
            // act
            Program.ViewBalance();
            //assert
            Assert.Equal(500, Program.Balance);
        }
        [Fact]
        public void ViewBalance_ShouldReturnHugeNumberBalance()
        {
            // assemble
            Program.Balance = 5412114521534234523;
            // act
            Program.ViewBalance();
            //assert
            Assert.Equal(5412114521534234523, Program.Balance);
        }

        [Fact]
        public void Deposit_shouldReturnNewBalance()
        {
            Program.Balance = 500;
            decimal amount = 100;

            Program.Deposit(amount);

            Assert.Equal(600, Program.Balance);
        }

        [Fact]
        public void Deposit_shouldNotReturnNewBalance()
        {
            Program.Balance = 500; // initial value to make sure the balance doesn't change
            decimal amount = -100;

           // Program.Deposit(amount);

            // Act and Assert
            Assert.Throws<Exception>(() => Program.Deposit(amount));
            Assert.Equal(500, Program.Balance);
        }
        [Fact]
        public void Withdraw_shouldReturnNewBalance()
        {
            Program.Balance = 500;
            decimal amount = 100;

            Program.WithDraw(amount);

            Assert.Equal(400, Program.Balance);
        }
        [Fact]
        public void Withdraw_shouldNotReturnNewBalance()
        {
            Program.Balance = 500; // initial value to make sure the balance doesn't change
            decimal amount = -100;

            // Act and Assert
            Assert.Throws<Exception>(() => Program.WithDraw(amount));
            Assert.Equal(500, Program.Balance);
        }



    }
}