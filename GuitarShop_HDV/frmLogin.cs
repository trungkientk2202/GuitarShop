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
    public partial class frmLogin : Form
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
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải đúng định dạng: abc@gmail.com");
                return;
            }
            

            var body = "{\"email\": \"" + txtEmail.Text + "\"," + "\"password\":\"" + txtPass.Text + "\"}";
            var buffer = Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            reponse = await client.PostAsync("api/v1/login", byteContent);
            var json = await reponse.Content.ReadAsStringAsync();
            try
            {
                responseUser res = JsonConvert.DeserializeObject<responseUser>(json);
                if (res.message!=null)
                {
                    if (res.message.Equals("OK"))
                    {
                        Program.user =  res.user;
                        
                        Form frm = this.CheckExists(typeof(frmMain));
                        if (frm != null) frm.Activate();
                        else
                        {
                            frmMain f = new frmMain();
                            f.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(res.message);
                    }
                }
                else
                {
                    
                    MessageBox.Show("Đăng nhập không thành công, vui lòng xem lại tài khoản và mật khẩu!");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi Đăng nhập!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
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

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var stream = await client.GetStreamAsync("http://localhost:8889/api/v1/image1?imageName=background.jpg");
            panel1.BackgroundImage = new Bitmap(stream);

        }
    }
}
