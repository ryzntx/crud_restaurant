
namespace crud_restaurant
{
    partial class FormPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_orderId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_payment = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_typePay = new System.Windows.Forms.ComboBox();
            this.cmb_bankName = new System.Windows.Forms.ComboBox();
            this.txb_cardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txb_cash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_member = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pembayaran";
            // 
            // cmb_orderId
            // 
            this.cmb_orderId.FormattingEnabled = true;
            this.cmb_orderId.Location = new System.Drawing.Point(321, 130);
            this.cmb_orderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_orderId.Name = "cmb_orderId";
            this.cmb_orderId.Size = new System.Drawing.Size(160, 24);
            this.cmb_orderId.TabIndex = 10;
            this.cmb_orderId.Text = "Pilih Order ID";
            this.cmb_orderId.SelectedValueChanged += new System.EventHandler(this.cmb_orderId_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order ID";
            // 
            // dgv_payment
            // 
            this.dgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payment.Location = new System.Drawing.Point(16, 164);
            this.dgv_payment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_payment.Name = "dgv_payment";
            this.dgv_payment.RowHeadersWidth = 51;
            this.dgv_payment.Size = new System.Drawing.Size(768, 188);
            this.dgv_payment.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // cmb_typePay
            // 
            this.cmb_typePay.FormattingEnabled = true;
            this.cmb_typePay.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cmb_typePay.Location = new System.Drawing.Point(309, 417);
            this.cmb_typePay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_typePay.Name = "cmb_typePay";
            this.cmb_typePay.Size = new System.Drawing.Size(189, 24);
            this.cmb_typePay.TabIndex = 14;
            this.cmb_typePay.Text = "Pilih Pembayaran";
            this.cmb_typePay.SelectedIndexChanged += new System.EventHandler(this.cmb_typePay_SelectedIndexChanged);
            // 
            // cmb_bankName
            // 
            this.cmb_bankName.FormattingEnabled = true;
            this.cmb_bankName.Items.AddRange(new object[] {
            "Bank BRI",
            "Bank BNI",
            "Bank Mandiri",
            "Bank BJB",
            "Bank BCA"});
            this.cmb_bankName.Location = new System.Drawing.Point(309, 449);
            this.cmb_bankName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_bankName.Name = "cmb_bankName";
            this.cmb_bankName.Size = new System.Drawing.Size(189, 24);
            this.cmb_bankName.TabIndex = 16;
            this.cmb_bankName.Text = "Pilih Nama Bank";
            // 
            // txb_cardNumber
            // 
            this.txb_cardNumber.Location = new System.Drawing.Point(309, 484);
            this.txb_cardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_cardNumber.Name = "txb_cardNumber";
            this.txb_cardNumber.Size = new System.Drawing.Size(189, 22);
            this.txb_cardNumber.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipe Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 490);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nomor Kartu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 455);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nama Bank";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(321, 516);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(161, 41);
            this.btn_insert.TabIndex = 21;
            this.btn_insert.Text = "Simpan / Cetak";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txb_cash
            // 
            this.txb_cash.Location = new System.Drawing.Point(309, 451);
            this.txb_cash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_cash.Name = "txb_cash";
            this.txb_cash.Size = new System.Drawing.Size(189, 22);
            this.txb_cash.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 455);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Uang";
            // 
            // txb_member
            // 
            this.txb_member.Location = new System.Drawing.Point(309, 385);
            this.txb_member.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_member.Name = "txb_member";
            this.txb_member.Size = new System.Drawing.Size(189, 22);
            this.txb_member.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(144, 391);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Member";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 27;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_member);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_cash);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_cardNumber);
            this.Controls.Add(this.cmb_bankName);
            this.Controls.Add(this.cmb_typePay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_orderId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPayment";
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_orderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_typePay;
        private System.Windows.Forms.ComboBox cmb_bankName;
        private System.Windows.Forms.TextBox txb_cardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txb_cash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_member;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}