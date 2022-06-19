using System;
using GuitarShop_HDV.Models;
using GuitarShop_HDV.Response;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GuitarShop_HDV
{
    public partial class frmMain : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        responseGuitar res;
        
        int position=0;
        double price;
        public void Resonsitory()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<List<guitar>> GetListGuitar()
        {
            reponse = await client.GetAsync("api/v1/guitar");
            var json = await reponse.Content.ReadAsStringAsync();
            res = JsonConvert.DeserializeObject<responseGuitar>(json);

            return res.data;
        }
        
        public async Task<String> GetListCategory(int idGuitar)
        {
            string output = "Category: ";
            var body = "{\"idGuitar\": " + idGuitar + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/getCategory", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseCategory res = JsonConvert.DeserializeObject<responseCategory>(json);
                if (res.message.Equals("ok"))
                {
                    for (int i = 0; i < res.categoryData.Count; i++)
                    {
                        output += res.categoryData[i].name + " ";
                    }
                    return output;

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!");
            }

            return output;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
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

        

        private async void frmMain_Load(object sender, EventArgs e)
        {
            switch (Program.user.idRole)
            {
                case 0: //khach, chua dang nhap
                    logOutToolStripMenuItem.Enabled = HomeToolStripMenuItem.Enabled = yourInformationToolStripMenuItem.Enabled = adminToolStripMenuItem.Enabled = false;
                    loginToolStripMenuItem.Enabled = registerToolStripMenuItem.Enabled = true;
                    btnAddToCart.Enabled = false;
                    break;
                case 1: //admin
                    btnAddToCart.Enabled = false;
                    adminToolStripMenuItem.Enabled = accountToolStripMenuItem.Enabled = true;
                    loginToolStripMenuItem.Enabled = cartToolStripMenuItem.Enabled = purchaseHistoryToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    btnAddToCart.Enabled = false;
                    loginToolStripMenuItem.Enabled = guitarManagerToolStripMenuItem.Enabled = userManagementToolStripMenuItem.Enabled= purchaseHistoryToolStripMenuItem.Enabled = cartToolStripMenuItem.Enabled = false;
                    accountToolStripMenuItem.Enabled = orderManagerToolStripMenuItem.Enabled = true;
                    break;
                case 3: //khach hang
                    btnAddToCart.Enabled = true;
                    logOutToolStripMenuItem.Enabled = yourInformationToolStripMenuItem.Enabled = HomeToolStripMenuItem.Enabled = true;
                    loginToolStripMenuItem.Enabled = registerToolStripMenuItem.Enabled = adminToolStripMenuItem.Enabled = false;
                    break;
            }
            Resonsitory();
            Program.list = await GetListGuitar();
            bdsGuitar.DataSource = Program.list;
            dgvGuitar.DataSource = Program.list;
            Program.idGuitar = Program.list[0].id;
            lblName.Text = Program.list[0].name.Trim();
            txtContents.Text = Program.list[0].contents;
            pbx1.ImageLocation = Program.list[0].imageURL;
            lblView.Text = "View:"+ Program.list[0].views.ToString();
            lblCategory.Text = await GetListCategory(Program.idGuitar);//api get category
            lblPrice.Text = "Price: "+ Program.list[0].price.ToString();
            lblDiscount.Text ="Discount: "+ Program.list[0].discount.ToString();
            lblMoney.Text = "Money: "+(Program.list[0].price * (1 - 1.0 * Program.list[0].discount / 100)).ToString();
        }
        
        private void btnBuy_Click(object sender, EventArgs e)
        {

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


        private async void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (Program.user.idRole == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập để mua hàng!");
                return;
            }
            var body = "{\"userID\": " + Program.user.id + "," + "\"idGuitar\":" + Program.idGuitar + "," + "\"quantity\":" + 1 + ","  + "\"amount\":" + price.ToString() + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/cart/add", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseShopCart res = JsonConvert.DeserializeObject<responseShopCart>(json);
                if (res.message!=null)
                {
                    MessageBox.Show(res.message);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!");
                return; 
            }

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

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
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

        private async void dgvGuitar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = dgvGuitar.SelectedCells[0].RowIndex;
            Program.idGuitar = Program.list[position].id;
            lblName.Text = Program.list[position].name.Trim();
            txtContents.Text = Program.list[position].contents;
            pbx1.ImageLocation = Program.list[position].imageURL;
            lblView.Text = "View:" + Program.list[position].views.ToString();
            lblCategory.Text = await GetListCategory(Program.idGuitar);//api get category
            lblPrice.Text = "Price: " + Program.list[position].price.ToString();
            lblDiscount.Text = "Discount: " + Program.list[position].discount.ToString();
            price = (double)(Program.list[position].price * (1 - 1.0 * Program.list[position].discount / 100));
            lblMoney.Text = "Money: " + price.ToString();
        }
    }
}
