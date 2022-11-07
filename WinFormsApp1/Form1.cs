using System.Configuration;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IForm
        {
            void ShowMessageBox(string message);
        }

        public class ShowMessage: IForm
        {
            public void ShowMessageBox(string message)
            {
                MessageBox.Show(message);
            }
        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)sender;
            if (txtName.Text.Length == 0)
            {
                form.Message("You have to enter a name");
                MessageBox.Show("You have to enter a name");
                return;
            }

            if (numBalance.Value < 10_000 || numBalance.Value > 1_000_000)
            {
                MessageBox.Show("Must be between 10k and 1MM");
                return;
            }

            if (File.Exists("authkey.txt") is false)
            {
                MessageBox.Show("Missing authorization key");
                return;
            }

            lblResults.Text = (numBalance.Value * numInterestRate.Value).ToString("c");
        }
    }
}