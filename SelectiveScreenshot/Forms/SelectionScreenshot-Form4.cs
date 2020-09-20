using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Domain;
using System.Diagnostics;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace SelectiveScreenshot
{
    public partial class SelectionScreenshot_Form4 : Form
    {

        MenuFormSelectionScreenshot___Form5 menuForm; // The Bottom tool bar background
        private bool canDraw;
        private int startX, startY;
        //private Rectangle rect = Screen.GetBounds(Point.Empty);
        private Rectangle rect = new Rectangle(new Point(10,10), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
        Screenshot screenshot = Screenshot.Get_Screenshot_Class_Instance();
        string LocalFolderPath = Screenshot.Get_Screenshot_Class_Instance().ScreenshotSavePath;

        Form thisForm;

        // Initialize
        public SelectionScreenshot_Form4()
        {       
            this.TransparencyKey = Color.Turquoise;   // Transparent BackColor
            this.BackColor = Color.Turquoise;   // Transparent BackColor
            this.DoubleBuffered = true; // Removes Flickering on drawing
 
            InitializeComponent();
        }





        // LOAD
        private void SelectionScreenshot_Form4_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false; // Dont show in taskbar
            Show_Bottom_Menu_Form();   // Show bottom menu Form , braun transparent form
        }







        private void Show_Bottom_Menu_Form() // Method - Show bottom menu Form , braun transparent form 
        {
            if (menuForm == null)
            {
                menuForm = new MenuFormSelectionScreenshot___Form5(); // The Bottom tool bar background
            }

            if (menuForm.Visible == false)
            {
                menuForm.Show();
            }
        }


       // Start Point of Draw "Rectangle"
        private void SelectionScreenshot_Form4_MouseDown(object sender, MouseEventArgs e)
        {
      

            if (e.Button == MouseButtons.Left)// If mouse button Left Down than Draw
            {
                canDraw = true; // On mouse Down - Now we can draw

                // Start Position of Drawing
                // e is the mouse 
                startX = e.X;
                startY = e.Y;
            }

            if (e.Button == MouseButtons.Right)// If Mouse Right Button pressed Hide Menu
            {

                bottom_menu_Screenshot_panel.Visible = false; // Hide
                menuForm.Hide();
            }
           
        }


      



        // Stop Drawing Rectangle on Mouse Up
        private void SelectionScreenshot_Form4_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;  // When you leave the mouse button you stop drawing the rectangle 

            if (e.Button == MouseButtons.Right)// If Mouse Right Button pressed Make Screenshot
            {

                MakeScreenshotNow();
                bottom_menu_Screenshot_panel.Visible = true; // Show Menu 
                menuForm.Show();
                this.Activate(); // Focus the Screenshot form because the menuForm got showed up
            }
              
        }





          // Draw the Rectangle SIZE   ------ DRAWS the SIZE OF THE RECTANGLE NOT THE VISIBLE RED LINES
        private void SelectionScreenshot_Form4_MouseMove(object sender, MouseEventArgs e)
        {
             
                if (!canDraw) return; // Return if you are not allowed to Draw
                {

                    int x = Math.Min(startX, e.X); // The starting location and the Location of the mouse now
                    int y = Math.Min(startY, e.Y);
                    int width = Math.Max(startX, e.X) - Math.Min(startX, e.X);
                    int height = Math.Max(startY, e.Y) - Math.Min(startY, e.Y);
                    rect = new Rectangle(x, y, width, height);

                    Refresh();

                }
            
        }






        //--Paint---Rectangle-------THIS TAKES the size of the rectangle and paints it red
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, rect);
                //e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
           
            }
          
        }


        







        // Make Screenshot button " Discet"
        private void selectionScreenshot_button_Click(object sender, EventArgs e)  // Make Screenshot form the Selection
        {      
            MakeScreenshotNow();   
        }






         // The Main Method - Make Screenshot
        private void MakeScreenshotNow()
        {
            //Hide All Buttons     
            Cursor.Current = Cursors.WaitCursor;
            screenshot.ScreenshotNameDateTime = "ScreenShot -" + DateTime.Now.ToString("dd -MM-yyyy  HH-mm-ss"); // Screenshot New Name

            //Sound-------------
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();

            //Scrennshot    
             screenshot.MakeSelectionScreenshot(rect);   // Screenshot Class Method

       

            Cursor.Current = Cursors.Default;

            //SHOW ALL Buttons Again --------
 


        }





        //---------ScreenshotForm--Close with Esc - Key-----::START::---------------------------------------------------------------------------------------------------------------------------------------------------
        private void SelectionScreenshot_Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) //Close Form
            {
                 Close();
            }

            
        }





         // On Selection Screen "FORM Closing" close the menu with the "Save, Edit in Paint, Open folder, etc.  "The menu is made of another Form because of the transparency" On Selection Screenshot Form CLose the menu is also closed
        private void SelectionScreenshot_Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (menuForm == null)
            //{
            //   menuForm = new MenuFormSelectionScreenshot___Form5();
            //   menuForm.Show();
            //}

     
           if (menuForm != null)
           {
             menuForm.Dispose();
           }

        }



          


        // Close Selection Cut button  "THIS FORM"
        private void closeForm_button_Click(object sender, EventArgs e)
        {
            CloseForm();// Method
        }






        // Close SelectionScreenshot Form - Main Method
         private void CloseForm()
         {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Default.wav");
            simpleSound.Play();
            this.Close(); // Close this Form
         }





        // ESC Buttoen Down - Close Selection Cut
        protected override bool ProcessDialogKey(Keys keydata) // ESC Key only on this form "Dont send key event to other "Parrent" forms
          {
            if(Form.ModifierKeys == Keys.None && keydata == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessDialogKey(keydata);
          }

        //---------ScreenshotForm--Close with Esc - Key-----::END::------------------------------------------------------------------------------------------------------------------------------------------------------







        // Help button
        private void help_button_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Balloon.wav");
            simpleSound.Play();

            help_label.Visible = true;
        }






           // Opens Last Image in Paint -Main - Method
        private void OpenLastImageInPaint()
        {

            //----------------GET--LAST--Updated--File
            
            // Open Last File
            DirectoryInfo directory = new DirectoryInfo(LocalFolderPath); // Create Directory with path "Not phisical Directory!"
            FileInfo lastfile = (from f in directory.GetFiles() // Get all files in the directory
                               orderby f.LastWriteTime descending // Ascending // Decending
                               select f).First();


            //Opens Last image in paint
            Process.Start("mspaint", $@"""{lastfile.FullName}""");
            CloseForm();
        }






         // Opens the last Image in Paint
        private void open_iimage_in_paint_button_Click(object sender, EventArgs e)
        {
            OpenLastImageInPaint();
        }






        //Shortcut keys  -- Paint, Foldet, ETC--- Place here all shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.E))
            {
                OpenLastImageInPaint();// Paint
            }


            if (keyData == (Keys.Control | Keys.F))
            {
                OpenFolder();// FOLDER
            }


            if (keyData == (Keys.Control | Keys.S))
            {
                MakeScreenshotNow();
            }

            if (keyData == (Keys.Control | Keys.B))
            {
                thisForm.Visible = true;
            }

            if (keyData == (Keys.Control | Keys.H))
            {
                thisForm = this;
                this.Hide();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    
 



            // Open Folder - Main Method
           private void OpenFolder()
           {

            //Sound
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\recycle.wav");
            simpleSound.Play();

            // Opens Folder  
            Process.Start($@"{screenshot.ScreenshotSavePath}"); // Opens Default App - Directory with Screenshots, Pdf etc.
            this.Close();

           }


  







         //---------ToolTips---::START::------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Save Screenshot "Make Screenshot" - ToolTip
        private void selectionScreenshot_button_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
        
            tip.AutoPopDelay = 3000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 1000;
            tip.ShowAlways = true;

            tip.SetToolTip(selectionScreenshot_button, "Save: Press: \"CTRL + S\"");
        }





        // Tool Tip Folder
        private void openFolder_button_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
             
            tip.AutoPopDelay = 3000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 1000;
            tip.ShowAlways = true;

            tip.SetToolTip(openFolder_button, "Open Local Folder: Press: \"CTRL + F\"");
        }





        // Tool Tip Paint
        private void open_iimage_in_paint_button_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
        
            tip.AutoPopDelay = 3000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 1000;
            tip.ShowAlways = true;

            tip.SetToolTip(open_iimage_in_paint_button, "Open Last Image in Paint: Press:  \"CTRL + E\"");
        }




        // Close Selection Screenshot- Tooltip
        private void closeForm_button_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();

            tip.AutoPopDelay = 3000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 1000;
            tip.ShowAlways = true;

            tip.SetToolTip(closeForm_button, "EXIT Press: \"ESC\"");
        }


        // Activate on DEactive - Focus if it losses focus            
        private void SelectionScreenshot_Form4_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }




        //---------ToolTips---::END::------------------------------------------------------------------------------------------------------------------------------------------------------------






        // Open Folder with the screenshots
        private void openFolder_button_Click(object sender, EventArgs e)
        {
            OpenFolder();// Main - Method - "Open Folder"
        }

         
       


    }
}
