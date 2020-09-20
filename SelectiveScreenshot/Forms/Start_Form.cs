using Domain;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectiveScreenshot.Forms
{
    public partial class Start_Form : Form
    {

        // Selection_Screenshot Form
        SelectionScreenshot_Form4 Selection_Screenshot;


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
        NotifyIcon notify1 = new NotifyIcon();



        //Initialize
        public Start_Form()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }



        // Load
        private void Start_Form_Load(object sender, EventArgs e)
        {    
            
            //var Startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            // The Form
         
            //this.WindowState = FormWindowState.Minimized;  // Minimize it on startup      
            RegisterShortcut(); // Register the shortcut
            Check_For_StartUP(); // Check for startUp     
        }




        // Form Location
        private void Form_Position()  
        {       
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 45); // Form Bottom Right Position
        }
    






        // Notify Ico
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
            else
            {    
                notify1 = null;  
            }
            
        }



           

        // Exit Form
        private void Close_Form(object sender, EventArgs e)
        {    
            Application.Exit();
        }

        
         // Show Form
        private void ShowForm(object sender, EventArgs e)
        {      
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            Form_Position(); // Form Start Position
            this.Visible = true;     
            Cursor.Position = new Point(this.DesktopLocation.X + this.Width/2, this.DesktopLocation.Y + this.Height/2); // Show Mouse in the middle of the form
        }



         

        // Before form closes
        private void Start_Form_FormClosing(object sender, FormClosingEventArgs e)
        {   
            e.Cancel = true;   
            this.Hide();
            this.WindowState = FormWindowState.Minimized;          
        }





        private void Start_Form_Resize(object sender, EventArgs e)
        {
            Notify_Icon();
        }






         // Start Up Check box ::// Register it to StartUp
        private void startup_checkBox_CheckedChanged(object sender, EventArgs e)
        {    
            RegistryKey registry_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);   
            if (startup_checkBox.Checked == true)
            {
                registry_key.SetValue("Selection Screenshot", Application.ExecutablePath);   
            }
            else
            {
                registry_key.DeleteValue("Selection Screenshot", false);
            }
                  
        }






        // Check for startup
        private void Check_For_StartUP()
        {
            // Check for the Registry key for StartUp - "StartUp is when the windows start the application starts too"
            RegistryKey registry_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (registry_key.GetValueNames().Contains("Selection Screenshot") == true)
            {
                startup_checkBox.Checked = true;
            }
            else
            {
                startup_checkBox.Checked = false;
            }
        }





        //!!!!!!!!FILE DIALOG GET PATH FOR IMAGES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! DO THIS
        private void change_path_button_Click(object sender, EventArgs e)
        {
            Screenshot screenshot = new Screenshot();
            FolderBrowserDialog get_new_path_dialog = new FolderBrowserDialog(); 
            
            if(get_new_path_dialog.ShowDialog(this) == DialogResult.OK)
            {
                
                screenshot.ScreenshotSavePath = get_new_path_dialog.SelectedPath;
                MessageBox.Show(get_new_path_dialog.SelectedPath, "", MessageBoxButtons.OK);
            }
               
        }
    }
}
