
namespace GuitarShop_HDV
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guitarManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsGuitar = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGuitar = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuitar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cartToolStripMenuItem.Text = "Cart";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // purchaseHistoryToolStripMenuItem
            // 
            this.purchaseHistoryToolStripMenuItem.Name = "purchaseHistoryToolStripMenuItem";
            this.purchaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseHistoryToolStripMenuItem.Text = "Purchase History";
            this.purchaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.purchaseHistoryToolStripMenuItem_Click);
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
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // yourInformationToolStripMenuItem
            // 
            this.yourInformationToolStripMenuItem.Name = "yourInformationToolStripMenuItem";
            this.yourInformationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yourInformationToolStripMenuItem.Text = "Your Information";
            this.yourInformationToolStripMenuItem.Click += new System.EventHandler(this.yourInformationToolStripMenuItem_Click);
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
            // guitarManagerToolStripMenuItem
            // 
            this.guitarManagerToolStripMenuItem.Name = "guitarManagerToolStripMenuItem";
            this.guitarManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guitarManagerToolStripMenuItem.Text = "Guitar management";
            this.guitarManagerToolStripMenuItem.Click += new System.EventHandler(this.guitarManagerToolStripMenuItem_Click);
            // 
            // orderManagerToolStripMenuItem
            // 
            this.orderManagerToolStripMenuItem.Name = "orderManagerToolStripMenuItem";
            this.orderManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderManagerToolStripMenuItem.Text = "Order management";
            this.orderManagerToolStripMenuItem.Click += new System.EventHandler(this.orderManagerToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManagementToolStripMenuItem.Text = "User management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // bdsGuitar
            // 
            this.bdsGuitar.DataSource = typeof(GuitarShop_HDV.Models.guitar);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1341, 697);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dgvGuitar);
            this.panel4.Controls.Add(this.txtContents);
            this.panel4.Controls.Add(this.btnBuy);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.btnAddToCart);
            this.panel4.Controls.Add(this.lblMoney);
            this.panel4.Controls.Add(this.lblDiscount);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblCategory);
            this.panel4.Controls.Add(this.lblView);
            this.panel4.Controls.Add(this.pbx1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1341, 624);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách các đàn";
            // 
            // dgvGuitar
            // 
            this.dgvGuitar.AutoGenerateColumns = false;
            this.dgvGuitar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuitar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvGuitar.DataSource = this.bdsGuitar;
            this.dgvGuitar.Location = new System.Drawing.Point(12, 43);
            this.dgvGuitar.Name = "dgvGuitar";
            this.dgvGuitar.Size = new System.Drawing.Size(221, 557);
            this.dgvGuitar.TabIndex = 0;
            this.dgvGuitar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuitar_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 177;
            // 
            // txtContents
            // 
            this.txtContents.BackColor = System.Drawing.Color.White;
            this.txtContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.Location = new System.Drawing.Point(856, 86);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.ReadOnly = true;
            this.txtContents.Size = new System.Drawing.Size(464, 142);
            this.txtContents.TabIndex = 4;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Aqua;
            this.btnBuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Navy;
            this.btnBuy.Location = new System.Drawing.Point(1130, 555);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(120, 30);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(871, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(458, 40);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên Đàn";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Aqua;
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Navy;
            this.btnAddToCart.Location = new System.Drawing.Point(901, 555);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(120, 30);
            this.btnAddToCart.TabIndex = 10;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(897, 474);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(132, 22);
            this.lblMoney.TabIndex = 9;
            this.lblMoney.Text = "Money";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(897, 425);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(124, 23);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Discount:";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(897, 373);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(141, 23);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(897, 313);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(276, 23);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblView
            // 
            this.lblView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(897, 247);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(100, 23);
            this.lblView.TabIndex = 5;
            this.lblView.Text = "view";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.Transparent;
            this.pbx1.Location = new System.Drawing.Point(248, 0);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(585, 600);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 2;
            this.pbx1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(488, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUITAR SHOP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 721);
            this.panel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guitar Shop";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuitar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsGuitar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guitarManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtContents;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}