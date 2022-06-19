using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop_HDV
{
    static class Program
    {
        public static User user=new User();
        public static int idGuitar = 0;
        public static int idShopCart = 0;
        public static string guitarName = "";
        public static double total = 0;
        public static List<guitar> list;
        public static List<ShopCart> listCart;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            user.idRole = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
