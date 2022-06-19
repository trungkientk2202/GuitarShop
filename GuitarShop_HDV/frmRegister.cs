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
    public partial class frmRegister : Form
    {
        HttpClient client;
        HttpResponseMessage reponse;
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
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

        private async void btnRegister_ClickAsync(object sender, EventArgs e)
        {
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải đúng định dạng: abc@gmail.com");
                return;
            }
            if (txtPhone.Text.Length!=10)
            {
                MessageBox.Show("Số điện thoại gồm 10 kí tự");
                return;
            }
            var body = "{\"name\": \"" + txtName.Text + "\"," + "\"email\": \"" + txtEmail.Text + "\","+"\"password\": \"" + txtPass.Text + "\","+"\"address\": \"" + txtAddress.Text + "\","+"\"phone\":\"" + txtPhone.Text + "\"}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/regis", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseUser res = JsonConvert.DeserializeObject<responseUser>(json);
                
                MessageBox.Show(res.message);
                Form frm = this.CheckExists(typeof(frmHome));
                if (frm != null) frm.Activate();
                else
                {
                    frmHome f = new frmHome();
                    f.Show();
                }
                this.Hide();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Đăng nhập!");
            }
            //post API Register
            

        }

        private async void frmRegister_Load(object sender, EventArgs e)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var stream = await client.GetStreamAsync("http://localhost:8889/api/v1/image1?imageName=background.jpg");
            panel1.BackgroundImage = new Bitmap(stream);
        }
    }
}
