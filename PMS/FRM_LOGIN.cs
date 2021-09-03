using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class FRM_LOGIN : Form
    {
        DBPMSEntities db = new DBPMSEntities();
        TB_Users tb_users = new TB_Users();
       Methods methods = new Methods();
        public int id;
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

     

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_password.Text == "" || edt_user.Text == "")
            {
                MessageBox.Show("جميع الحقوق مطلوبة", "تحقق من المدخلات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                // save or edit
                Main main = new Main();
             
                    tb_users = db.TB_Users.Where(x => x.UserName == edt_user.Text && x.Password == edt_password.Text).FirstOrDefault();
                    if (tb_users != null)
                    {
                        // Login here
                        methods.ar = tb_users.Cover;
                        main.lb_user.Text = tb_users.UserName;
                        main.lb_role.Text = tb_users.Role;
                        tb_users.state = "On";
                        db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        Hide();
                        main.Show();

                    }
                    else
                    {
                        // Failed Login
                        MessageBox.Show("كلمة السر او اسم المستخدم غير صحيح", "تأكد من المدخلات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }


            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
            }
    

