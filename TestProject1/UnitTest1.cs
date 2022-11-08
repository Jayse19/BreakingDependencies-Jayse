using ClassLibrary1;
using Moq;
using WinFormsApp1;
using static WinFormsApp1.Form1;

namespace TestProject1
{
    public class Tests
    {
        public class TestDependency : IForm
        {
            public string Message { get; set; }
            public void ShowMessageBox(string message)
            {
                Message = message;
            }

        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAddBananaMoreThanInventory()
        {
        }
        [Test]
        public void TestAddBanana()
        {
        }

        [Test]
        public void MultipleCarts()
        {
        }

        [Test]

        public void CountButtonClick()
        {
            var form = new Form1();
            var formDepenency = new TestDependency();

            form.btnCalculate_Click(null, null);

            Assert.That(() => form.Message == "You have to enter a name");
        }

        [Test]
        public void NumBalanceError()
        {
            var form = new Form1();
            form.btnCalculate_Click(null, null);

            Assert.That(() => form.Message == "Must be between 10k and 1MM");
        }
    }
}