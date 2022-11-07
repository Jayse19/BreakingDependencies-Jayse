using ClassLibrary1;
using Moq;
using WinFormsApp1;

namespace TestProject1
{
    public class Tests
    {
        public class TestDependency: IForm
        {
            public void Show(string message)
            {

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
            Assert.That(() => form.Message == "You have to enter a name");
        }

        [Test]
        public void NumBalanceError()
        {
            var form = new Form1();
            var formDepenency = new TestDependency();

            form.btnCalculate_Click(null, null);

            Assert.That(() => form.Message == "Must be between 10k and 1MM");
        }
    }
}