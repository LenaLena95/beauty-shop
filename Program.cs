using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyShop
{
    static class Program
    {
<<<<<<< HEAD
=======
        
        /// </summary>
        [STAThread]
>>>>>>> 9774f7ada8bb307bb4cb23f853da7d65ae7d19aa
        static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            /*using(BeautyShopEntities db=new BeautyShopEntities())
            {
                User user = new User
                {
                    UserName = "user2",
                    Password = "user2"
                };
                db.User.Add(user);
                db.SaveChanges();
            }*/
            }
        
        
    }
}