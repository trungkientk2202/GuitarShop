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
    public partial class frmPurchaseHistory : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        responseGuitar res;
        List<Order> list = new List<Order>();
        List<Order> listTransaction = new List<Order>();
        int position = 0;
        public frmPurchaseHistory()
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
        private async void frmPurchaseHistory_Load(object sender, EventArgs e)
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
            list = res.orderDatas;
            if (list.Count > 0)
            {
                //lọc theo useriD
                List<Order> list2 = new List<Order>();
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].userID == Program.user.id)
                    {
                        list2.Add(list[i]);
                    }
                }
                if (list2.Count > 0)
                {
                    //lọc theo transaction
                    listTransaction.Add(list2[0]);
                    for (int i = 1; i < list2.Count; i++)
                    {
                        if (!(list2[i].transactionID == list2[i - 1].transactionID))
                        {
                            listTransaction.Add(list2[i]);
                        }
                    }
                    bdsPurchase.DataSource = listTransaction;
                    dgvPurchase.DataSource = listTransaction;
                    //set STT
                    for (int i = 0; i < listTransaction.Count; i++)
                    {
                        dgvPurchase.Rows[i].Cells[0].Value = i + 1;
                    }
                    int q = 1;
                    string txt = "";
                    //hiển thị list đặt hàng
                    for (int i = 0; i < list.Count; i++)
                    {
                        if ((list[i].transactionID == listTransaction[0].transactionID))
                        {
                            txt += q + ") Guitar: " + list[i].guitarName + "\r\n Quantity: " + list[i].quantity + "\r\n Amount: " + list[i].amount + "\r\n\r\n";
                            q++;
                        }
                    }
                    txtList.Text = txt;
                    if (listTransaction[0].isCanceled == true)
                    {
                        lblStatus.Text = "Tình trạng: Đã hủy";
                        btnHuy.Enabled = false;
                    }
                    else
                    {
                        if (listTransaction[0].status == true)
                        {
                            lblStatus.Text = "Tình trạng: Đã mua";
                            btnHuy.Enabled = false;
                        }
                        else
                        {
                            lblStatus.Text = "Tình trạng: Đang giao hàng";
                            btnHuy.Enabled = true;
                        }
                    }
                }
            }


        }

        
        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position != -1)
            {
                int q = 1;
                string txt = "";
                for (int i = 0; i < list.Count; i++)
                {
                    if ((list[i].transactionID == listTransaction[position].transactionID))
                    {
                        txt += q + ") Guitar: " + list[i].guitarName + "\r\n Quantity: " + list[i].quantity + "\r\n Amount: " + list[i].amount + "\r\n\r\n";
                        q++;
                    }
                }
                txtList.Text = txt;
                if (listTransaction[position].isCanceled == true)
                {
                    lblStatus.Text = "Tình trạng: Đã hủy";
                    btnHuy.Enabled = false;
                }
                else
                {
                    if (listTransaction[position].status == true)
                    {
                        lblStatus.Text = "Tình trạng: Đã mua";
                        btnHuy.Enabled = false;
                    }
                    else
                    {
                        lblStatus.Text = "Tình trạng: Đang giao hàng";
                        btnHuy.Enabled = true;
                    }
                }
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

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private async void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn hủy đơn hàng này?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                return;
            }
            var body = "{\"id\": " + listTransaction[position].transactionID + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/cancelTransaction", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {

                reponse = await client.GetAsync("api/v1/order");
                json = await reponse.Content.ReadAsStringAsync();
                responseOrder res = JsonConvert.DeserializeObject<responseOrder>(json);
                list = res.orderDatas;
                if (list.Count > 0)
                {
                    //lọc theo useriD
                    List<Order> list2 = new List<Order>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].userID == Program.user.id)
                        {
                            list2.Add(list[i]);
                        }
                    }
                    if (list2.Count > 0)
                    {
                        listTransaction.Clear();
                        //lọc theo transaction
                        listTransaction.Add(list2[0]);
                        for (int i = 1; i < list2.Count; i++)
                        {
                            if (!(list2[i].transactionID == list2[i - 1].transactionID))
                            {
                                listTransaction.Add(list2[i]);
                            }
                        }
                        bdsPurchase.DataSource = null;
                        dgvPurchase.DataSource = null;
                        bdsPurchase.DataSource = listTransaction;
                        dgvPurchase.DataSource = listTransaction;
                        //set STT
                        for (int i = 0; i < listTransaction.Count; i++)
                        {
                            dgvPurchase.Rows[i].Cells[0].Value = i + 1;
                        }
                        int q = 1;
                        string txt = "";
                        //hiển thị list đặt hàng
                        for (int i = 0; i < list.Count; i++)
                        {
                            if ((list[i].transactionID == listTransaction[0].transactionID))
                            {
                                txt += q + ") Guitar: " + list[i].guitarName + "\r\n Quantity: " + list[i].quantity + "\r\n Amount: " + list[i].amount + "\r\n\r\n";
                                q++;
                            }
                        }
                        txtList.Text = txt;
                        if (listTransaction[0].isCanceled == true)
                        {
                            lblStatus.Text = "Tình trạng: Đã hủy";
                            btnHuy.Enabled = false;
                        }
                        else
                        {
                            if (listTransaction[0].status == true)
                            {
                                lblStatus.Text = "Tình trạng: Đã mua";
                                btnHuy.Enabled = false;
                            }
                            else
                            {
                                lblStatus.Text = "Tình trạng: Đang giao hàng";
                                btnHuy.Enabled = true;
                            }
                        }
                    }

                }

                MessageBox.Show("Xác nhận đơn hàng thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnBack_Click(object sender, EventArgs e)
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
