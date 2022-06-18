namespace ATM
{
    partial class PayBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAmountInfo = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.cbBill = new System.Windows.Forms.ComboBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblBillPrice = new System.Windows.Forms.Label();
            this.txtBillPrice = new System.Windows.Forms.TextBox();
            this.btnApproved = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblPhoneNumber.Location = new System.Drawing.Point(316, 49);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(18, 22);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "-";
            // 
            // lblAmountInfo
            // 
            this.lblAmountInfo.AutoSize = true;
            this.lblAmountInfo.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblAmountInfo.Location = new System.Drawing.Point(561, 49);
            this.lblAmountInfo.Name = "lblAmountInfo";
            this.lblAmountInfo.Size = new System.Drawing.Size(85, 22);
            this.lblAmountInfo.TabIndex = 16;
            this.lblAmountInfo.Text = "Bakiye :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblAmount.Location = new System.Drawing.Point(664, 49);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(18, 22);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "-";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.HotPink;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.Location = new System.Drawing.Point(615, 361);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 59);
            this.btnMenu.TabIndex = 18;
            this.btnMenu.Text = "Ana Menü";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cbBill
            // 
            this.cbBill.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBill.FormattingEnabled = true;
            this.cbBill.Items.AddRange(new object[] {
            "Su",
            "Doğalgaz",
            "Elektrik",
            "İnternet",
            "Telefon"});
            this.cbBill.Location = new System.Drawing.Point(412, 145);
            this.cbBill.Name = "cbBill";
            this.cbBill.Size = new System.Drawing.Size(162, 28);
            this.cbBill.TabIndex = 19;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBill.Location = new System.Drawing.Point(183, 145);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(105, 22);
            this.lblBill.TabIndex = 20;
            this.lblBill.Text = "Fatura Seç";
            // 
            // lblBillPrice
            // 
            this.lblBillPrice.AutoSize = true;
            this.lblBillPrice.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillPrice.Location = new System.Drawing.Point(183, 218);
            this.lblBillPrice.Name = "lblBillPrice";
            this.lblBillPrice.Size = new System.Drawing.Size(157, 22);
            this.lblBillPrice.TabIndex = 21;
            this.lblBillPrice.Text = "Fatura Tutarı Gir";
            // 
            // txtBillPrice
            // 
            this.txtBillPrice.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillPrice.Location = new System.Drawing.Point(412, 215);
            this.txtBillPrice.Name = "txtBillPrice";
            this.txtBillPrice.Size = new System.Drawing.Size(162, 29);
            this.txtBillPrice.TabIndex = 22;
            this.txtBillPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillPrice_KeyPress);
            // 
            // btnApproved
            // 
            this.btnApproved.BackColor = System.Drawing.Color.Gold;
            this.btnApproved.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApproved.Location = new System.Drawing.Point(286, 295);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(216, 50);
            this.btnApproved.TabIndex = 23;
            this.btnApproved.Text = "Onayla";
            this.btnApproved.UseVisualStyleBackColor = false;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.ForeColor = System.Drawing.Color.Blue;
            this.lblPhone.Location = new System.Drawing.Point(86, 49);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(180, 22);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Telefon Numarası :";
            // 
            // PayBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.txtBillPrice);
            this.Controls.Add(this.lblBillPrice);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.cbBill);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAmountInfo);
            this.Controls.Add(this.lblAmount);
            this.Name = "PayBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayBills";
            this.Load += new System.EventHandler(this.PayBills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAmountInfo;
        public System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cbBill;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblBillPrice;
        private System.Windows.Forms.TextBox txtBillPrice;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Label lblPhone;
    }
}