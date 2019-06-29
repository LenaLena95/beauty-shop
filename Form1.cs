using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (BeautyShopEntities db = new BeautyShopEntities())
            {
                string m=null;
                string n = null;
                foreach(var us in db.User)
                { if (textBoxPassword.Text == us.Password && TextBoxUserName.Text == us.UserName)
                    m="Hello";
                else
                    n="Указаны не существующие данные имя/пароль";
                }
                if (m == "Hello")
                    MessageBox.Show(m);
                else
                    MessageBox.Show(n);

            }
        }
    }
}
