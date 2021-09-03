using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class FRM_AddTask : Form
    {
        DBPMSEntities db = new DBPMSEntities();
        TB_Tasks task  = new TB_Tasks();
        Methods methods = new Methods();
        
        public int id;
        public FRM_AddTask()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_ProjectAdd rM_ProjectAdd = new FRM_ProjectAdd();
            rM_ProjectAdd.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_USERSADD fRM_USERSADD = new FRM_USERSADD();
            fRM_USERSADD.Show();
        }

        private void FRM_AddTask_Activated(object sender, EventArgs e)
        {
            var prjjects = db.TB_Prjects.Select(x => x.Project_Name).ToList();
            edt_pr.DataSource = prjjects;
            var users = db.TB_Users.Select(x => x.UserName).ToList();
            edt_user.DataSource = users;

           

        }

        void caldate()
        {
            var startdate = edt_datestart.Value;
            var enddate = edt_dateend.Value;
            var duration = enddate - startdate;
            edt_duration.Text = duration.Days.ToString();
            
        }

        private void edt_datestart_ValueChanged(object sender, EventArgs e)
        {
            caldate();
        }

        private void edt_dateend_ValueChanged(object sender, EventArgs e)
        {
            caldate();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (edt_taksname.Text==""|| edt_user.SelectedItem==null||edt_pr.SelectedItem==null)
            {
                MessageBox.Show("بعض الحقوق مطلوبة", "تحقق من المدخلات", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        task.TaskName = edt_taksname.Text;
                        task.PName = edt_pr.SelectedItem.ToString();
                        task.UserName = edt_user.SelectedItem.ToString();
                        task.TaskDescription = edt_description.Text;
                        task.TaskStart = edt_datestart.Value;
                        task.TaskEnd = edt_dateend.Value;
                        task.TaskDuration =Convert.ToDouble( edt_duration.Text);
                        var date = Convert.ToInt16(edt_duration.Text);
                        if (date == 0)
                        {
                            task.TaskState = "اليوم";
                        }else if (date == 1)
                        {
                            task.TaskState = "غدا ";

                        }
                        else if(date>1)
                        {
                            task.TaskState = "بعد "+edt_duration.Text+" يوم ";

                        }
                        else if (date < 0)
                        {
                            task.TaskState = "غير مكتمل";

                        }
                        if (checkBox1.Checked == true)
                        {
                            task.TaskState = "مكتمل";

                        }


                        db.Entry(task).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("5180543f-86a0-4d73-8914-2983e47e70ed");
                        this.Close();

                    }
                    else
                    {
                        task = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        // add
                        task.ID = id;
                        task.PName = edt_pr.SelectedItem.ToString();
                        task.UserName = edt_user.SelectedItem.ToString();
                        task.UserName = edt_user.Text;
                        task.TaskDescription = edt_description.Text;
                        task.TaskStart = edt_datestart.Value;
                        task.TaskEnd = edt_dateend.Value;
                        task.TaskDuration = Convert.ToDouble(edt_duration.Text);
                        var date = Convert.ToInt16(edt_duration.Text);
                        if (date == 0)
                        {
                            task.TaskState = "اليوم";
                        }
                        else if (date == 1)
                        {
                            task.TaskState = "غدا ";

                        }
                        else if (date > 1)
                        {
                            task.TaskState = "بعد " + edt_duration.Text + " يوم ";

                        }
                        else if (date < 0)
                        {
                            task.TaskState = "غير مكتمل";

                        }
                        if (checkBox1.Checked == true)
                        {
                            task.TaskState = "مكتمل";

                        }


                        db.Entry(task).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("7e62f981-b780-44fc-931b-0c23744ada48");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطأ في الاتصال في السيرفر , الرجاء التحقق من الاتصال والمعادة لاحقا");
                }
            }

            main.Update_taskstdata();
        }

        private void FRM_AddTask_Load(object sender, EventArgs e)
        {
            caldate();
        }
    }

}
