﻿using Domain;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SelectiveScreenshot.Forms
{
    public partial class Start_Form : Form
    {

        // Selection_Screenshot Form
        SelectionScreenshot_Form4 Selection_Screenshot;


        //Form Round Corners------::START::--------------------------------------------------->
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // width of ellipse
         int nHeightEllipse // height of ellipse
        );

        //Form Round Corners------::END::----------------------------------------------------<








        // Register HotKey-----------------------::START::------------------------------------------------------------------>  
        // Dll import for registering HotKeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID = 1; // Hotkey ID


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                // Create only One Form
                if(Selection_Screenshot == null) 
                {
                    Selection_Screenshot = new SelectionScreenshot_Form4();
                }

                 // SHOW Screenshot Form
                if(Selection_Screenshot.Visible == false)  // If Form is not visible open it
                {
                    Selection_Screenshot = new SelectionScreenshot_Form4();
                    Selection_Screenshot.Show();         
                }
            }
            base.WndProc(ref m);
        }
        // Register HotKey-----------------------::END::------------------------------------------------------------------<    


             
        // Register Shortcut - Method
        private void RegisterShortcut()
        {
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 10, (int)Keys.None);
        }





        // Notify Icon
        NotifyIcon notify1 = new NotifyIcon(); // Bottom right in Tray    
        string xml_file_options_path = "C:\\Selection_Screenshot_Options.xml";// XML File Path





        //Initialize
        public Start_Form()
        {
            InitializeComponent();    
            // Round Corners of Form ::START::
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            // Round Corners of Form ::END::                                 
            this.ShowInTaskbar = false;
        }



        // Load
        private void Start_Form_Load(object sender, EventArgs e)
        {   
            // The Form    
            //this.WindowState = FormWindowState.Minimized;  // Minimize it on startup      
            RegisterShortcut(); // Register the shortcut - Shortcut CTRL+Win Key To Open Selection Screenshot
            Check_For_StartUP(); // Check for startUp - Check for RegKey    
            Load_Path(); // Load Save path - XML Reader
            Notify_Icon(); // Load Notify ico Method
        }




        // Form Location
        private void Form_Position()  
        {       
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width -10, Screen.PrimaryScreen.Bounds.Height - this.Height - 45); // Form Bottom Right Position
        }
    






        // Notify Ico Method
        private void Notify_Icon()
        {

            if (WindowState == FormWindowState.Minimized)
            {
                // Context Menu Item
                MenuItem notiy_Exit = new MenuItem();
                notiy_Exit.Click += Close_Form;
                notiy_Exit.Text = "Exit";

                // The Context Menu
                ContextMenu context_menu_notify = new ContextMenu();
                context_menu_notify.MenuItems.AddRange(new MenuItem[] { notiy_Exit });

                // The Notify Icon
                notify1.Icon = Properties.Resources.CutImage;
                notify1.Click += ShowForm;
                notify1.ContextMenu = context_menu_notify;
                notify1.Visible = true;
            }
           
            
        }



           

        // Exit Form
        private void Close_Form(object sender, EventArgs e)
        {
            notify1.Visible = false;
            notify1.Dispose(); // Dispose Notify Ico on exit   
            this.Dispose();     
        }

        
         // Show Form
        private void ShowForm(object sender, EventArgs e)
        {      
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true; // Allways on top
            Form_Position(); // Form Start Position
            this.Visible = true;     
            Cursor.Position = new Point(this.DesktopLocation.X + this.Width/2, this.DesktopLocation.Y + this.Height/2); // Show Mouse in the middle of the form
            this.Activate(); // Used for hiding the form if user clicks outside of it
        }



           



         // Start Up Check box ::// Register it to StartUp
        private void startup_checkBox_CheckedChanged(object sender, EventArgs e)
        {    
            RegistryKey registry_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);   
            if (startup_checkBox.Checked == true)
            {
                if(registry_key.GetValueNames().Contains("Selection Screenshot") == false)   // If key dont Exists Create it
                {
                 registry_key.SetValue("Selection Screenshot", Application.ExecutablePath); //Create Key   
                    registry_key.Close();
                }
            }
            else   // on Uncheck Delete the key
            {
                registry_key.DeleteValue("Selection Screenshot", false);  // Delete Key
                registry_key.Close();
            }
                  
        }






        // Check for startup
        private void Check_For_StartUP()
        {
            // Check for the Registry key for StartUp - "StartUp is when the windows start the application starts too"
            RegistryKey registry_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true); // REG Key Folder
            if (registry_key.GetValueNames().Contains("Selection Screenshot") == true) // Check if Key for this APP "APP NAME" exists
            {
                startup_checkBox.Checked = true; // IF Yes than check the checkbox
            }
            else
            {
                startup_checkBox.Checked = false; 
            }

            registry_key.Dispose();
        }





        //Change Path
        private void change_path_button_Click(object sender, EventArgs e)
        {   
            FolderBrowserDialog get_new_path_dialog = new FolderBrowserDialog(); // File Dialog
            
            if(get_new_path_dialog.ShowDialog(this) == DialogResult.OK) 
            {   
                string newPath = get_new_path_dialog.SelectedPath + "\\";  // The Selected path in the Dialog
                Screenshot.Get_Screenshot_Class_Instance().ScreenshotSavePath = newPath;  // Add the path to the Screenshot Class with Singleton Instance
                Save_To_XML_File(newPath); // Save the Path to the xml File    
            }
               
        }


    




        // Save Path to XML File - Method
        private void Save_To_XML_File(string Path)
        {   
            using (XmlTextWriter savePath = new XmlTextWriter(xml_file_options_path, null))
            {
                // Create Document and in it Element with Atribute
                savePath.WriteStartDocument();
                savePath.WriteStartElement("path_to_save");
                savePath.WriteAttributeString("path", Path); // The Data // The saved  Path
                savePath.WriteEndElement();
                savePath.WriteEndDocument();
                savePath.Close();
            }
        }


        // Load XML File with path
        private void Load_Path()
        {
            if (File.Exists(xml_file_options_path)) // If File Exists
            {
                using (XmlReader xml_reader = XmlReader.Create(xml_file_options_path))
                {
                    while (xml_reader.Read())
                    {
                        if ((xml_reader.NodeType == XmlNodeType.Element) && (xml_reader.Name == "path_to_save"))
                        {
                            if (xml_reader.HasAttributes) 
                            {
                                Screenshot.Get_Screenshot_Class_Instance().ScreenshotSavePath = xml_reader.GetAttribute("path").ToString();
                            }
                        }
                    }
                }
            }
        }



        



        //Hide Form
        // Deactivate - If user clicks outside the form the form is hidden
        private void Start_Form_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }




         // Hide button top right
        // Custom close button Hide Form
        private void close_form_button_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }



        //Close Button:::Animations-----------::START::--------->     
        // Close Button Hovered
        private void close_form_button_MouseEnter(object sender, EventArgs e)
        {
            close_form_button.BackgroundImage = Properties.Resources.closeButtonHovered;
            close_form_button.BackgroundImageLayout = ImageLayout.Center;

        }


        // Reset background Image after removing the mouse "hover"
        private void close_form_button_MouseLeave(object sender, EventArgs e)
        {
            close_form_button.BackgroundImage = Properties.Resources.closeButton;
            close_form_button.BackgroundImageLayout = ImageLayout.Center;
        }
        //Close Button:::Animations----------------::END::-----<



        // Show Hide Shortcuts on Making Screenshot         
        private void show_shortcut_label_MouseDown(object sender, MouseEventArgs e)
        {
            
            // Show Shorctut Panel
            if (shortcut_panel.Visible == false)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + 100); // Form +100 to show the shortcuts
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); // Form Rounded Corners
                this.Location = new Point(this.Location.X, this.Location.Y - 100); // Move Form Up so you can see the shortcuts
                shortcut_panel.Visible = true;
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 100); // Move Mouse To shortcut label

            }
            else   // Hide Shorctut Panel
            {
                this.Size = new Size(this.Size.Width, this.Size.Height - 100);    
                this.Location = new Point(this.Location.X, this.Location.Y + 100);          
                shortcut_panel.Visible = false;
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 100); // Move Mouse To shortcut label
            }
        }
        

    }
}
