using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_txt
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate(Application.StartupPath + @"about\index.html");
            this.Controls.Add(webBrowser);
        }
    }
}
