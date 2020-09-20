﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectiveScreenshot
{
    public partial class MenuFormSelectionScreenshot___Form5 : Form
    {
        public MenuFormSelectionScreenshot___Form5()
        {
            InitializeComponent();


            this.StartPosition = FormStartPosition.Manual;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = 40;
            int formLocationY = Screen.PrimaryScreen.Bounds.Height - this.Height - 40; // Minus 40 because of the Windows Taskbar
            this.Location = new Point(0, formLocationY);
            this.BackColor = Color.FromArgb(36, 36, 35);

        }

         
         // Load
        private void MenuFormSelectionScreenshot___Form5_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false; // Dont show in taskbar  
        }


   
    }
}
