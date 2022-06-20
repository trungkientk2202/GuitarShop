
namespace GuitarShop_HDV
{
    partial class GuitarManagement
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
            this.components = new System.ComponentModel.Container();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guitarManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvGuitar = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsGuitar = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtView = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuitar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManagementToolStripMenuItem.Text = "User management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // guitarManagerToolStripMenuItem
            // 
            this.guitarManagerToolStripMenuItem.Name = "guitarManagerToolStripMenuItem";
            this.guitarManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guitarManagerToolStripMenuItem.Text = "Guitar management";
            this.guitarManagerToolStripMenuItem.Click += new System.EventHandler(this.guitarManagerToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guitarManagerToolStripMenuItem,
            this.orderManagerToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // orderManagerToolStripMenuItem
            // 
            this.orderManagerToolStripMenuItem.Name = "orderManagerToolStripMenuItem";
            this.orderManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderManagerToolStripMenuItem.Text = "Order management";
            this.orderManagerToolStripMenuItem.Click += new System.EventHandler(this.orderManagerToolStripMenuItem_Click);
            // 
            // yourInformationToolStripMenuItem
            // 
            this.yourInformationToolStripMenuItem.Name = "yourInformationToolStripMenuItem";
            this.yourInformationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yourInformationToolStripMenuItem.Text = "Your Information";
            this.yourInformationToolStripMenuItem.Click += new System.EventHandler(this.yourInformationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.yourInformationToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // purchaseHistoryToolStripMenuItem
            // 
            this.purchaseHistoryToolStripMenuItem.Name = "purchaseHistoryToolStripMenuItem";
            this.purchaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseHistoryToolStripMenuItem.Text = "Purchase History";
            this.purchaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.purchaseHistoryToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cartToolStripMenuItem.Text = "Cart";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.cartToolStripMenuItem,
            this.purchaseHistoryToolStripMenuItem});
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.HomeToolStripMenuItem.Text = "Home";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvGuitar
            // 
            this.dgvGuitar.AutoGenerateColumns = false;
            this.dgvGuitar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuitar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvGuitar.DataSource = this.bdsGuitar;
            this.dgvGuitar.Location = new System.Drawing.Point(12, 181);
            this.dgvGuitar.Name = "dgvGuitar";
            this.dgvGuitar.Size = new System.Drawing.Size(310, 400);
            this.dgvGuitar.TabIndex = 0;
            this.dgvGuitar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuitar_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // bdsGuitar
            // 
            this.bdsGuitar.DataSource = typeof(GuitarShop_HDV.Models.guitar);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvGuitar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 697);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(94, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách các đàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(165, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUITAR SHOP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(353, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 697);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(196, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Guitar management";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtView);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.txtContents);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.addImage);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnInsert);
            this.panel4.Controls.Add(this.lblDiscount);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblCategory);
            this.panel4.Controls.Add(this.lblView);
            this.panel4.Controls.Add(this.pbx1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 567);
            this.panel4.TabIndex = 3;
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(565, 376);
            this.txtView.Name = "txtView";
            this.txtView.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.Properties.Appearance.Options.UseFont = true;
            this.txtView.Size = new System.Drawing.Size(137, 28);
            this.txtView.TabIndex = 23;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(565, 332);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Size = new System.Drawing.Size(137, 28);
            this.txtPrice.TabIndex = 22;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(565, 285);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Size = new System.Drawing.Size(137, 28);
            this.txtDiscount.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(565, 99);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(391, 28);
            this.txtName.TabIndex = 20;
            // 
            // txtContents
            // 
            this.txtContents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.Location = new System.Drawing.Point(565, 134);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.Size = new System.Drawing.Size(391, 145);
            this.txtContents.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(836, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addImage
            // 
            this.addImage.BackColor = System.Drawing.Color.Aqua;
            this.addImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImage.ForeColor = System.Drawing.Color.Navy;
            this.addImage.Location = new System.Drawing.Point(175, 478);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(120, 40);
            this.addImage.TabIndex = 12;
            this.addImage.Text = "Thêm ảnh";
            this.addImage.UseVisualStyleBackColor = false;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(789, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Aqua;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Navy;
            this.btnInsert.Location = new System.Drawing.Point(552, 478);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 40);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Cập nhật";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(473, 378);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 23);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "View:";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(473, 334);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 23);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(473, 287);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 23);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Discount:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblView
            // 
            this.lblView.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(473, 151);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(100, 23);
            this.lblView.TabIndex = 5;
            this.lblView.Text = "Contents:";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.Transparent;
            this.pbx1.Location = new System.Drawing.Point(39, 51);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(400, 400);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 2;
            this.pbx1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 721);
            this.panel1.TabIndex = 1;
            // 
            // GuitarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.panel1);
            this.Name = "GuitarManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuitarManagement";
            this.Load += new System.EventHandler(this.GuitarManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuitar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guitarManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bdsGuitar;
        private System.Windows.Forms.DataGridView dgvGuitar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txtView;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.TextBox txtContents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}