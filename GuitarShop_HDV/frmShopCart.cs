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
    public partial class frmShopCart : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        responseShopCart res;
        public frmShopCart()
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

        public async Task<List<ShopCart>> GetListShopCarByID(int userID)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var body = "{\"userID\": " + userID + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/getCart", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            res = JsonConvert.DeserializeObject<responseShopCart>(json);

            return res.cartsData;
        }


        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private async void frmShopCart_Load(object sender, EventArgs e)
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
            Program.listCart = await GetListShopCarByID(Program.user.id);
            Program.idShopCart = Program.listCart[0].id;
            bdsShopCart.DataSource = Program.listCart;
            dgvShopCart.DataSource = Program.listCart;
            Program.idGuitar = Program.listCart[0].idGuitar;
            Program.guitarName= Program.listCart[0].guitarName; 
            txtGuitarName.Text = Program.listCart[0].guitarName;
            lblAmount.Text = Program.listCart[0].amount.ToString();
            lblQuantity.Text = Program.listCart[0].quantity.ToString();
            pbxImage.ImageLocation = Program.listCart[0].imageURL;
            Program.total = 1.0 * Program.listCart[0].quantity * Program.listCart[0].amount;
            txtPrice.Text = Program.total.ToString();
        }

        private void dgvShopCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                Program.idGuitar = Program.listCart[e.RowIndex].idGuitar;
                Program.guitarName = Program.listCart[e.RowIndex].guitarName;
                Program.idShopCart = Program.listCart[e.RowIndex].id;
                txtGuitarName.Text = Program.listCart[e.RowIndex].guitarName;
                lblAmount.Text = Program.listCart[e.RowIndex].amount.ToString();
                lblQuantity.Text = Program.listCart[e.RowIndex].quantity.ToString();
                pbxImage.ImageLocation = Program.listCart[e.RowIndex].imageURL;
                Program.total = 1.0 * Program.listCart[e.RowIndex].quantity * Program.listCart[e.RowIndex].amount;
                txtPrice.Text = Program.total.ToString();
            }
        }

        private void dgvShopCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Program.idGuitar = Program.listCart[e.RowIndex].idGuitar;
                Program.guitarName = Program.listCart[e.RowIndex].guitarName;
                Program.idShopCart = Program.listCart[e.RowIndex].id;
                txtGuitarName.Text = Program.listCart[e.RowIndex].guitarName;
                lblAmount.Text = Program.listCart[e.RowIndex].amount.ToString();
                lblQuantity.Text = Program.listCart[e.RowIndex].quantity.ToString();
                pbxImage.ImageLocation = Program.listCart[e.RowIndex].imageURL;
                Program.total = 1.0 * Program.listCart[e.RowIndex].quantity * Program.listCart[e.RowIndex].amount;
                txtPrice.Text = Program.total.ToString();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTransaction));
            if (frm != null) frm.Activate();
            else
            {
                frmTransaction f = new frmTransaction();
                f.Show();
            }
            this.Hide();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var body = "{\"id\": " + Program.idShopCart + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/cart/delete", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            MessageBox.Show("Xoá thành công");
            Program.listCart = await GetListShopCarByID(Program.user.id);

            bdsShopCart.DataSource = Program.listCart;
            dgvShopCart.DataSource = Program.listCart;
            txtGuitarName.Text = Program.listCart[0].guitarName;
            lblAmount.Text = Program.listCart[0].amount.ToString();
            lblQuantity.Text = Program.listCart[0].quantity.ToString();
            double price = 1.0 * Program.listCart[0].quantity * Program.listCart[0].amount;
            txtPrice.Text = price.ToString();
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

        private void guitarManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orderManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
