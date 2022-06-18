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
    public partial class Login : Form
    {
        public static string userAmount = "";
        public static string userPhoneNumber = "";
        public Login()
        {
            InitializeComponent();
        }

        public void btnLogIn_Click(object sender, EventArgs e)
        {
            using (BankEntities context = new BankEntities())
            {
                var phoneNumber = Convert.ToDecimal(txtPhoneNumber.Text);
                var Member = context.Member.FirstOrDefault(user => user.phone_number == phoneNumber);
                if (Member != null)
                {
                    if (Member.phone_number == Convert.ToDecimal(txtPhoneNumber.Text))
                    {
                        userAmount = Member.amount.ToString();
                        userPhoneNumber = Member.phone_number.ToString();
                        MessageBox.Show("Başarıyla Giriş Yapıldı.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Telefon Numarası veya Şifre Hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Telefon Numarası veya Şifre Hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
           
        }
    }
}
