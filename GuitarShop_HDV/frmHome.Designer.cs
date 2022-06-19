
namespace GuitarShop_HDV
{
    partial class frmHome
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.label5);
            this.panelHome.Controls.Add(this.lblGuest);
            this.panelHome.Controls.Add(this.lblRegister);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.lblLogin);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(748, 497);
            this.panelHome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(357, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ: 97 Man Thiện, P. Hiệp Phú, TP. Thủ Đức";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGuest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(425, 298);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(179, 19);
            this.lblGuest.TabIndex = 4;
            this.lblGuest.Text = "Đăng nhập dưới dạng khách";
            this.lblGuest.Click += new System.EventHandler(this.lblGuest_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRegister.Location = new System.Drawing.Point(520, 279);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(58, 19);
            this.lblRegister.TabIndex = 3;
            this.lblRegister.Text = "Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(414, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to Guitar shop!";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLogin.Location = new System.Drawing.Point(461, 279);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 19);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(351, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUITAR SHOP";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 497);
            this.Controls.Add(this.panelHome);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guitar Shop";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
    }
}

