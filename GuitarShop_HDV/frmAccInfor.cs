using GuitarShop_HDV.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop_HDV
{
    public partial class frmAccInfor : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        int check = 0;
        public frmAccInfor()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                frmMain f = new frmMain();
                f.Show();
            }
            this.Hide();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmShopCart));
            if (frm != null) frm.Activate();
            else
            {
                frmShopCart f = new frmShopCart();
                f.Show();
            }
            this.Hide();
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPurchaseHistory));
            if (frm != null) frm.Activate();
            else
            {
                frmPurchaseHistory f = new frmPurchaseHistory();
                f.Show();
            }
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHome));
            if (frm != null) frm.Activate();
            else
            {
                frmHome f = new frmHome();
                f.Show();
            }
            this.Hide();
        }

        private void guitarManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(GuitarManagement));
            if (frm != null) frm.Activate();
            else
            {
                GuitarManagement f = new GuitarManagement();
                f.Show();
            }
            this.Hide();
        }

        private void orderManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(OrderManagement));
            if (frm != null) frm.Activate();
            else
            {
                OrderManagement f = new OrderManagement();
                f.Show();
            }
            this.Hide();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(Usermanagement));
            if (frm != null) frm.Activate();
            else
            {
                Usermanagement f = new Usermanagement();
                f.Show();
            }
            this.Hide();
        }

        private void frmAccInfor_Load(object sender, EventArgs e)
        {
            switch (Program.user.idRole)
            {
                case 0: //khach, chua dang nhap
                    logOutToolStripMenuItem.Enabled = HomeToolStripMenuItem.Enabled = yourInformationToolStripMenuItem.Enabled = adminToolStripMenuItem.Enabled = false;
                    loginToolStripMenuItem.Enabled = registerToolStripMenuItem.Enabled = true;
                    break;
                case 1: //admin
                    adminToolStripMenuItem.Enabled = accountToolStripMenuItem.Enabled = true;
                    loginToolStripMenuItem.Enabled = cartToolStripMenuItem.Enabled = purchaseHistoryToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    loginToolStripMenuItem.Enabled = guitarManagerToolStripMenuItem.Enabled = userManagementToolStripMenuItem.Enabled = purchaseHistoryToolStripMenuItem.Enabled = cartToolStripMenuItem.Enabled = false;
                    accountToolStripMenuItem.Enabled = orderManagerToolStripMenuItem.Enabled = true;
                    break;
                case 3: //khach hang
                    logOutToolStripMenuItem.Enabled = yourInformationToolStripMenuItem.Enabled = HomeToolStripMenuItem.Enabled = true;
                    loginToolStripMenuItem.Enabled = registerToolStripMenuItem.Enabled = adminToolStripMenuItem.Enabled = false;
                    break;
            }
            lblEmail.Text = Program.user.email;
            txtName.Text = Program.user.name;
            lblPhone.Text = Program.user.phone;
            txtAddress.Text = Program.user.address;
            panelPassword.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPassword.Show();
            check = 1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }
            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                return;
            }
            string pass = Program.user.password;
            if (check == 1)
            {
                if (!txtPassword.Text.Equals(Program.user.password))
                {
                    MessageBox.Show("Sai mật khẩu hiện tại!");
                    return;
                }
                if (txtNewPassword.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                    return;
                }
                if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Mật khẩu không khớp!");
                    return;
                }
                pass = txtNewPassword.Text;
            }
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var body = "{\"id\": " + Program.user.id + "," + "\"name\": \"" + txtName.Text + "\"" + "," + "\"phone\": \"" + lblPhone.Text + "\""
                + "," + "\"address\": \"" + txtAddress.Text + "\"" + "," + "\"password\": \"" + pass + "\""
                + "," + "\"isDeleted\": " + 0
                + "," + "\"idRole\": " + Program.user.idRole  + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/user/update", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseUser res = JsonConvert.DeserializeObject<responseUser>(json);
                if (!res.errCode.Equals(0))
                {
                    MessageBox.Show("Có lỗi!");
                    return;
                }
                MessageBox.Show("Thay đổi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!");
                return;
            }
        }

        private void yourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
