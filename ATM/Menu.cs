using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            WithdrawMoney withdrawMoney = new WithdrawMoney();
            this.Hide();
            withdrawMoney.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblAmount.Text = Login.userAmount.ToString();
            using (BankEntities context = new BankEntities())
            {
                BankEntities bank = new BankEntities();
                decimal userPhoneNumber = Convert.ToDecimal(Login.userPhoneNumber);
                var Member = context.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                lblAmount.Text = Member.amount.ToString();
            }
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            DepositMoney depositMoney = new DepositMoney();
            this.Hide();
            depositMoney.ShowDialog();
        }

        private void btnPayBills_Click(object sender, EventArgs e)
        {
            PayBills payBills = new PayBills();
            this.Hide();
            payBills.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            this.Hide();
            transfer.ShowDialog();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo updateInfo = new UpdateInfo();
            this.Hide();
            updateInfo.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}
