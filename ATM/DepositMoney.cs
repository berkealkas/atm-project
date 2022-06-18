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
    public partial class DepositMoney : Form
    {
        public DepositMoney()
        {
            InitializeComponent();
        }

        private void DepositMoney_Load(object sender, EventArgs e)
        {
            lblAmount.Text = Login.userAmount.ToString();
            lblPhoneNumber.Text = Login.userPhoneNumber.ToString();
            using (BankEntities context = new BankEntities())
            {
                BankEntities bank = new BankEntities();
                decimal userPhoneNumber = Convert.ToDecimal(Login.userPhoneNumber);
                var Member = context.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                lblAmount.Text = Member.amount.ToString();
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(lblAmount.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            
            if (price % 5 == 0)
            {
                using (BankEntities context = new BankEntities())
                {
                    BankEntities bank = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member deposit = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                    decimal result = amount + price;
                    deposit.amount = result;
                    bank.SaveChanges();

                    BankEntities depositAmount = new BankEntities();
                        depositAmount.Deposit.Add(new Deposit
                        {
                            phone_number = userPhoneNumber,
                            amount = amount,
                            deposit_money = Convert.ToDecimal(price),
                            current_money = Convert.ToDecimal(result),
                            create_date = DateTime.Now
                        });
                        depositAmount.SaveChanges();

                    MessageBox.Show("Para Yatırma İşleminiz Başarıyla Tamamlandı.", "Para Yatırma Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    DepositMoney depositMoney = new DepositMoney();                       
                    depositMoney.ShowDialog();
                }
            }
            else if (price <= 0)
            {
                MessageBox.Show("Hatalı Giriş.", "Para Yatırma Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                DepositMoney depositMoney = new DepositMoney();
                depositMoney.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girilen Miktar 5'in Katları Olmalı.", "Para Yatırma Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                DepositMoney depositMoney = new DepositMoney();
                depositMoney.ShowDialog();
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
