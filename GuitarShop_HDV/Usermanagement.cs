using GuitarShop_HDV.Models;
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
    public partial class Usermanagement : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        List<User> list = new List<User>();
        int position = 0;
        public Usermanagement()
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
        private async void Usermanagement_Load(object sender, EventArgs e)
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
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            reponse = await client.GetAsync("api/v1/user");
            var json = await reponse.Content.ReadAsStringAsync();
            responseUser res = JsonConvert.DeserializeObject<responseUser>(json);
            list = res.data;
            bdsUser.DataSource = list;
            dgvUser.DataSource = list;
            txtName.Text = list[0].name;
            txtEmail.Text = list[0].email;
            txtPhone.Text = list[0].phone;
            txtAddress.Text = list[0].address;
            cmbRole.Text = list[0].roleName;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            txtName.Text = list[position].name;
            txtEmail.Text = list[position].email;
            txtPhone.Text = list[position].phone;
            txtAddress.Text = list[position].address;
            cmbRole.Text = list[position].roleName;
        }


        private async void btnInsert_Click(object sender, EventArgs e)
        {
            int idRole;
            if(cmbRole.Text.Equals("Quản lý")){
                idRole = 1;
            }else if (cmbRole.Text.Equals("Nhân viên"))
            {
                idRole = 2;
            }
            else
            {
                idRole = 3;
            }
            
            
            
            var body = "{\"id\": " + list[position].id +","+"\"name\": \"" + txtName.Text +"\","+ "\"phone\": \"" + txtPhone.Text + "\"," +
                 "\"address\": \"" + txtAddress.Text + "\"," + "\"password\": \"" + list[position].password + "\"," + "\"isDeleted\":" + 0 + "," +
                  "\"idRole\": " + idRole + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/user/update", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseUser res = JsonConvert.DeserializeObject<responseUser>(json);
                if (res.errCode.Equals(0))
                {
                    reponse = await client.GetAsync("api/v1/user");
                    json = await reponse.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<responseUser>(json);
                    list = res.data;
                    bdsUser.DataSource = list;
                    dgvUser.DataSource = list;
                    MessageBox.Show("Thay đổi thông tin thành công!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var body = "{\"id\": "+list[position].id +"}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/user/delete", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseUser res = JsonConvert.DeserializeObject<responseUser>(json);
                if (res.errCode.Equals(0))
                {
                    reponse = await client.GetAsync("api/v1/user");
                    json = await reponse.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<responseUser>(json);
                    list = res.data;
                    bdsUser.DataSource = list;
                    dgvUser.DataSource = list;
                    MessageBox.Show("Xóa tài khoản thành công!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!");
            }
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

        private void yourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmAccInfor));
            if (frm != null) frm.Activate();
            else
            {
                frmAccInfor f = new frmAccInfor();
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
            
        }
    }
}
