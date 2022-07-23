using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MouseDpi_Match
{
    public partial class DPIMatcher : Form
    {
        public DPIMatcher()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        #region Variables
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);


        public const UInt32 SPI_SETMOUSESPEED = 0x0071;
        #endregion

        private void getMouseSpeed()
        {
            Type t = typeof(System.Windows.Forms.SystemInformation);
            PropertyInfo[] pi = t.GetProperties();
            PropertyInfo prop = null;
            for (int i = 0; i < pi.Length; i++)
                if (pi[i].Name == "MouseSpeed")
                {
                    prop = pi[i];
                    break;
                }
            object propval = prop.GetValue(null, null);
            //prop.SetValue(null,20);
            //MessageBox.Show(propval.ToString()); for showing my windows mouse speed
        }

       

        #region Frm Event
        private void btnShowMouseSpeed_Click(object sender, EventArgs e)
        {
            getMouseSpeed();
        }

        private void btnChangeMouseSpeed_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, uint.Parse("6"), 0);
        }

        private void Á¾·áToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DPIMatcher_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }


        private void DPIMatcher_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) != 0)
                MessageBox.Show("KeyPress " + Keys.Shift);
        }

        private void DPIMatcher_Load(object sender, EventArgs e)
        {
           
        }
        private void DPIMatcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        #endregion

    }

}