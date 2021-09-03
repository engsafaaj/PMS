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
    public partial class FRM_USERSADD : Form
    {
        DBPMSEntities db = new DBPMSEntities();
        TB_Users tb_users = new TB_Users();
       Methods methods = new Methods();
        public int id;
        public FRM_USERSADD()
        {
            InitializeComponent();
        }

     

        private void btn_add_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (edt_password.Text == "" || edt_user.Text == "" ||  edt_role.SelectedItem == null)
            {
                MessageBox.Show("جميع الحقوق مطلوبة", "تحقق من المدخلات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
               
                    // save or edit
                    try
                    {

                        // check if add or edit
                        if (id == 0)
                        {
                            // add
                            pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                            tb_users.UserName = edt_user.Text;
                        tb_users.Password = edt_password.Text;
                        tb_users.state = "On";
                        tb_users.ComputerName = Environment.MachineName.ToString(); 
                        tb_users.Role = edt_role.SelectedItem.ToString();
                           
                            tb_users.Cover = methods.Convert_Byte();
                            db.Entry(tb_users).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                            toastNotificationsManager1.ShowNotification("8ee7dba8-01e5-41ce-bd72-a454f174caaa");
                            this.Close();

                        }
                        else
                        {
                            tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                            pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                        // edit
                        pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                        tb_users.UserName = edt_user.Text;
                        tb_users.Password = edt_password.Text;
                        tb_users.Role = edt_role.SelectedItem.ToString();
                        tb_users.state = "On";
                        tb_users.ComputerName = Environment.MachineName.ToString();
                        db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("8ee7dba8-01e5-41ce-bd72-a454f174caaa");
                        this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "خطأ في الاتصال في السيرفر , الرجاء التحقق من الاتصال والمعاودة لاحقا");
                    }
                }
            main.Update_userdata();
            }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
