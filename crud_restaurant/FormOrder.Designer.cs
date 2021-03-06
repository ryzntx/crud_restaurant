
namespace crud_restaurant
{
    partial class FormOrder
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
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.txb_namaMenu = new System.Windows.Forms.TextBox();
            this.txb_qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.btn_insertOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txb_menuId = new System.Windows.Forms.TextBox();
            this.txb_orderId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hapusOrder = new System.Windows.Forms.Button();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order";
            // 
            // dgv_menu
            // 
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(6, 45);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.Size = new System.Drawing.Size(564, 133);
            this.dgv_menu.TabIndex = 9;
            this.dgv_menu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellDoubleClick);
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_image.Location = new System.Drawing.Point(62, 245);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(162, 123);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 10;
            this.pb_image.TabStop = false;
            // 
            // txb_namaMenu
            // 
            this.txb_namaMenu.Location = new System.Drawing.Point(410, 245);
            this.txb_namaMenu.Name = "txb_namaMenu";
            this.txb_namaMenu.Size = new System.Drawing.Size(153, 20);
            this.txb_namaMenu.TabIndex = 11;
            // 
            // txb_qty
            // 
            this.txb_qty.Location = new System.Drawing.Point(410, 271);
            this.txb_qty.Name = "txb_qty";
            this.txb_qty.Size = new System.Drawing.Size(153, 20);
            this.txb_qty.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Qty";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(320, 345);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Tambahkan";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(401, 345);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Hapus";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(6, 51);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.Size = new System.Drawing.Size(564, 161);
            this.dgv_order.TabIndex = 17;
            this.dgv_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellDoubleClick);
            // 
            // btn_insertOrder
            // 
            this.btn_insertOrder.Location = new System.Drawing.Point(247, 218);
            this.btn_insertOrder.Name = "btn_insertOrder";
            this.btn_insertOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_insertOrder.TabIndex = 18;
            this.btn_insertOrder.Text = "Order";
            this.btn_insertOrder.UseVisualStyleBackColor = true;
            this.btn_insertOrder.Click += new System.EventHandler(this.btn_insertOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Karbohidrat: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Protein: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total: ";
            // 
            // txb_cari
            // 
            this.txb_cari.Location = new System.Drawing.Point(389, 18);
            this.txb_cari.Name = "txb_cari";
            this.txb_cari.Size = new System.Drawing.Size(100, 20);
            this.txb_cari.TabIndex = 22;
            this.txb_cari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_cari_KeyDown);
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(495, 16);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 23;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txb_menuId
            // 
            this.txb_menuId.Location = new System.Drawing.Point(398, 118);
            this.txb_menuId.Name = "txb_menuId";
            this.txb_menuId.Size = new System.Drawing.Size(153, 20);
            this.txb_menuId.TabIndex = 26;
            // 
            // txb_orderId
            // 
            this.txb_orderId.Location = new System.Drawing.Point(88, 19);
            this.txb_orderId.Name = "txb_orderId";
            this.txb_orderId.ReadOnly = true;
            this.txb_orderId.Size = new System.Drawing.Size(100, 20);
            this.txb_orderId.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Order ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_menu);
            this.groupBox1.Controls.Add(this.txb_cari);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.txb_menuId);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 184);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btn_hapusOrder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txb_orderId);
            this.groupBox2.Controls.Add(this.btn_insertOrder);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgv_order);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 256);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Order";
            // 
            // btn_hapusOrder
            // 
            this.btn_hapusOrder.AutoSize = true;
            this.btn_hapusOrder.Location = new System.Drawing.Point(445, 16);
            this.btn_hapusOrder.Name = "btn_hapusOrder";
            this.btn_hapusOrder.Size = new System.Drawing.Size(125, 23);
            this.btn_hapusOrder.TabIndex = 31;
            this.btn_hapusOrder.Text = "Bersihkan Daftar Order";
            this.btn_hapusOrder.UseVisualStyleBackColor = true;
            this.btn_hapusOrder.Click += new System.EventHandler(this.btn_hapusOrder_Click);
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(410, 297);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(153, 20);
            this.txb_price.TabIndex = 31;
            this.txb_price.Visible = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(194, 16);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 32;
            this.btn_refresh.Text = "Refresh ID";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 653);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_qty);
            this.Controls.Add(this.txb_namaMenu);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.label1);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrder_FormClosing);
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.TextBox txb_namaMenu;
        private System.Windows.Forms.TextBox txb_qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Button btn_insertOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_cari;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txb_menuId;
        private System.Windows.Forms.TextBox txb_orderId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_hapusOrder;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Button btn_refresh;
    }
}