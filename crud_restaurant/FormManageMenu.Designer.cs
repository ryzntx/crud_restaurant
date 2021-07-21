
namespace crud_restaurant
{
    partial class FormManageMenu
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
            this.dgv_mangeMenu = new System.Windows.Forms.DataGridView();
            this.txb_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txb_menuID = new System.Windows.Forms.TextBox();
            this.txb_namaMenu = new System.Windows.Forms.TextBox();
            this.txb_filePath = new System.Windows.Forms.TextBox();
            this.txb_hargaMenu = new System.Windows.Forms.TextBox();
            this.txb_protein = new System.Windows.Forms.TextBox();
            this.txb_carbo = new System.Windows.Forms.TextBox();
            this.btn_pickFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pb_fotoFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mangeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoFile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Form Atur Menu";
            // 
            // dgv_mangeMenu
            // 
            this.dgv_mangeMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mangeMenu.Location = new System.Drawing.Point(12, 147);
            this.dgv_mangeMenu.Name = "dgv_mangeMenu";
            this.dgv_mangeMenu.RowHeadersWidth = 51;
            this.dgv_mangeMenu.RowTemplate.Height = 24;
            this.dgv_mangeMenu.Size = new System.Drawing.Size(776, 150);
            this.dgv_mangeMenu.TabIndex = 8;
            this.dgv_mangeMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mangeMenu_CellDoubleClick);
            // 
            // txb_cari
            // 
            this.txb_cari.Location = new System.Drawing.Point(565, 119);
            this.txb_cari.Name = "txb_cari";
            this.txb_cari.Size = new System.Drawing.Size(135, 22);
            this.txb_cari.TabIndex = 9;
            this.txb_cari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_cari_KeyDown);
            // 
            // btn_cari
            // 
            this.btn_cari.AutoSize = true;
            this.btn_cari.Location = new System.Drawing.Point(706, 117);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(82, 27);
            this.btn_cari.TabIndex = 10;
            this.btn_cari.Text = "Cari Menu";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txb_menuID
            // 
            this.txb_menuID.Location = new System.Drawing.Point(147, 303);
            this.txb_menuID.Name = "txb_menuID";
            this.txb_menuID.Size = new System.Drawing.Size(186, 22);
            this.txb_menuID.TabIndex = 11;
            // 
            // txb_namaMenu
            // 
            this.txb_namaMenu.Location = new System.Drawing.Point(147, 331);
            this.txb_namaMenu.Name = "txb_namaMenu";
            this.txb_namaMenu.Size = new System.Drawing.Size(186, 22);
            this.txb_namaMenu.TabIndex = 12;
            // 
            // txb_filePath
            // 
            this.txb_filePath.Location = new System.Drawing.Point(147, 387);
            this.txb_filePath.Name = "txb_filePath";
            this.txb_filePath.Size = new System.Drawing.Size(186, 22);
            this.txb_filePath.TabIndex = 14;
            // 
            // txb_hargaMenu
            // 
            this.txb_hargaMenu.Location = new System.Drawing.Point(147, 359);
            this.txb_hargaMenu.Name = "txb_hargaMenu";
            this.txb_hargaMenu.Size = new System.Drawing.Size(186, 22);
            this.txb_hargaMenu.TabIndex = 13;
            // 
            // txb_protein
            // 
            this.txb_protein.Location = new System.Drawing.Point(147, 443);
            this.txb_protein.Name = "txb_protein";
            this.txb_protein.Size = new System.Drawing.Size(186, 22);
            this.txb_protein.TabIndex = 16;
            // 
            // txb_carbo
            // 
            this.txb_carbo.Location = new System.Drawing.Point(147, 415);
            this.txb_carbo.Name = "txb_carbo";
            this.txb_carbo.Size = new System.Drawing.Size(186, 22);
            this.txb_carbo.TabIndex = 15;
            // 
            // btn_pickFile
            // 
            this.btn_pickFile.AutoSize = true;
            this.btn_pickFile.Location = new System.Drawing.Point(349, 385);
            this.btn_pickFile.Name = "btn_pickFile";
            this.btn_pickFile.Size = new System.Drawing.Size(75, 27);
            this.btn_pickFile.TabIndex = 17;
            this.btn_pickFile.Text = "......";
            this.btn_pickFile.UseVisualStyleBackColor = true;
            this.btn_pickFile.Click += new System.EventHandler(this.btn_pickFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Menu ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nama Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Foto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Karbohidrat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Protein";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(439, 439);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(104, 51);
            this.btn_insert.TabIndex = 24;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(565, 439);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 51);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(684, 439);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 51);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pb_fotoFile
            // 
            this.pb_fotoFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_fotoFile.Location = new System.Drawing.Point(487, 308);
            this.pb_fotoFile.Name = "pb_fotoFile";
            this.pb_fotoFile.Size = new System.Drawing.Size(213, 109);
            this.pb_fotoFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fotoFile.TabIndex = 27;
            this.pb_fotoFile.TabStop = false;
            // 
            // FormManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.pb_fotoFile);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pickFile);
            this.Controls.Add(this.txb_protein);
            this.Controls.Add(this.txb_carbo);
            this.Controls.Add(this.txb_filePath);
            this.Controls.Add(this.txb_hargaMenu);
            this.Controls.Add(this.txb_namaMenu);
            this.Controls.Add(this.txb_menuID);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.txb_cari);
            this.Controls.Add(this.dgv_mangeMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormManageMenu";
            this.Text = "Atur Menu";
            this.Load += new System.EventHandler(this.FormManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mangeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_mangeMenu;
        private System.Windows.Forms.TextBox txb_cari;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txb_menuID;
        private System.Windows.Forms.TextBox txb_namaMenu;
        private System.Windows.Forms.TextBox txb_filePath;
        private System.Windows.Forms.TextBox txb_hargaMenu;
        private System.Windows.Forms.TextBox txb_protein;
        private System.Windows.Forms.TextBox txb_carbo;
        private System.Windows.Forms.Button btn_pickFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pb_fotoFile;
    }
}