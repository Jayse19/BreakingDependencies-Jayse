using System.Configuration;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
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
    public partial class Form1 : Form
    {
        public string Message { get; set; }

        ShowMessage showMessage;
        public Form1()
        {
            InitializeComponent();
            Message = "";
            showMessage = new ShowMessage();

        }
        public Form1(string message)
        {
            InitializeComponent();
            string Message = message;
        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Length == 0)
            {
                Message = "You have to enter a name";
                showMessage.ShowMessageBox(Message);
                //MessageBox.Show("You have to enter a name");
                return;
            }

            if (numBalance.Value < 10_000 || numBalance.Value > 1_000_000)
            {
                Message = "Must be between 10k and 1MM";
                showMessage.ShowMessageBox(Message);
                //MessageBox.Show("Must be between 10k and 1MM");
                return;
            }

            if (File.Exists("authkey.txt") is false)
            {
                Message = "Missing authorization key";
                showMessage.ShowMessageBox(Message);
                //MessageBox.Show("Missing authorization key");
                return;
            }

            lblResults.Text = (numBalance.Value * numInterestRate.Value).ToString("c");
        }
    }
}