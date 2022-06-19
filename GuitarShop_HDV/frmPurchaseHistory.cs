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
        List<PurchaseHistory> listAll =new List<PurchaseHistory>();
        List<PurchaseHistory> listDG = new List<PurchaseHistory>();
        List<PurchaseHistory> listDM = new List<PurchaseHistory>();
        List<PurchaseHistory> listDH = new List<PurchaseHistory>();
        int type = 1;
        int idOrder = 0;
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
            var body = "{\"userID\": " + Program.user.id + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/getOrder", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responsePurchase res = JsonConvert.DeserializeObject<responsePurchase>(json);
                if (res.message.Equals("ok"))
                {
                    listAll = res.orderData;
                    foreach(PurchaseHistory pur in listAll)
                    {
                        if (pur.isCanceled==false)
                        {
                            if (pur.status == true)
                            {
                                listDM.Add(pur);
                            }
                            else
                            {
                                if (pur.UserCanceled == false)
                                {

                                    listDG.Add(pur);
                                }
                                else
                                {
                                    listDH.Add(pur);
                                }
                            }
                        }
                        else
                        {
                            listDH.Add(pur);
                        }
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!");
                return;
            }
            dgvPurchase.DataSource = listDG;
            btnDangGiao.BackColor = System.Drawing.Color.DodgerBlue;
            btnHuy.Enabled = true;
            if (listDG != null)
            {
                idOrder = listDG[0].id;
                lblName.Text = "Name: " + listDG[0].name;
                lblQuantity.Text = "Quantity: " + listDG[0].quantity;
                lblAmount.Text = "Amount: " + listDG[0].amount;
                lblDate.Text = "Date: " + listDG[0].created;
            }
            else
            {
                lblName.Text = "Name: " ;
                lblQuantity.Text = "Quantity: " ;
                lblAmount.Text = "Amount: ";
                lblDate.Text = "Date: ";
            }
        }

        private void btnDaMua_Click(object sender, EventArgs e)
        {
            type = 2;
            btnDangGiao.BackColor = System.Drawing.SystemColors.Control;
            btnDaHuy.BackColor = System.Drawing.SystemColors.Control;
            btnDaMua.BackColor = System.Drawing.Color.DodgerBlue;
            dgvPurchase.DataSource = listDM;
            dgvPurchase.Refresh();
            btnHuy.Enabled = false;
            if (listDM.Count > 0)
            {
                idOrder = listDM[0].id;
                lblName.Text = "Name: " + listDM[0].name;
                lblQuantity.Text = "Quantity: " + listDM[0].quantity;
                lblAmount.Text = "Amount: " + listDM[0].amount;
                lblDate.Text = "Quantity: " + listDM[0].created;
            }
            else
            {
                idOrder = 0;
                lblName.Text = "Name: ";
                lblQuantity.Text = "Quantity: ";
                lblAmount.Text = "Amount: ";
                lblDate.Text = "Quantity: ";
            }
        }

        private void btnDaHuy_Click(object sender, EventArgs e)
        {
            type = 3;
            btnDangGiao.BackColor = System.Drawing.SystemColors.Control;
            btnDaMua.BackColor = System.Drawing.SystemColors.Control;
            btnDaHuy.BackColor = System.Drawing.Color.DodgerBlue;
            dgvPurchase.DataSource = listDH;
            dgvPurchase.Refresh();
            btnHuy.Enabled = false;
            if (listDH.Count > 0)
            {
                idOrder = listDH[0].id;
                lblName.Text = "Name: " + listDH[0].name;
                lblQuantity.Text = "Quantity: " + listDH[0].quantity;
                lblAmount.Text = "Amount: " + listDH[0].amount;
                lblDate.Text = "Date: " + listDH[0].created;
            }
            else
            {
                idOrder = 0;
                lblName.Text = "Name: ";
                lblQuantity.Text = "Quantity: ";
                lblAmount.Text = "Amount: ";
                lblDate.Text = "Date: ";
            }
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case 1:
                    if (listDG.Count > 0)
                    {
                        idOrder = listDG[e.RowIndex].id;
                        lblName.Text = "Name: " + listDG[e.RowIndex].name;
                        lblQuantity.Text = "Quantity: " + listDG[e.RowIndex].quantity;
                        lblAmount.Text = "Amount: " + listDG[e.RowIndex].amount;
                        lblDate.Text = "Date: " + listDG[e.RowIndex].created;
                    }
                    else
                    {
                        lblName.Text = "Name: ";
                        lblQuantity.Text = "Quantity: ";
                        lblAmount.Text = "Amount: ";
                        lblDate.Text = "Date: ";
                    }
                    break;
                case 2:
                    if (listDM.Count > 0)
                    {
                        idOrder = listDM[e.RowIndex].id;
                        lblName.Text = "Name: " + listDM[e.RowIndex].name;
                        lblQuantity.Text = "Quantity: " + listDM[e.RowIndex].quantity;
                        lblAmount.Text = "Amount: " + listDM[e.RowIndex].amount;
                        lblDate.Text = "Date: " + listDM[e.RowIndex].created;
                    }
                    else
                    {
                        lblName.Text = "Name: ";
                        lblQuantity.Text = "Quantity: ";
                        lblAmount.Text = "Amount: ";
                        lblDate.Text = "Date: ";
                    }
                    break;
                case 3:
                    if (listDH.Count > 0)
                    {
                        idOrder = listDH[e.RowIndex].id;
                        lblName.Text = "Name: " + listDH[e.RowIndex].name;
                        lblQuantity.Text = "Quantity: " + listDH[e.RowIndex].quantity;
                        lblAmount.Text = "Amount: " + listDH[e.RowIndex].amount;
                        lblDate.Text = "Date: " + listDH[e.RowIndex].created;
                    }
                    else
                    {
                        lblName.Text = "Name: ";
                        lblQuantity.Text = "Quantity: ";
                        lblAmount.Text = "Amount: ";
                        lblDate.Text = "Date: ";
                    }
                    break;
            }
        }

        private void btnDangGiao_Click(object sender, EventArgs e)
        {
            type = 1;
            dgvPurchase.DataSource = listDG;
            dgvPurchase.Refresh();
            btnDangGiao.BackColor = System.Drawing.Color.DodgerBlue;
            btnDaHuy.BackColor = System.Drawing.SystemColors.Control;
            btnDaMua.BackColor = System.Drawing.SystemColors.Control;
            btnHuy.Enabled = true;
            if (listDG.Count > 0)
            {
                idOrder = listDG[0].id;
                lblName.Text = "Name: " + listDG[0].name;
                lblQuantity.Text = "Quantity: " + listDG[0].quantity;
                lblAmount.Text = "Amount: " + listDG[0].amount;
                lblDate.Text = "Date: " + listDG[0].created;
            }
            else
            {
                idOrder = 0;
                lblName.Text = "Name: ";
                lblQuantity.Text = "Quantity: ";
                lblAmount.Text = "Amount: ";
                lblDate.Text = "Date: ";
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
            //MessageBox.Show(idOrder.ToString());
            var body = "{\"id\": "+idOrder + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/cancelOrder", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                foreach(PurchaseHistory temp in listAll)
                {
                    if(temp.id== idOrder)
                    {
                        listDH.Add(temp);
                        listDG.Remove(temp);
                        dgvPurchase.DataSource = null;
                        dgvPurchase.DataSource = listDG;
                        MessageBox.Show("Hủy thành công!");
                        return;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
    }
}
