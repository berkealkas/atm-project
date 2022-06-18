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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            lblAmount.Text = Login.userAmount.ToString();
            lblPhoneNumber.Text = Login.userPhoneNumber.ToString();
            using (BankEntities context = new BankEntities())
            {
                BankEntities bank = new BankEntities();
                decimal userPhoneNumber = Convert.ToDecimal(Login.userPhoneNumber);
                var Member = context.Member.Where(user => user.phone_number == userPhoneNumber).FirstOrDefault();
                lblAmount.Text = Member.amount.ToString();
                var entities = new BankEntities();
                lbTransferUserInfo.DataSource = entities.Member.Select(user => user.phone_number).ToList();
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            var entities = new BankEntities();
            var result = Convert.ToInt32(lblAmount.Text) - Convert.ToInt32(txtPrice.Text);

            if (lbTransferUserInfo.Text == lblPhoneNumber.Text)
            {
                MessageBox.Show("Kendi Hesabına Para Transfer Edemezsin.", "Transfer İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Transfer transfer = new Transfer();
                transfer.ShowDialog();
            }
            else
            {
                if (Convert.ToInt32(txtPrice.Text) > 0)
                {
                    var newEntities = new BankEntities();
                    var userPhoneNumber = Convert.ToDecimal(lblPhoneNumber.Text);
                    Member member = newEntities.Member.FirstOrDefault(user => user.phone_number == userPhoneNumber);

                    if (member.amount >= Convert.ToDecimal(txtPrice.Text))
                    {
                        var dialog = MessageBox.Show(string.Format("Transfer Yapmak İstediğiniz Kişinin Telefon Numarası: {0}  \nTransfer Tutarı: {1} \nOnaylıyor Musunuz?", lbTransferUserInfo.Text, txtPrice.Text), "Fatura Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {
                            entities.TransferInfo.Add(new TransferInfo
                            {
                                phone_number = Convert.ToDecimal(lblPhoneNumber.Text),
                                amount = Convert.ToDecimal(result),
                                transfer_phone_number = Convert.ToDecimal(lbTransferUserInfo.Text),
                                transfer_amount = Convert.ToDecimal(txtPrice.Text),
                                create_date = DateTime.Now
                            });
                            entities.SaveChanges();

                            member.amount = Convert.ToDecimal(result);
                            newEntities.SaveChanges();

                            var transferInfo = new BankEntities();
                            var transferUserInfo = Convert.ToDecimal(lbTransferUserInfo.Text);
                            Member transferMember = transferInfo.Member.FirstOrDefault(user => user.phone_number == transferUserInfo);
                            var transferAmount = transferMember.amount + Convert.ToDecimal(txtPrice.Text);
                            transferMember.amount = Convert.ToDecimal(transferAmount);
                            transferInfo.SaveChanges();

                            MessageBox.Show("Para Transferi Gerçekleşti.", "Transfer İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Transfer transfer = new Transfer();
                            transfer.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Para Transfer İşlemi İptal Edildi.", "Transfer İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            Transfer transfer = new Transfer();
                            transfer.ShowDialog();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Yetersiz Bakiye", "Transfer İşlemi Başarısız" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        Transfer transfer = new Transfer();
                        transfer.ShowDialog();
                    }               
                }

                else
                {
                    MessageBox.Show("Hatalı Giriş.", "Transfer İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Transfer transfer = new Transfer();
                    transfer.ShowDialog();
                }

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
