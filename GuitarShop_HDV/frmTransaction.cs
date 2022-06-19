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
    public partial class frmTransaction : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        double total=0;
        string body = "{\"listCart\": [";
        List<ShopCart> list= new List<ShopCart>();
        public frmTransaction()
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

        private void frmTransaction_Load(object sender, EventArgs e)
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
            for (int i=0;i< Program.listCart.Count;i++)
            {
                if (Program.listCart[i].isOrdered == true)
                {
                    total += Program.listCart[i].amount * Program.listCart[i].quantity;
                    body += "{\"id\":" + Program.listCart[i].id
                        + "," + "\"idGuitar\":" + Program.listCart[i].idGuitar
                        + "," + "\"quantity\":" + Program.listCart[i].quantity
                        + "," + "\"amount\":" + Program.listCart[i].amount+"},";
                    list.Add(Program.listCart[i]);
                }
            }

            body = body.Substring(0,body.Length-1)+"],";
            lblTotal.Text = "Tổng tiền: " + total+"VND";
            bdsShopCart.DataSource = list;
            dgvShopCart.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập Email!");
                return;
            }
            
            if (txtPhone.Text.Trim().Equals("")|| txtPhone.Text.Length!=10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!");
                return;
            }
            if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                return;
            }
            body += "\"userID\":" + Program.listCart[0].userID
                 + "," + "\"customerName\":\"" + txtName.Text + "\""
                  + "," + "\"customerEmail\":\"" + txtEmail.Text + "\""
                  + "," + "\"customerPhone\":\"" + txtPhone.Text + "\""
                  + "," + "\"customerAddress\":\"" + txtAddress.Text + "\""
                  + "," + "\"amount\":" + total
                  + "," + "\"message\":\"" + "Đặt hàng"+"\""
                  + "," + "\"status\":" + 0
                  + "," + "\"note\":\"" + "Đặt hàng" + "\"}";
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/transaction/add", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            
            MessageBox.Show("Đặt hàng thành công!");
            Form frm = this.CheckExists(typeof(frmShopCart));
            if (frm != null) frm.Activate();
            else
            {
                frmShopCart f = new frmShopCart();
                f.Show();
            }
            this.Hide();
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

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRegister));
            if (frm != null) frm.Activate();
            else
            {
                frmRegister f = new frmRegister();
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

        
    }
}
