
namespace crud_restaurant
{
    partial class FormAdmin
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_manageMenu = new System.Windows.Forms.Button();
            this.btn_manageMember = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_laporan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigasi Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selamat Datang, [Admin]";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(231, 130);
            this.btn_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(124, 34);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_manageMenu
            // 
            this.btn_manageMenu.Location = new System.Drawing.Point(231, 169);
            this.btn_manageMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_manageMenu.Name = "btn_manageMenu";
            this.btn_manageMenu.Size = new System.Drawing.Size(124, 34);
            this.btn_manageMenu.TabIndex = 3;
            this.btn_manageMenu.Text = "Atur Menu";
            this.btn_manageMenu.UseVisualStyleBackColor = true;
            this.btn_manageMenu.Click += new System.EventHandler(this.btn_manageMenu_Click);
            // 
            // btn_manageMember
            // 
            this.btn_manageMember.Location = new System.Drawing.Point(231, 208);
            this.btn_manageMember.Margin = new System.Windows.Forms.Padding(2);
            this.btn_manageMember.Name = "btn_manageMember";
            this.btn_manageMember.Size = new System.Drawing.Size(124, 34);
            this.btn_manageMember.TabIndex = 4;
            this.btn_manageMember.Text = "Atur Member";
            this.btn_manageMember.UseVisualStyleBackColor = true;
            this.btn_manageMember.Click += new System.EventHandler(this.btn_manageMember_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(231, 284);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(124, 34);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.Location = new System.Drawing.Point(231, 246);
            this.btn_laporan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(124, 34);
            this.btn_laporan.TabIndex = 6;
            this.btn_laporan.Text = "Laporan";
            this.btn_laporan.UseVisualStyleBackColor = true;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_laporan);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_manageMember);
            this.Controls.Add(this.btn_manageMenu);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "Navigasi Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_manageMenu;
        private System.Windows.Forms.Button btn_manageMember;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_laporan;
    }
}