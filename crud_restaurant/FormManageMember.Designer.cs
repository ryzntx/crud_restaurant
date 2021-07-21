
namespace crud_restaurant
{
    partial class FormManageMember
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
            this.dgv_manageMember = new System.Windows.Forms.DataGridView();
            this.txb_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txb_memberID = new System.Windows.Forms.TextBox();
            this.txb_nama = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_handphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manageMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Form Atur Member";
            // 
            // dgv_manageMember
            // 
            this.dgv_manageMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manageMember.Location = new System.Drawing.Point(9, 85);
            this.dgv_manageMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_manageMember.Name = "dgv_manageMember";
            this.dgv_manageMember.RowHeadersWidth = 51;
            this.dgv_manageMember.RowTemplate.Height = 24;
            this.dgv_manageMember.Size = new System.Drawing.Size(582, 122);
            this.dgv_manageMember.TabIndex = 8;
            this.dgv_manageMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manageMember_CellDoubleClick);
            // 
            // txb_cari
            // 
            this.txb_cari.Location = new System.Drawing.Point(9, 212);
            this.txb_cari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_cari.Name = "txb_cari";
            this.txb_cari.Size = new System.Drawing.Size(121, 20);
            this.txb_cari.TabIndex = 9;
            this.txb_cari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_cari_KeyDown);
            // 
            // btn_cari
            // 
            this.btn_cari.AutoSize = true;
            this.btn_cari.Location = new System.Drawing.Point(134, 211);
            this.btn_cari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(76, 23);
            this.btn_cari.TabIndex = 10;
            this.btn_cari.Text = "Cari Member";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txb_memberID
            // 
            this.txb_memberID.Location = new System.Drawing.Point(420, 213);
            this.txb_memberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_memberID.Name = "txb_memberID";
            this.txb_memberID.Size = new System.Drawing.Size(144, 20);
            this.txb_memberID.TabIndex = 11;
            // 
            // txb_nama
            // 
            this.txb_nama.Location = new System.Drawing.Point(420, 236);
            this.txb_nama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_nama.Name = "txb_nama";
            this.txb_nama.Size = new System.Drawing.Size(144, 20);
            this.txb_nama.TabIndex = 12;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(420, 258);
            this.txb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(144, 20);
            this.txb_email.TabIndex = 13;
            // 
            // txb_handphone
            // 
            this.txb_handphone.Location = new System.Drawing.Point(420, 281);
            this.txb_handphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_handphone.Name = "txb_handphone";
            this.txb_handphone.Size = new System.Drawing.Size(144, 20);
            this.txb_handphone.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Handphone";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(338, 326);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 41);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(248, 326);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(78, 41);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(154, 326);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(78, 41);
            this.btn_insert.TabIndex = 27;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // FormManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_handphone);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_nama);
            this.Controls.Add(this.txb_memberID);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.txb_cari);
            this.Controls.Add(this.dgv_manageMember);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormManageMember";
            this.Text = "Atur Member";
            this.Load += new System.EventHandler(this.FormManageMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manageMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_manageMember;
        private System.Windows.Forms.TextBox txb_cari;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txb_memberID;
        private System.Windows.Forms.TextBox txb_nama;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_handphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
    }
}