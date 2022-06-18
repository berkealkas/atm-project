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
    public partial class WithdrawMoney : Form
    {
        public WithdrawMoney()
        {
            InitializeComponent();
        }

        private void btnPrice10_Click(object sender, EventArgs e)
        {
            int price_10 = 10;
            int amount = Convert.ToInt32(lblAmount.Text);
            if (amount >= price_10)
            {
                BankEntities bank = new BankEntities();
                var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                Member member = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                decimal result = amount - price_10;
                member.amount = result;
                bank.SaveChanges();

                BankEntities withdrawMoney = new BankEntities();
                withdrawMoney.Withdraw.Add(new Withdraw
                {
                    phone_number = userPhoneNumber,
                    amount = amount,
                    withdraw_money = Convert.ToDecimal(price_10),
                    current_amount = Convert.ToDecimal(result),
                    create_date = DateTime.Now
                });
                withdrawMoney.SaveChanges();

                MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                WithdrawMoney withdraw = new WithdrawMoney();
                withdraw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void WithdrawMoney_Load(object sender, EventArgs e)
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

        private void btnPrice20_Click(object sender, EventArgs e)
        {
            
            int price_20 = 20;
            int amount = Convert.ToInt32(lblAmount.Text);
            

            if (amount >= price_20)
            {
                using (BankEntities context = new BankEntities())
                {
                    BankEntities bank = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member withdraw = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                    decimal result = amount - price_20;
                    withdraw.amount = result;
                    bank.SaveChanges();

                    BankEntities withdrawMoney = new BankEntities();
                    withdrawMoney.Withdraw.Add(new Withdraw
                    {
                        phone_number = userPhoneNumber,
                        amount = amount,
                        withdraw_money = Convert.ToDecimal(price_20),
                        current_amount = Convert.ToDecimal(result),
                        create_date = DateTime.Now
                    });
                    withdrawMoney.SaveChanges();

                    MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    WithdrawMoney money = new WithdrawMoney();
                    money.ShowDialog();


                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrice50_Click(object sender, EventArgs e)
        {
            int price_50 = 50;
            int amount = Convert.ToInt32(lblAmount.Text);

            if (amount >= price_50)
            {
                using (BankEntities context = new BankEntities())
                {
                    BankEntities bank = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member withdraw = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                    decimal result = amount - price_50;
                    withdraw.amount = result;
                    bank.SaveChanges();

                    BankEntities withdrawAmount = new BankEntities();
                    withdrawAmount.Withdraw.Add(new Withdraw
                    {
                        phone_number = userPhoneNumber,
                        amount = amount,
                        withdraw_money = Convert.ToDecimal(price_50),
                        current_amount = Convert.ToDecimal(result),
                        create_date = DateTime.Now
                    });
                    withdrawAmount.SaveChanges();

                    MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    WithdrawMoney withdrawMoney = new WithdrawMoney();
                    withdrawMoney.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrice100_Click(object sender, EventArgs e)
        {
            int price_100 = 100;
            int amount = Convert.ToInt32(lblAmount.Text);

            if (amount >= price_100)
            {
                using (BankEntities context = new BankEntities())
                {
                    BankEntities bank = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member withdraw = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                    decimal result = amount - price_100;
                    withdraw.amount = result;
                    bank.SaveChanges();

                    BankEntities withdrawAmount = new BankEntities();
                    withdrawAmount.Withdraw.Add(new Withdraw
                    {
                        phone_number = userPhoneNumber,
                        amount = amount,
                        withdraw_money = Convert.ToDecimal(price_100),
                        current_amount = Convert.ToDecimal(result),
                        create_date = DateTime.Now
                    });
                    withdrawAmount.SaveChanges();

                    MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    WithdrawMoney withdrawMoney = new WithdrawMoney();
                    withdrawMoney.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrice200_Click(object sender, EventArgs e)
        {
            int price_200 = 200;
            int amount = Convert.ToInt32(lblAmount.Text);

            if (amount >= price_200)
            {
                using (BankEntities context = new BankEntities())
                {
                    BankEntities bank = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member withdraw = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                    decimal result = amount - price_200;
                    withdraw.amount = result;
                    bank.SaveChanges();

                    BankEntities withdrawAmount = new BankEntities();
                    withdrawAmount.Withdraw.Add(new Withdraw
                    {
                        phone_number = userPhoneNumber,
                        amount = amount,
                        withdraw_money = Convert.ToDecimal(price_200),
                        current_amount = Convert.ToDecimal(result),
                        create_date = DateTime.Now
                    });
                    withdrawAmount.SaveChanges();

                    MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    WithdrawMoney withdrawMoney = new WithdrawMoney();
                    withdrawMoney.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrice500_Click(object sender, EventArgs e)
        {
            int price_500 = 500;
            int amount = Convert.ToInt32(lblAmount.Text);

            if (amount >= price_500)
            {
                using (BankEntities context = new BankEntities())
                {
                    BankEntities bank = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member withdraw = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                    decimal result = amount - price_500;
                    withdraw.amount = result;
                    bank.SaveChanges();

                    BankEntities withdrawAmount = new BankEntities();
                    withdrawAmount.Withdraw.Add(new Withdraw
                    {
                        phone_number = userPhoneNumber,
                        amount = amount,
                        withdraw_money = Convert.ToDecimal(price_500),
                        current_amount = Convert.ToDecimal(result),
                        create_date = DateTime.Now
                    });
                    withdrawAmount.SaveChanges();

                    MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    WithdrawMoney withdrawMoney = new WithdrawMoney();
                    withdrawMoney.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(lblAmount.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            if (amount >= price)
            {
                if (price % 10 == 0)
                {
                    using (BankEntities context = new BankEntities())
                    {
                        BankEntities bank = new BankEntities();
                        var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                        Member withdraw = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                        decimal result = amount - price;
                        withdraw.amount = result;
                        bank.SaveChanges();

                        BankEntities withdrawAmount = new BankEntities();
                        withdrawAmount.Withdraw.Add(new Withdraw
                        {
                            phone_number = userPhoneNumber,
                            amount = amount,
                            withdraw_money = Convert.ToDecimal(price),
                            current_amount = Convert.ToDecimal(result),
                            create_date = DateTime.Now
                        });
                        withdrawAmount.SaveChanges();

                        MessageBox.Show("Para Çekme İşleminiz Başarıyla Tamamlandı.", "Para Çekme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        WithdrawMoney withdrawMoney = new WithdrawMoney();
                        withdrawMoney.ShowDialog();
                    }
                }
                else if (price <= 0)
                {
                    MessageBox.Show("Hatalı Giriş.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    WithdrawMoney withdrawMoney = new WithdrawMoney();
                    withdrawMoney.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Girilen Miktar 10'un Katları Olmalı.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    WithdrawMoney withdrawMoney = new WithdrawMoney();
                    withdrawMoney.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye.", "Para Çekme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                WithdrawMoney withdrawMoney = new WithdrawMoney();
                withdrawMoney.ShowDialog();
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
