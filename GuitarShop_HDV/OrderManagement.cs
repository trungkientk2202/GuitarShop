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
    public partial class OrderManagement : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        List<Order> list= new List<Order>();
        int position=0 ;
        public OrderManagement()
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
        private async void OderManagement_Load(object sender, EventArgs e)
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
            reponse = await client.GetAsync("api/v1/order");
            var json = await reponse.Content.ReadAsStringAsync();
            responseOrder res = JsonConvert.DeserializeObject<responseOrder>(json);
            list = res.orderDatas;
            bdsOrder.DataSource = list;
            dgvOrder.DataSource = list;
            lblUserID.Text = list[0].userID.ToString();
            lblCustomerName.Text = list[0].customerName;
            lblCustomerEmail.Text = list[0].customerEmail;
            lblCustomerPhone.Text = list[0].customerPhone;
            lblCustomerAddress.Text = list[0].customerAddress;
            lblGuitarName.Text = list[0].guitarName;
            lblQuantity.Text = list[0].quantity.ToString();
            lblAmount.Text = list[0].amount.ToString();
            lblStatus.Text = list[0].status.ToString();
            if (list[0].status == true)
            {
                btnInsert.Enabled = false;
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            lblUserID.Text = list[position].userID.ToString();
            lblCustomerName.Text = list[position].customerName;
            lblCustomerEmail.Text = list[position].customerEmail;
            lblCustomerPhone.Text = list[position].customerPhone;
            lblCustomerAddress.Text = list[position].customerAddress;
            lblGuitarName.Text = list[position].guitarName;
            lblQuantity.Text = list[position].quantity.ToString();
            lblAmount.Text = list[position].amount.ToString();
            lblStatus.Text = list[position].status.ToString();
            if(list[position].status == true)
            {
                btnInsert.Enabled = false;
            }
            else
            {
                btnInsert.Enabled = true;
            }
        }


        private async void btnInsert_Click(object sender, EventArgs e)
        {
            var body = "{\"id\": " + list[position].id + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/confirmOrder", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseOrder res = JsonConvert.DeserializeObject<responseOrder>(json);
                if (res.orderData.errCode.Equals(0))
                {
                    reponse = await client.GetAsync("api/v1/order");
                    json = await reponse.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<responseOrder>(json);
                    list = res.orderDatas;
                    bdsOrder.DataSource = list;
                    dgvOrder.DataSource = list;
                    MessageBox.Show("Xác nhận đơn hàng thành công!");

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

        private void btnReturn_Click(object sender, EventArgs e)
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
    }
}
