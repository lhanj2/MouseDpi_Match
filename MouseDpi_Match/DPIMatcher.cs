using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MouseDpi_Match
{
    public partial class DPIMatcher : Form
    {
        public DPIMatcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getMouseSpeed();
        }
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
            MessageBox.Show(propval.ToString());
        }
    }

}