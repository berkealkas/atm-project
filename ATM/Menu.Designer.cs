namespace ATM
{
    partial class Menu
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
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnPayBills = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountInfo = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.BackColor = System.Drawing.Color.PaleGreen;
            this.btnWithdrawMoney.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWithdrawMoney.Location = new System.Drawing.Point(98, 111);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(139, 65);
            this.btnWithdrawMoney.TabIndex = 0;
            this.btnWithdrawMoney.Text = "Para Çek";
            this.btnWithdrawMoney.UseVisualStyleBackColor = false;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // btnPayBills
            // 
            this.btnPayBills.BackColor = System.Drawing.Color.Yellow;
            this.btnPayBills.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayBills.Location = new System.Drawing.Point(570, 201);
            this.btnPayBills.Name = "btnPayBills";
            this.btnPayBills.Size = new System.Drawing.Size(139, 66);
            this.btnPayBills.TabIndex = 2;
            this.btnPayBills.Text = "Fatura Öde";
            this.btnPayBills.UseVisualStyleBackColor = false;
            this.btnPayBills.Click += new System.EventHandler(this.btnPayBills_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Plum;
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransfer.Location = new System.Drawing.Point(570, 111);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(139, 65);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Havale";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.BackColor = System.Drawing.Color.Orange;
            this.btnDepositMoney.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepositMoney.Location = new System.Drawing.Point(98, 201);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(139, 66);
            this.btnDepositMoney.TabIndex = 4;
            this.btnDepositMoney.Text = "Para Yatır";
            this.btnDepositMoney.UseVisualStyleBackColor = false;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDepositMoney_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(98, 310);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(139, 65);
            this.btnUpdateInfo.TabIndex = 5;
            this.btnUpdateInfo.Text = "Bilgi Güncelleme";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblAmount.Location = new System.Drawing.Point(451, 43);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(19, 23);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "-";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountInfo
            // 
            this.lblAmountInfo.AutoSize = true;
            this.lblAmountInfo.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmountInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblAmountInfo.Location = new System.Drawing.Point(348, 43);
            this.lblAmountInfo.Name = "lblAmountInfo";
            this.lblAmountInfo.Size = new System.Drawing.Size(89, 23);
            this.lblAmountInfo.TabIndex = 11;
            this.lblAmountInfo.Text = "Bakiye :";
            this.lblAmountInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Crimson;
            this.btnMain.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMain.ForeColor = System.Drawing.Color.Black;
            this.btnMain.Location = new System.Drawing.Point(570, 310);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(139, 65);
            this.btnMain.TabIndex = 26;
            this.btnMain.Text = "Ana Sayfa";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblAmountInfo);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnPayBills);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnPayBills;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnUpdateInfo;
        public System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAmountInfo;
        private System.Windows.Forms.Button btnMain;
    }
}