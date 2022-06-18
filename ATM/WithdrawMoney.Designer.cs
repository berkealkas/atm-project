namespace ATM
{
    partial class WithdrawMoney
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
            this.btnPrice10 = new System.Windows.Forms.Button();
            this.btnPrice20 = new System.Windows.Forms.Button();
            this.btnPrice50 = new System.Windows.Forms.Button();
            this.btnPrice500 = new System.Windows.Forms.Button();
            this.btnPrice200 = new System.Windows.Forms.Button();
            this.btnPrice100 = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnApproved = new System.Windows.Forms.Button();
            this.lblAmountInfo = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrice10
            // 
            this.btnPrice10.BackColor = System.Drawing.Color.Yellow;
            this.btnPrice10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice10.Location = new System.Drawing.Point(60, 93);
            this.btnPrice10.Name = "btnPrice10";
            this.btnPrice10.Size = new System.Drawing.Size(91, 42);
            this.btnPrice10.TabIndex = 0;
            this.btnPrice10.Text = "10";
            this.btnPrice10.UseVisualStyleBackColor = false;
            this.btnPrice10.Click += new System.EventHandler(this.btnPrice10_Click);
            // 
            // btnPrice20
            // 
            this.btnPrice20.BackColor = System.Drawing.Color.Yellow;
            this.btnPrice20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice20.Location = new System.Drawing.Point(60, 169);
            this.btnPrice20.Name = "btnPrice20";
            this.btnPrice20.Size = new System.Drawing.Size(91, 42);
            this.btnPrice20.TabIndex = 1;
            this.btnPrice20.Text = "20";
            this.btnPrice20.UseVisualStyleBackColor = false;
            this.btnPrice20.Click += new System.EventHandler(this.btnPrice20_Click);
            // 
            // btnPrice50
            // 
            this.btnPrice50.BackColor = System.Drawing.Color.Yellow;
            this.btnPrice50.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice50.Location = new System.Drawing.Point(60, 254);
            this.btnPrice50.Name = "btnPrice50";
            this.btnPrice50.Size = new System.Drawing.Size(91, 42);
            this.btnPrice50.TabIndex = 2;
            this.btnPrice50.Text = "50";
            this.btnPrice50.UseVisualStyleBackColor = false;
            this.btnPrice50.Click += new System.EventHandler(this.btnPrice50_Click);
            // 
            // btnPrice500
            // 
            this.btnPrice500.BackColor = System.Drawing.Color.Yellow;
            this.btnPrice500.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice500.Location = new System.Drawing.Point(651, 254);
            this.btnPrice500.Name = "btnPrice500";
            this.btnPrice500.Size = new System.Drawing.Size(91, 42);
            this.btnPrice500.TabIndex = 3;
            this.btnPrice500.Text = "500";
            this.btnPrice500.UseVisualStyleBackColor = false;
            this.btnPrice500.Click += new System.EventHandler(this.btnPrice500_Click);
            // 
            // btnPrice200
            // 
            this.btnPrice200.BackColor = System.Drawing.Color.Yellow;
            this.btnPrice200.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice200.Location = new System.Drawing.Point(651, 169);
            this.btnPrice200.Name = "btnPrice200";
            this.btnPrice200.Size = new System.Drawing.Size(91, 42);
            this.btnPrice200.TabIndex = 4;
            this.btnPrice200.Text = "200";
            this.btnPrice200.UseVisualStyleBackColor = false;
            this.btnPrice200.Click += new System.EventHandler(this.btnPrice200_Click);
            // 
            // btnPrice100
            // 
            this.btnPrice100.BackColor = System.Drawing.Color.Yellow;
            this.btnPrice100.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice100.Location = new System.Drawing.Point(651, 93);
            this.btnPrice100.Name = "btnPrice100";
            this.btnPrice100.Size = new System.Drawing.Size(91, 42);
            this.btnPrice100.TabIndex = 5;
            this.btnPrice100.Text = "100";
            this.btnPrice100.UseVisualStyleBackColor = false;
            this.btnPrice100.Click += new System.EventHandler(this.btnPrice100_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblDescription.Location = new System.Drawing.Point(183, 328);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(235, 22);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Çekmek İstediğiniz Tutar";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Location = new System.Drawing.Point(446, 327);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 27);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // btnApproved
            // 
            this.btnApproved.BackColor = System.Drawing.Color.Cyan;
            this.btnApproved.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApproved.Location = new System.Drawing.Point(333, 382);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(153, 43);
            this.btnApproved.TabIndex = 8;
            this.btnApproved.Text = "Onayla";
            this.btnApproved.UseVisualStyleBackColor = false;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // lblAmountInfo
            // 
            this.lblAmountInfo.AutoSize = true;
            this.lblAmountInfo.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblAmountInfo.Location = new System.Drawing.Point(489, 31);
            this.lblAmountInfo.Name = "lblAmountInfo";
            this.lblAmountInfo.Size = new System.Drawing.Size(85, 22);
            this.lblAmountInfo.TabIndex = 13;
            this.lblAmountInfo.Text = "Bakiye :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblAmount.Location = new System.Drawing.Point(592, 31);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(18, 22);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "-";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblPhoneNumber.Location = new System.Drawing.Point(343, 31);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(18, 22);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "-";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Pink;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.Location = new System.Drawing.Point(631, 382);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 43);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Ana Menü";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.ForeColor = System.Drawing.Color.Blue;
            this.lblPhone.Location = new System.Drawing.Point(136, 31);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(180, 22);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Telefon Numarası :";
            // 
            // WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAmountInfo);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnPrice100);
            this.Controls.Add(this.btnPrice200);
            this.Controls.Add(this.btnPrice500);
            this.Controls.Add(this.btnPrice50);
            this.Controls.Add(this.btnPrice20);
            this.Controls.Add(this.btnPrice10);
            this.Name = "WithdrawMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawMoney";
            this.Load += new System.EventHandler(this.WithdrawMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrice10;
        private System.Windows.Forms.Button btnPrice20;
        private System.Windows.Forms.Button btnPrice50;
        private System.Windows.Forms.Button btnPrice500;
        private System.Windows.Forms.Button btnPrice200;
        private System.Windows.Forms.Button btnPrice100;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Label lblAmountInfo;
        public System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblPhone;
    }
}