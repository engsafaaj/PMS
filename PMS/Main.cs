using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.Data.Filtering;
using PMS.Properties;
using System.Threading;

namespace PMS
{
    public partial class Main : Form
    {
        FRM_AddTask addTask;
        // init form
        DBPMSEntities db = new DBPMSEntities();
        TB_Users tb_users = new TB_Users();
        TB_Prjects tb_prject = new TB_Prjects();
        TB_Tasks tb_tasks = new TB_Tasks();
        Methods methods = new Methods();
        FRM_USERSADD RM_USERSADD;
        int id;
        public Main()
        {
            InitializeComponent();

            // Instantiate a new DBContext
            PMS.DBPMSEntities dbContext = new PMS.DBPMSEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Tasks.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl2.DataSource = dbContext.TB_Tasks.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl3.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Prjects.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl4.DataSource = dbContext.TB_Prjects.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //check
            if (navigationFrame1.SelectedPage == UsersPage)
            {
                try
                {
                    FRM_USERSADD RM_USERSADD = new FRM_USERSADD();
                    RM_USERSADD.id = 0;
                    RM_USERSADD.btn_add.Text = "اضافة";
                    RM_USERSADD.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطأ , لا يمكن اتمام العملية");
                }

            }
            else if (navigationFrame1.SelectedPage == ProjectPage)
            {
                try
                {
                    FRM_ProjectAdd RM_USERSADD = new FRM_ProjectAdd();
                    RM_USERSADD.id = 0;
                    RM_USERSADD.btn_add.Text = "اضافة";
                    RM_USERSADD.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطأ , لا يمكن اتمام العملية");
                }
            }
            else if (navigationFrame1.SelectedPage == TasksPage)
            {
                FRM_AddTask fRM_AddTask = new FRM_AddTask();
                fRM_AddTask.Show();
            }
            else
            {

            }




        }


        // set page
        private void btn_task_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = TasksPage;
            Update_taskstdata();
        }

        private void btn_projets_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = ProjectPage;
            Update_prjectdata();

        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = UsersPage;
            Update_userdata();


        }

        // end set page




        public void Update_userdata()
        {
            try
            {
                db = new DBPMSEntities();
                gridControl3.DataSource = db.TB_Users.ToList();
            }
            catch
            {
                MessageBox.Show("تحقق من الاتصال بقاعدة البيانات ثم اعد المحاولة", "فقد الاتصال في السيرفر");
            }
        }
        public void Update_prjectdata()
        {
            try
            {
                db = new DBPMSEntities();
                gridControl4.DataSource = db.TB_Prjects.ToList();
            }
            catch
            {
                MessageBox.Show("تحقق من الاتصال بقاعدة البيانات ثم اعد المحاولة", "فقد الاتصال في السيرفر");
            }
        }
        public void Update_taskstdata()
        {
            try
            {
                db = new DBPMSEntities();
                gridControl2.DataSource = db.TB_Tasks.ToList();
            }
            catch
            {
                MessageBox.Show("تحقق من الاتصال بقاعدة البيانات ثم اعد المحاولة", "فقد الاتصال في السيرفر");
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            timer2.Interval = Settings.Default.Timer;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (navigationFrame1.SelectedPage == UsersPage)
            {
                FRM_USERSADD frm_add = new FRM_USERSADD();
                try
                {
                    id = Convert.ToInt32(gridView3.GetFocusedRowCellValue(gridView3.Columns[0]));
                    if (id > 0)
                    {
                        tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                        methods.ar = tb_users.Cover;
                        frm_add.id = id;
                        frm_add.edt_user.Text = tb_users.UserName;
                        frm_add.edt_password.Text = tb_users.Password;
                        frm_add.edt_role.Text = tb_users.Role;
                        frm_add.pic_cover.Image = Image.FromStream(methods.Convert_Image());
                        frm_add.btn_add.Text = "تعديل";
                        frm_add.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("لايوجد بيانات لتعديلها", "خطأ في عملية التعديل");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");
                }

            }
            else if (navigationFrame1.SelectedPage == ProjectPage)
            {
                FRM_ProjectAdd frm_add = new FRM_ProjectAdd();
                try
                {
                    id = Convert.ToInt32(gridView4.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        tb_prject = db.TB_Prjects.Where(x => x.ID == id).FirstOrDefault();
                        frm_add.id = id;
                        frm_add.edt_user.Text = tb_prject.Project_Name;
                        frm_add.edt_description.Text = tb_prject.Project_Description;
                        frm_add.btn_add.Text = "تعديل";
                        frm_add.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("لايوجد بيانات لتعديلها", "خطأ في عملية التعديل");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");
                }
            }
            else if (navigationFrame1.SelectedPage == TasksPage)
            {
                FRM_AddTask frm_add = new FRM_AddTask();
                try
                {
                    id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        tb_tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        frm_add.id = id;
                        frm_add.edt_pr.SelectedItem = tb_tasks.PName;
                        frm_add.edt_user.SelectedItem = tb_tasks.UserName;
                        frm_add.edt_taksname.Text = tb_tasks.TaskName;
                        frm_add.edt_datestart.Value = (DateTime)tb_tasks.TaskStart;
                        frm_add.edt_dateend.Value = (DateTime)tb_tasks.TaskEnd;
                        frm_add.btn_add.Text = "تعديل";
                        frm_add.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("لايوجد بيانات لتعديلها", "خطأ في عملية التعديل");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");
                }
            }
            else
            {

            }

        }


        private void Main_Load(object sender, EventArgs e)
        {
            Update_userdata();
            TasksNote();
            if (lb_role.Text == "موظف")
            {
                btn_edit.Enabled = false;
                btn_users.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // First check and delete

            if (rs == DialogResult.Yes)
            {

                try
                {


                    if (navigationFrame1.SelectedPage == UsersPage)
                    {
                        id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("ID"));
                        if (id > 0)
                        {
                            tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                            tb_users.ID = id;
                            db.Entry(tb_users).State = EntityState.Deleted;
                            db.SaveChanges();
                            Update_userdata();
                            toastNotificationsManager1.ShowNotification("bc66640d-5d3f-411a-a7d5-63d971174987");
                        }
                        else
                        {
                            MessageBox.Show("لايوجد بيانات لحذفها", "خطأ في عملية الحذف");
                        }
                    }

                    if (navigationFrame1.SelectedPage == ProjectPage)
                    {
                        id = Convert.ToInt32(gridView4.GetFocusedRowCellValue("ID"));
                        if (id > 0)
                        {
                            tb_prject = db.TB_Prjects.Where(x => x.ID == id).FirstOrDefault();
                            tb_users.ID = id;
                            db.Entry(tb_prject).State = EntityState.Deleted;
                            db.SaveChanges();
                            Update_prjectdata();
                            toastNotificationsManager1.ShowNotification("bc66640d-5d3f-411a-a7d5-63d971174987");
                        }
                        else
                        {
                            MessageBox.Show("لايوجد بيانات لحذفها", "خطأ في عملية الحذف");

                        }
                    }

                    if (navigationFrame1.SelectedPage == TasksPage)
                    {
                        id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));

                        if (id > 0)
                        {
                            tb_tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                            tb_users.ID = id;
                            db.Entry(tb_tasks).State = EntityState.Deleted;
                            db.SaveChanges();
                            Update_taskstdata();
                            toastNotificationsManager1.ShowNotification("bc66640d-5d3f-411a-a7d5-63d971174987");
                        }
                        else
                        {
                            MessageBox.Show("لايوجد بيانات لحذفها", "خطأ في عملية الحذف");

                        }
                    }






                }
                catch (Exception ex)
                {
                    MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");
                }

            }







        }


        private void btn_update_Click_1(object sender, EventArgs e)
        {

            if (navigationFrame1.SelectedPage == UsersPage)
            {

                Update_userdata();

            }
            else if (navigationFrame1.SelectedPage == ProjectPage)
            {
                Update_prjectdata();
            }
            else if (navigationFrame1.SelectedPage == TasksPage)
            {
                Update_taskstdata();
            }
            else
            {

            }
        }

        private void Main_Leave(object sender, EventArgs e)
        {

        }

        private void Main_Deactivate(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("هل انت متأكد من اغلاق البرنامج , تذكر لا يمكن للبرنامج اعطائك التنبيهات , الافضل تركة يعمل في الخلفية", "اغلاق البرنامج");
            Application.Exit();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            try
            {
                if (navigationFrame1.SelectedPage == TasksPage)
                {
                    var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء , سوف يتم اكمال الفعالية ", "اجراء اكتمال مهمة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));

                        tb_tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        if (tb_tasks != null) {
                            tb_tasks.ID = id;
                            tb_tasks.TaskName = tb_tasks.TaskName;
                            tb_tasks.PName = tb_tasks.PName;
                            tb_tasks.UserName = tb_tasks.UserName;
                            tb_tasks.TaskDescription = tb_tasks.TaskDescription;
                            tb_tasks.TaskStart = tb_tasks.TaskStart;
                            tb_tasks.TaskEnd = tb_tasks.TaskEnd;
                            tb_tasks.TaskDuration = tb_tasks.TaskDuration;
                            tb_tasks.TaskState = "مكتمل";
                            db.Entry(tb_tasks).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن اجراء العملية , تحقق من الاتصال بقاعدة البيانات");

                        }

                    }

                }
                Update_taskstdata();
            }
            catch
            {
                MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");

            }


        }

        void TasksNote()
        {
            try
            {
                var idlist = db.TB_Tasks.Select(x => x.ID).ToArray();
                if (idlist != null)
                {
                    for (int i = 0; i < idlist.Length; i++)
                    {
                        var j = idlist[i];
                        tb_tasks = db.TB_Tasks.Where(x => x.ID == j).FirstOrDefault();
                        var end = tb_tasks.TaskEnd;
                        var start = DateTime.Now.Date;
                        var date1 = end - start;
                        var date = date1.Value.Days;
                        tb_tasks.TaskName = tb_tasks.TaskName;
                        tb_tasks.ID = j;
                        tb_tasks.PName = tb_tasks.PName;
                        tb_tasks.UserName = tb_tasks.UserName;
                        tb_tasks.TaskDescription = tb_tasks.TaskDescription;
                        tb_tasks.TaskStart = tb_tasks.TaskStart;
                        tb_tasks.TaskEnd = tb_tasks.TaskEnd;
                        tb_tasks.TaskDuration = tb_tasks.TaskDuration;
                        if (date == 0 && tb_tasks.TaskState != "مكتمل")
                        {
                            tb_tasks.TaskState = "اليوم";
                        }
                        else if (date == 1 && tb_tasks.TaskState != "مكتمل")
                        {
                            tb_tasks.TaskState = "غدا ";

                        }
                        else if (date > 1 && tb_tasks.TaskState != "مكتمل")
                        {
                            tb_tasks.TaskState = "بعد " + date.ToString() + " يوم ";

                        }
                        else if (date < 0 && tb_tasks.TaskState != "مكتمل")
                        {
                            tb_tasks.TaskState = "غير مكتمل";

                        }

                        db.Entry(tb_tasks).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    Update_taskstdata();
                }
                else
                {
                    MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");

                }
            }
            catch
            {

            }
        }

      
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            TasksNote();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridView2.PrintDialog(); 
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog folder = new FolderBrowserDialog();
            var rs = folder.ShowDialog();
            if (rs == DialogResult.OK)
            {
                gridView2.ExportToDocx(folder.SelectedPath + "/task.doc");

            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            var rs = folder.ShowDialog();
            if (rs == DialogResult.OK)
            {
                gridView2.ExportToXlsx(folder.SelectedPath + "/task.xls");

            }
        }


        // Set Notifictions
        private void note()
        {
            //Thread.Sleep(Settings.Default.Timer);
            timer2.Interval = Settings.Default.Timer;
            try
            {
                var idlist = db.TB_Tasks.Select(x => x.ID).ToArray();
                if (idlist != null)
                {
                    for (int i = 0; i < idlist.Length; i++)
                    {
                        var j = idlist[i];
                        tb_tasks = db.TB_Tasks.Where(x => x.ID == j && x.TaskState == "اليوم").FirstOrDefault();


                        if (tb_tasks != null)
                        {
                            var note1 = toastNotificationsManager1.GetNotificationByID("10693696-b1dd-4ed4-a10c-e0e691dd238e");
                            note1.Body = " تنتهي اليوم " + tb_tasks.TaskName;
                            note1.Header = " تنتهي اليوم " + tb_tasks.TaskName;
                            toastNotificationsManager1.ShowNotification("10693696-b1dd-4ed4-a10c-e0e691dd238e");
                        }
                        tb_tasks = db.TB_Tasks.Where(x => x.ID == j && x.TaskState == "غدا").FirstOrDefault();


                        if (tb_tasks != null)
                        {
                            var note1 = toastNotificationsManager1.GetNotificationByID("10693696-b1dd-4ed4-a10c-e0e691dd238e");
                            note1.Body = " تنتهي غدا " + tb_tasks.TaskName;
                            note1.Header = " تنتهي غدا " + tb_tasks.TaskName;
                            toastNotificationsManager1.ShowNotification("10693696-b1dd-4ed4-a10c-e0e691dd238e");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");

                }


            }
            catch
            {
                MessageBox.Show("لقد فقد الاتصال في السيرفر, يبدو ان لا يوجد لديك اتصال");
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FRM_Settings settings = new FRM_Settings();
            settings.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            note();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
