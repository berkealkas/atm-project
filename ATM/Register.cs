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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var entities = new BankEntities();

            var dialogResult = MessageBox.Show("Müşteriyi Kaydetmek İstiyor Musunuz?", "Müşteri Kayıt İşlemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (dialogResult == DialogResult.Yes)
            {
                var authentication = Convert.ToDecimal(txtPhoneNumber.Text);
                Member member = entities.Member.Where(user => user.phone_number == authentication).FirstOrDefault();
                if (member != null)
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Zaten Mevcut.", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Register register = new Register();
                    register.ShowDialog();
                }

                else
                {
                    entities.Member.Add(new Member
                    {
                        name = txtName.Text,
                        surname = txtSurname.Text,
                        phone_number = Convert.ToDecimal(txtPhoneNumber.Text),
                        amount = Convert.ToDecimal(txtAmount.Text),
                        password = txtPassword.Text,
                        create_date = DateTime.Now

                    });
                    entities.SaveChanges();
                    MessageBox.Show("Başarıyla Kayıt Olundu.", "Kayıt İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    Login login = new Login();
                    login.ShowDialog();
                }


               
            }

            else
            {
                MessageBox.Show("Kayıt İşlemi İptal Edildi.", "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
