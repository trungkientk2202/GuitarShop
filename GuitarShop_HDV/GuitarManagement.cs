using GuitarShop_HDV.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop_HDV
{
    public partial class GuitarManagement : Form
    {
        HttpClient client;
        HttpResponseMessage response;
        responseGuitar res;
        int position=0;
        int check = 0;
        string filePath = "";
        public GuitarManagement()
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


        private void GuitarManagement_Load(object sender, EventArgs e)
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
            bdsGuitar.DataSource = Program.list;
            dgvGuitar.DataSource = Program.list;
            Program.idGuitar = Program.list[0].id;
            txtName.Text = Program.list[0].name.Trim();
            txtContents.Text = Program.list[0].contents;
            pbx1.ImageLocation = Program.list[0].imageURL;
            txtView.Text = Program.list[0].views.ToString();
            //.Text = await GetListCategory(Program.idGuitar);//api get category
            txtPrice.Text =  Program.list[0].price.ToString();
            txtDiscount.Text =  Program.list[0].discount.ToString();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
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

        private void dgvGuitar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = dgvGuitar.SelectedCells[0].RowIndex;
            Program.idGuitar = Program.list[position].id;
            txtName.Text = Program.list[position].name.Trim();
            txtContents.Text = Program.list[position].contents;
            pbx1.ImageLocation = Program.list[position].imageURL;
            txtView.Text = Program.list[position].views.ToString();
            //.Text = await GetListCategory(Program.idGuitar);//api get category
            txtPrice.Text = Program.list[position].price.ToString();
            txtDiscount.Text = Program.list[position].discount.ToString();
            btnInsert.Text = "Cập nhật";
            check = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtContents.Text = "";
            pbx1.ImageLocation = null;
            txtView.Text = "";
            //.Text = await GetListCategory(Program.idGuitar);//api get category
            txtPrice.Text = "";
            txtDiscount.Text = "";
            btnInsert.Text = "Thêm mới";
            pbx1.ImageLocation = null;
            check = 1;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var body = "{\"id\": " + Program.list[position].id + "}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            response = await client.PostAsync("api/v1/guitar/delete", byteContent);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                responseGuitar res = JsonConvert.DeserializeObject<responseGuitar>(json);
                if (res.errCode.Equals(0))
                {
                    response = await client.GetAsync("api/v1/guitar");
                    json = await response.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<responseGuitar>(json);
                    Program.list = res.data;
                    bdsGuitar.DataSource = Program.list;
                    dgvGuitar.DataSource = Program.list;
                    MessageBox.Show("Xóa guitar thành công!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!");
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                var body = "{\"id\": " + Program.list[position].id
                    + "," + "\"name\":\"" + txtName.Text+"\""
                    + "," + "\"price\":" + txtPrice.Text 
                    + "," + "\"contents\":\"" + txtContents.Text + "\""
                    + "," + "\"discount\":" + txtDiscount.Text
                    + "," + "\"views\":" + txtView.Text
                    + "}";
                var buffer = Encoding.UTF8.GetBytes(body);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
                response = await client.PostAsync("api/v1/guitar/update", byteContent);
                var json = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Sửa thông tin thành công!");
            }
            else
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File [{filePath}] not found.");

                var form = new MultipartFormDataContent();
                ByteArrayContent fileContent = new ByteArrayContent(File.ReadAllBytes(filePath));
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

                form.Add(fileContent, "file", Path.GetFileName(filePath));
                form.Add(new StringContent(txtName.Text), "name");
                form.Add(new StringContent(txtPrice.Text), "price");
                form.Add(new StringContent(txtContents.Text), "contents");
                form.Add(new StringContent(txtDiscount.Text), "discount");
                form.Add(new StringContent(txtView.Text), "views");
                response = await client.PostAsync("api/v1/guitar/add", form);
                var json = await response.Content.ReadAsStringAsync();
                try
                {
                    responseGuitar res = JsonConvert.DeserializeObject<responseGuitar>(json);
                    if (res.errCode.Equals(0))
                    {
                        
                        response = await client.GetAsync("api/v1/guitar");
                        json = await response.Content.ReadAsStringAsync();
                        res = JsonConvert.DeserializeObject<responseGuitar>(json);
                        Program.list = res.data;
                        bdsGuitar.DataSource = Program.list;
                        dgvGuitar.DataSource = Program.list;
                        MessageBox.Show("Thêm mới thành công!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbx1.Image = new Bitmap(opnfd.FileName);
                filePath = opnfd.FileName;
            }
            
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void guitarManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
    }
}
