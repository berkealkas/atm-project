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
    public partial class PayBills : Form
    {
        public PayBills()
        {
            InitializeComponent();
        }

        private void PayBills_Load(object sender, EventArgs e)
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
            var entities = new BankEntities();
            var result = Convert.ToInt32(lblAmount.Text) - Convert.ToInt32(txtBillPrice.Text);

            entities.Bills.Add(new Bills
            {
                phone_number = Convert.ToDecimal(lblPhoneNumber.Text),
                amount = Convert.ToDecimal(result),
                bill = cbBill.Text,
                bill_price = Convert.ToDecimal(txtBillPrice.Text),
                create_date = DateTime.Now
            });

            if (Convert.ToInt32(txtBillPrice.Text) > 0)
            {          
                var dialog = MessageBox.Show(string.Format("Ödemek İstediğiniz Fatura: {0}  \nÖdeme Yapılan Miktar: {1} \nOnaylıyor Musunuz?", cbBill.Text, txtBillPrice.Text), "Fatura Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    
                    entities.SaveChanges();
                    
                    var newEntities = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member member = newEntities.Member.FirstOrDefault(user => user.phone_number == userPhoneNumber);

                    if (member.amount >= Convert.ToInt32(txtBillPrice.Text))
                    {
                        member.amount = Convert.ToDecimal(result);
                        MessageBox.Show("Faturanız Ödenmiştir.", "Fatura Ödeme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newEntities.SaveChanges();
                        this.Close();
                        PayBills payBills = new PayBills();
                        payBills.ShowDialog();
                    }
                    
                    else
                    {
                        MessageBox.Show("Yetersiz Bakiye.", "Fatura Ödeme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        PayBills payBills = new PayBills();
                        payBills.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Fatura Ödemeniz İptal Edildi.", "Fatura Ödeme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    PayBills payBills = new PayBills();
                    payBills.ShowDialog();
                }
            }

            else
            {
                MessageBox.Show("Hatalı İşlem" , "Fatura Ödeme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                PayBills payBills = new PayBills();
                payBills.ShowDialog();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void txtBillPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
