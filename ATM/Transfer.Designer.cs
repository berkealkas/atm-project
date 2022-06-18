namespace ATM
{
    partial class Transfer
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
            this.btnApproved = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTransferPrice = new System.Windows.Forms.Label();
            this.lbTransferUserInfo = new System.Windows.Forms.ListBox();
            this.lblTransferUser = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblPhoneNumber.Location = new System.Drawing.Point(339, 51);
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
            this.lblAmountInfo.Location = new System.Drawing.Point(492, 51);
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
            this.lblAmount.Location = new System.Drawing.Point(595, 51);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(18, 22);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "-";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Red;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(631, 338);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(122, 53);
            this.btnMenu.TabIndex = 21;
            this.btnMenu.Text = "Ana Menü";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnApproved
            // 
            this.btnApproved.BackColor = System.Drawing.Color.Gold;
            this.btnApproved.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApproved.Location = new System.Drawing.Point(286, 338);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(220, 53);
            this.btnApproved.TabIndex = 20;
            this.btnApproved.Text = "Onayla";
            this.btnApproved.UseVisualStyleBackColor = false;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Location = new System.Drawing.Point(472, 266);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 27);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblTransferPrice
            // 
            this.lblTransferPrice.AutoSize = true;
            this.lblTransferPrice.BackColor = System.Drawing.Color.White;
            this.lblTransferPrice.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransferPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblTransferPrice.Location = new System.Drawing.Point(136, 266);
            this.lblTransferPrice.Name = "lblTransferPrice";
            this.lblTransferPrice.Size = new System.Drawing.Size(297, 22);
            this.lblTransferPrice.TabIndex = 18;
            this.lblTransferPrice.Text = "Transfer Etmek İstediğiniz Tutar";
            // 
            // lbTransferUserInfo
            // 
            this.lbTransferUserInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTransferUserInfo.FormattingEnabled = true;
            this.lbTransferUserInfo.ItemHeight = 18;
            this.lbTransferUserInfo.Location = new System.Drawing.Point(472, 149);
            this.lbTransferUserInfo.Name = "lbTransferUserInfo";
            this.lbTransferUserInfo.Size = new System.Drawing.Size(162, 40);
            this.lbTransferUserInfo.TabIndex = 22;
            // 
            // lblTransferUser
            // 
            this.lblTransferUser.AutoSize = true;
            this.lblTransferUser.BackColor = System.Drawing.Color.White;
            this.lblTransferUser.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransferUser.ForeColor = System.Drawing.Color.Blue;
            this.lblTransferUser.Location = new System.Drawing.Point(136, 149);
            this.lblTransferUser.Name = "lblTransferUser";
            this.lblTransferUser.Size = new System.Drawing.Size(251, 44);
            this.lblTransferUser.TabIndex = 23;
            this.lblTransferUser.Text = "Transfer Etmek İstediğiniz \r\nKişinin Telefon Numarası";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.ForeColor = System.Drawing.Color.Blue;
            this.lblPhone.Location = new System.Drawing.Point(122, 51);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(180, 22);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Telefon Numarası :";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTransferUser);
            this.Controls.Add(this.lbTransferUserInfo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblTransferPrice);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAmountInfo);
            this.Controls.Add(this.lblAmount);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAmountInfo;
        public System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox lbTransferUserInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTransferPrice;
        private System.Windows.Forms.Label lblTransferUser;
    }
}