using PMS.Properties;
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
    public partial class FRM_Settings : Form
    {

        public FRM_Settings()
        {
            InitializeComponent();
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            var time = Convert.ToInt32(edt_user.Text);
            Settings.Default.Timer = time * 60000;
            Settings.Default.Save();

            this.Close();


        }

        private void edt_user_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FRM_Settings_Load(object sender, EventArgs e)
        {
            edt_user.Text = (Settings.Default.Timer/60000).ToString();
        }
    }
}