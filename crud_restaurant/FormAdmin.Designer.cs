
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigasi Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selamat Datang, [Admin]";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(308, 206);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(165, 42);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_manageMenu
            // 
            this.btn_manageMenu.Location = new System.Drawing.Point(308, 254);
            this.btn_manageMenu.Name = "btn_manageMenu";
            this.btn_manageMenu.Size = new System.Drawing.Size(165, 42);
            this.btn_manageMenu.TabIndex = 3;
            this.btn_manageMenu.Text = "Atur Menu";
            this.btn_manageMenu.UseVisualStyleBackColor = true;
            this.btn_manageMenu.Click += new System.EventHandler(this.btn_manageMenu_Click);
            // 
            // btn_manageMember
            // 
            this.btn_manageMember.Location = new System.Drawing.Point(308, 302);
            this.btn_manageMember.Name = "btn_manageMember";
            this.btn_manageMember.Size = new System.Drawing.Size(165, 42);
            this.btn_manageMember.TabIndex = 4;
            this.btn_manageMember.Text = "Atur Member";
            this.btn_manageMember.UseVisualStyleBackColor = true;
            this.btn_manageMember.Click += new System.EventHandler(this.btn_manageMember_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(308, 350);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(165, 42);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_manageMember);
            this.Controls.Add(this.btn_manageMenu);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}