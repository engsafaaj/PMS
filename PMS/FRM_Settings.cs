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
    public partial class FRM_ProjectAdd : Form
    {
        DBPMSEntities db = new DBPMSEntities();
        TB_Prjects tb_users = new TB_Prjects();
       Methods methods = new Methods();
        public int id;
        public FRM_ProjectAdd()
        {
            InitializeComponent();
        }

     

        private void btn_add_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (edt_user.Text == "" ||edt_description.Text=="")
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
                            tb_users.Project_Name = edt_user.Text;
                            tb_users.Project_Description = edt_description.Text;
                            db.Entry(tb_users).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                            toastNotificationsManager1.ShowNotification("8ee7dba8-01e5-41ce-bd72-a454f174caaa");
                            this.Close();

                        }
                        else
                        {
                            tb_users = db.TB_Prjects.Where(x => x.ID == id).FirstOrDefault();
                        // edit
                        tb_users.ID = id;
                        tb_users.Project_Name = edt_user.Text;
                        tb_users.Project_Description = edt_description.Text;
                        db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("8ee7dba8-01e5-41ce-bd72-a454f174caaa");
                        this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "خطأ في الاتصال في السيرفر , الرجاء التحقق من الاتصال والمعادوة لاحقا");
                    }
                }
            main.Update_prjectdata();
            }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
