
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
    public partial class frmHome : Form
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

        public frmHome()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
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

        private void lblRegister_Click(object sender, EventArgs e)
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

        private void lblGuest_Click(object sender, EventArgs e)
        {
            Program.user.idRole = 0;
            //guest
            Form frm = this.CheckExists(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                frmMain f = new frmMain();
                f.Show();
            }
            this.Hide();

        }

        private async void frmHome_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8889/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var stream = await client.GetStreamAsync("http://localhost:8889/api/v1/image1?imageName=background.jpg");
            panelHome.BackgroundImage = new Bitmap(stream);
        }
    }
}
