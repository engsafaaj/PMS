using PMS.Properties;

namespace PMS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_navtop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_done = new DevExpress.XtraEditors.SimpleButton();
            this.btn_task = new DevExpress.XtraEditors.SimpleButton();
            this.btn_projets = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.btn_settings = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_about = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_role = new System.Windows.Forms.ToolStripStatusLabel();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.TaskPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TasksPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskStart1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskEnd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskDuration1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsersPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProject_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pn_navtop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pn_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.TaskPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.TasksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.UsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.ProjectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_navtop
            // 
            this.pn_navtop.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.pn_navtop, "pn_navtop");
            this.pn_navtop.Name = "pn_navtop";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.btn_add);
            this.flowLayoutPanel1.Controls.Add(this.btn_edit);
            this.flowLayoutPanel1.Controls.Add(this.btn_delete);
            this.flowLayoutPanel1.Controls.Add(this.btn_update);
            this.flowLayoutPanel1.Controls.Add(this.btn_done);
            this.flowLayoutPanel1.Controls.Add(this.btn_task);
            this.flowLayoutPanel1.Controls.Add(this.btn_projets);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Controls.Add(this.btn_settings);
            this.flowLayoutPanel1.Controls.Add(this.btn_print);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton3);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton2);
            this.flowLayoutPanel1.Controls.Add(this.btn_about);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_add.Appearance.Font")));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.Name = "btn_add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_edit.Appearance.Font")));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_edit, "btn_edit");
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_delete.Appearance.Font")));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_update.Appearance.Font")));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.Name = "btn_update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_done
            // 
            this.btn_done.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_done.Appearance.Font")));
            this.btn_done.Appearance.Options.UseFont = true;
            this.btn_done.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_done.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_done, "btn_done");
            this.btn_done.Name = "btn_done";
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_task
            // 
            this.btn_task.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_task.Appearance.Font")));
            this.btn_task.Appearance.Options.UseFont = true;
            this.btn_task.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_task.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_task, "btn_task");
            this.btn_task.Name = "btn_task";
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // btn_projets
            // 
            this.btn_projets.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_projets.Appearance.Font")));
            this.btn_projets.Appearance.Options.UseFont = true;
            this.btn_projets.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_projets.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_projets, "btn_projets");
            this.btn_projets.Name = "btn_projets";
            this.btn_projets.Click += new System.EventHandler(this.btn_projets_Click);
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_users.Appearance.Font")));
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_users.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_users, "btn_users");
            this.btn_users.Name = "btn_users";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_settings.Appearance.Font")));
            this.btn_settings.Appearance.Options.UseFont = true;
            this.btn_settings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_settings.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_settings, "btn_settings");
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_print.Appearance.Font")));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_print.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_print, "btn_print");
            this.btn_print.Name = "btn_print";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_about
            // 
            this.btn_about.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_about.Appearance.Font")));
            this.btn_about.Appearance.Options.UseFont = true;
            this.btn_about.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_about.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_about, "btn_about");
            this.btn_about.Name = "btn_about";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_user,
            this.lb_role});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lb_user
            // 
            this.lb_user.Name = "lb_user";
            resources.ApplyResources(this.lb_user, "lb_user");
            // 
            // lb_role
            // 
            this.lb_role.Name = "lb_role";
            resources.ApplyResources(this.lb_role, "lb_role");
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Controls.Add(this.navigationFrame1);
            resources.ApplyResources(this.pn_cont, "pn_cont");
            this.pn_cont.Name = "pn_cont";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.TaskPage);
            this.navigationFrame1.Controls.Add(this.TasksPage);
            this.navigationFrame1.Controls.Add(this.UsersPage);
            this.navigationFrame1.Controls.Add(this.ProjectPage);
            resources.ApplyResources(this.navigationFrame1, "navigationFrame1");
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TasksPage,
            this.UsersPage,
            this.ProjectPage});
            this.navigationFrame1.SelectedPage = this.TasksPage;
            // 
            // TaskPage
            // 
            resources.ApplyResources(this.TaskPage, "TaskPage");
            this.TaskPage.Controls.Add(this.gridControl1);
            this.TaskPage.Name = "TaskPage";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(PMS.TB_Tasks);
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.HeaderPanel.Font")));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaskName,
            this.colProjectID,
            this.colUserName,
            this.colTaskDescription,
            this.colTaskStart,
            this.colTaskEnd,
            this.colTaskDuration,
            this.colTaskState});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTaskName
            // 
            resources.ApplyResources(this.colTaskName, "colTaskName");
            this.colTaskName.FieldName = "TaskName";
            this.colTaskName.MinWidth = 25;
            this.colTaskName.Name = "colTaskName";
            // 
            // colProjectID
            // 
            resources.ApplyResources(this.colProjectID, "colProjectID");
            this.colProjectID.FieldName = "ProjectID";
            this.colProjectID.MinWidth = 25;
            this.colProjectID.Name = "colProjectID";
            // 
            // colUserName
            // 
            resources.ApplyResources(this.colUserName, "colUserName");
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            // 
            // colTaskDescription
            // 
            resources.ApplyResources(this.colTaskDescription, "colTaskDescription");
            this.colTaskDescription.FieldName = "TaskDescription";
            this.colTaskDescription.MinWidth = 25;
            this.colTaskDescription.Name = "colTaskDescription";
            // 
            // colTaskStart
            // 
            resources.ApplyResources(this.colTaskStart, "colTaskStart");
            this.colTaskStart.FieldName = "TaskStart";
            this.colTaskStart.MinWidth = 25;
            this.colTaskStart.Name = "colTaskStart";
            // 
            // colTaskEnd
            // 
            resources.ApplyResources(this.colTaskEnd, "colTaskEnd");
            this.colTaskEnd.FieldName = "TaskEnd";
            this.colTaskEnd.MinWidth = 25;
            this.colTaskEnd.Name = "colTaskEnd";
            // 
            // colTaskDuration
            // 
            resources.ApplyResources(this.colTaskDuration, "colTaskDuration");
            this.colTaskDuration.FieldName = "TaskDuration";
            this.colTaskDuration.MinWidth = 25;
            this.colTaskDuration.Name = "colTaskDuration";
            // 
            // colTaskState
            // 
            resources.ApplyResources(this.colTaskState, "colTaskState");
            this.colTaskState.FieldName = "TaskState";
            this.colTaskState.MinWidth = 25;
            this.colTaskState.Name = "colTaskState";
            // 
            // TasksPage
            // 
            resources.ApplyResources(this.TasksPage, "TasksPage");
            this.TasksPage.Controls.Add(this.gridControl2);
            this.TasksPage.Name = "TasksPage";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = typeof(PMS.TB_Tasks);
            resources.ApplyResources(this.gridControl2, "gridControl2");
            this.gridControl2.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridControl2.EmbeddedNavigator.Margin")));
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView2.Appearance.HeaderPanel.Font")));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView2.Appearance.Row.Font")));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colPName,
            this.colTaskName1,
            this.colUserName1,
            this.colTaskDescription1,
            this.colTaskStart1,
            this.colTaskEnd1,
            this.colTaskDuration1,
            this.colTaskState1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.colID1.AppearanceCell.Options.UseBackColor = true;
            this.colID1.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.colID1.AppearanceHeader.Options.UseBackColor = true;
            resources.ApplyResources(this.colID1, "colID1");
            this.colID1.FieldName = "ID";
            this.colID1.MinWidth = 25;
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            // 
            // colPName
            // 
            resources.ApplyResources(this.colPName, "colPName");
            this.colPName.FieldName = "PName";
            this.colPName.MinWidth = 25;
            this.colPName.Name = "colPName";
            this.colPName.OptionsColumn.AllowEdit = false;
            // 
            // colTaskName1
            // 
            resources.ApplyResources(this.colTaskName1, "colTaskName1");
            this.colTaskName1.FieldName = "TaskName";
            this.colTaskName1.MinWidth = 25;
            this.colTaskName1.Name = "colTaskName1";
            this.colTaskName1.OptionsColumn.AllowEdit = false;
            // 
            // colUserName1
            // 
            resources.ApplyResources(this.colUserName1, "colUserName1");
            this.colUserName1.FieldName = "UserName";
            this.colUserName1.MinWidth = 25;
            this.colUserName1.Name = "colUserName1";
            this.colUserName1.OptionsColumn.AllowEdit = false;
            // 
            // colTaskDescription1
            // 
            resources.ApplyResources(this.colTaskDescription1, "colTaskDescription1");
            this.colTaskDescription1.FieldName = "TaskDescription";
            this.colTaskDescription1.MinWidth = 25;
            this.colTaskDescription1.Name = "colTaskDescription1";
            this.colTaskDescription1.OptionsColumn.AllowEdit = false;
            // 
            // colTaskStart1
            // 
            this.colTaskStart1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTaskStart1.AppearanceCell.Options.UseBackColor = true;
            this.colTaskStart1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTaskStart1.AppearanceHeader.Options.UseBackColor = true;
            resources.ApplyResources(this.colTaskStart1, "colTaskStart1");
            this.colTaskStart1.FieldName = "TaskStart";
            this.colTaskStart1.MinWidth = 25;
            this.colTaskStart1.Name = "colTaskStart1";
            this.colTaskStart1.OptionsColumn.AllowEdit = false;
            // 
            // colTaskEnd1
            // 
            this.colTaskEnd1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTaskEnd1.AppearanceCell.Options.UseBackColor = true;
            this.colTaskEnd1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTaskEnd1.AppearanceHeader.Options.UseBackColor = true;
            resources.ApplyResources(this.colTaskEnd1, "colTaskEnd1");
            this.colTaskEnd1.FieldName = "TaskEnd";
            this.colTaskEnd1.MinWidth = 25;
            this.colTaskEnd1.Name = "colTaskEnd1";
            this.colTaskEnd1.OptionsColumn.AllowEdit = false;
            // 
            // colTaskDuration1
            // 
            this.colTaskDuration1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTaskDuration1.AppearanceCell.Options.UseBackColor = true;
            this.colTaskDuration1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTaskDuration1.AppearanceHeader.Options.UseBackColor = true;
            resources.ApplyResources(this.colTaskDuration1, "colTaskDuration1");
            this.colTaskDuration1.FieldName = "TaskDuration";
            this.colTaskDuration1.MinWidth = 25;
            this.colTaskDuration1.Name = "colTaskDuration1";
            this.colTaskDuration1.OptionsColumn.AllowEdit = false;
            // 
            // colTaskState1
            // 
            this.colTaskState1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTaskState1.AppearanceCell.Options.UseBackColor = true;
            this.colTaskState1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTaskState1.AppearanceHeader.Options.UseBackColor = true;
            resources.ApplyResources(this.colTaskState1, "colTaskState1");
            this.colTaskState1.FieldName = "TaskState";
            this.colTaskState1.MinWidth = 25;
            this.colTaskState1.Name = "colTaskState1";
            this.colTaskState1.OptionsColumn.AllowEdit = false;
            // 
            // UsersPage
            // 
            resources.ApplyResources(this.UsersPage, "UsersPage");
            this.UsersPage.Controls.Add(this.gridControl3);
            this.UsersPage.Name = "UsersPage";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = typeof(PMS.TB_Users);
            resources.ApplyResources(this.gridControl3, "gridControl3");
            this.gridControl3.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridControl3.EmbeddedNavigator.Margin")));
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView3.Appearance.HeaderPanel.Font")));
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView3.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView3.Appearance.Row.Font")));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.Row.Options.UseTextOptions = true;
            this.gridView3.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName2,
            this.colPassword,
            this.colRole,
            this.colCover});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            // 
            // colUserName2
            // 
            resources.ApplyResources(this.colUserName2, "colUserName2");
            this.colUserName2.FieldName = "UserName";
            this.colUserName2.MinWidth = 25;
            this.colUserName2.Name = "colUserName2";
            this.colUserName2.OptionsColumn.AllowEdit = false;
            // 
            // colPassword
            // 
            resources.ApplyResources(this.colPassword, "colPassword");
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            // 
            // colRole
            // 
            resources.ApplyResources(this.colRole, "colRole");
            this.colRole.FieldName = "Role";
            this.colRole.MinWidth = 25;
            this.colRole.Name = "colRole";
            this.colRole.OptionsColumn.AllowEdit = false;
            // 
            // colCover
            // 
            resources.ApplyResources(this.colCover, "colCover");
            this.colCover.FieldName = "Cover";
            this.colCover.MinWidth = 25;
            this.colCover.Name = "colCover";
            this.colCover.OptionsColumn.AllowEdit = false;
            // 
            // ProjectPage
            // 
            resources.ApplyResources(this.ProjectPage, "ProjectPage");
            this.ProjectPage.Controls.Add(this.gridControl4);
            this.ProjectPage.Name = "ProjectPage";
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = typeof(PMS.TB_Prjects);
            resources.ApplyResources(this.gridControl4, "gridControl4");
            this.gridControl4.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridControl4.EmbeddedNavigator.Margin")));
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView4.Appearance.HeaderPanel.Font")));
            this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView4.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView4.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView4.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView4.Appearance.Row.Font")));
            this.gridView4.Appearance.Row.Options.UseFont = true;
            this.gridView4.Appearance.Row.Options.UseTextOptions = true;
            this.gridView4.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView4.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProject_Name,
            this.colProject_Description});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            // 
            // colProject_Name
            // 
            resources.ApplyResources(this.colProject_Name, "colProject_Name");
            this.colProject_Name.FieldName = "Project_Name";
            this.colProject_Name.MinWidth = 25;
            this.colProject_Name.Name = "colProject_Name";
            this.colProject_Name.OptionsColumn.AllowEdit = false;
            // 
            // colProject_Description
            // 
            resources.ApplyResources(this.colProject_Description, "colProject_Description");
            this.colProject_Description.FieldName = "Project_Description";
            this.colProject_Description.MinWidth = 25;
            this.colProject_Description.Name = "colProject_Description";
            this.colProject_Description.OptionsColumn.AllowEdit = false;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "8f6a16d7-e26b-471c-85b4-740770384d39";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification(resources.GetString("toastNotificationsManager1.Notifications"), ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), resources.GetString("toastNotificationsManager1.Notifications2"), resources.GetString("toastNotificationsManager1.Notifications3"), resources.GetString("toastNotificationsManager1.Notifications4"), ((DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate)(resources.GetObject("toastNotificationsManager1.Notifications5")))),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification(resources.GetString("toastNotificationsManager1.Notifications6"), ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications7"))), resources.GetString("toastNotificationsManager1.Notifications8"), resources.GetString("toastNotificationsManager1.Notifications9"), resources.GetString("toastNotificationsManager1.Notifications10"), ((DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate)(resources.GetObject("toastNotificationsManager1.Notifications11"))))});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = global::PMS.Properties.Settings.Default.Timer;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pn_navtop);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            this.pn_navtop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pn_cont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.TaskPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.TasksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.UsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ProjectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_navtop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pn_cont;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_done;
        private DevExpress.XtraEditors.SimpleButton btn_task;
        private DevExpress.XtraEditors.SimpleButton btn_users;
        private DevExpress.XtraEditors.SimpleButton btn_projets;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage TaskPage;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskStart;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskDuration;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskState;
        private DevExpress.XtraBars.Navigation.NavigationPage TasksPage;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Navigation.NavigationPage UsersPage;
        private DevExpress.XtraBars.Navigation.NavigationPage ProjectPage;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskName1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskStart1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskEnd1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskDuration1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskState1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName2;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colCover;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colProject_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProject_Description;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public System.Windows.Forms.ToolStripStatusLabel lb_role;
        public System.Windows.Forms.ToolStripStatusLabel lb_user;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btn_settings;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public System.Windows.Forms.Timer timer2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraEditors.SimpleButton btn_about;
    }
}

