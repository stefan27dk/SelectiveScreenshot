namespace SelectiveScreenshot.Forms
{
    partial class Start_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.startup_checkBox = new System.Windows.Forms.CheckBox();
            this.change_path_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startup_checkBox
            // 
            this.startup_checkBox.AutoSize = true;
            this.startup_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(61)))));
            this.startup_checkBox.Location = new System.Drawing.Point(37, 40);
            this.startup_checkBox.Name = "startup_checkBox";
            this.startup_checkBox.Size = new System.Drawing.Size(100, 17);
            this.startup_checkBox.TabIndex = 0;
            this.startup_checkBox.Text = "Start on Startup";
            this.startup_checkBox.UseVisualStyleBackColor = true;
            this.startup_checkBox.CheckedChanged += new System.EventHandler(this.startup_checkBox_CheckedChanged);
            // 
            // change_path_button
            // 
            this.change_path_button.Location = new System.Drawing.Point(37, 81);
            this.change_path_button.Name = "change_path_button";
            this.change_path_button.Size = new System.Drawing.Size(80, 23);
            this.change_path_button.TabIndex = 1;
            this.change_path_button.Text = "Change Path";
            this.change_path_button.UseVisualStyleBackColor = true;
            this.change_path_button.Click += new System.EventHandler(this.change_path_button_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(320, 155);
            this.Controls.Add(this.change_path_button);
            this.Controls.Add(this.startup_checkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Form";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Selection Screenshot";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_Form_FormClosing);
            this.Load += new System.EventHandler(this.Start_Form_Load);
            this.Resize += new System.EventHandler(this.Start_Form_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startup_checkBox;
        private System.Windows.Forms.Button change_path_button;
    }
}