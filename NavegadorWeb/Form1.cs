using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)13)
                webBrowser.Navigate(txtUrl.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
                webBrowser.Navigate(txtUrl.Text);
        }

        private void R(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F5)
            {
                webBrowser.Refresh();
                e.Handled = true;

            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                webBrowser.GoBack();
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            help objhelp = new help();
            objhelp.Show();
        }
    }
}
