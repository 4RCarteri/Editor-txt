﻿using System;
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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            webBrowser.Navigate("http://google.com");
        }
    }
}
