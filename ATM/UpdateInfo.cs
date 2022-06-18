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
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {

            var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
            var userName = txtName.Text;
            var userSurname = txtSurname.Text;
            var userPassword = txtPassword.Text;

            BankEntities bank = new BankEntities();
            Member updateInfo = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
            
            updateInfo.name = userName;
            updateInfo.surname = userSurname;
            updateInfo.password = userPassword;
            bank.SaveChanges();
            
            MessageBox.Show("Bilgileriniz Güncellendi.", "Bilgi Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            lblPhoneNumber.Text = Login.userPhoneNumber.ToString();

            BankEntities bank = new BankEntities();
            var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
            Member updateInfo = bank.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
            txtName.Text = updateInfo.name.ToString();
            txtSurname.Text = updateInfo.surname.ToString();
            txtPassword.Text = updateInfo.password.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
