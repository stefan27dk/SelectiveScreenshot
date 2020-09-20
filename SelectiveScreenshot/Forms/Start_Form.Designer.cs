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
            this.close_form_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.show_shortcut_label = new System.Windows.Forms.Label();
            this.Cut_shortcut_label = new System.Windows.Forms.Label();
            this.cut_label = new System.Windows.Forms.Label();
            this.folder_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.capture_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.open_in_paint_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shortcut_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.shortcut_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startup_checkBox
            // 
            this.startup_checkBox.AutoSize = true;
            this.startup_checkBox.Font = new System.Drawing.Font("Linux Libertine G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startup_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(61)))));
            this.startup_checkBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startup_checkBox.Location = new System.Drawing.Point(59, 11);
            this.startup_checkBox.Name = "startup_checkBox";
            this.startup_checkBox.Size = new System.Drawing.Size(143, 22);
            this.startup_checkBox.TabIndex = 0;
            this.startup_checkBox.Text = "Start on Startup";
            this.startup_checkBox.UseVisualStyleBackColor = true;
            this.startup_checkBox.CheckedChanged += new System.EventHandler(this.startup_checkBox_CheckedChanged);
            // 
            // change_path_button
            // 
            this.change_path_button.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_path_button.Location = new System.Drawing.Point(59, 50);
            this.change_path_button.Name = "change_path_button";
            this.change_path_button.Size = new System.Drawing.Size(80, 23);
            this.change_path_button.TabIndex = 1;
            this.change_path_button.Text = "Change Path";
            this.change_path_button.UseVisualStyleBackColor = true;
            this.change_path_button.Click += new System.EventHandler(this.change_path_button_Click);
            // 
            // close_form_button
            // 
            this.close_form_button.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.closeButton;
            this.close_form_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_form_button.FlatAppearance.BorderSize = 0;
            this.close_form_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_form_button.Location = new System.Drawing.Point(288, 1);
            this.close_form_button.Name = "close_form_button";
            this.close_form_button.Size = new System.Drawing.Size(24, 24);
            this.close_form_button.TabIndex = 2;
            this.close_form_button.UseVisualStyleBackColor = true;
            this.close_form_button.Click += new System.EventHandler(this.close_form_button_Click);
            this.close_form_button.MouseEnter += new System.EventHandler(this.close_form_button_MouseEnter);
            this.close_form_button.MouseLeave += new System.EventHandler(this.close_form_button_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SelectiveScreenshot.Properties.Resources.folderDes;
            this.pictureBox1.Location = new System.Drawing.Point(22, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.Start_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(27, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // show_shortcut_label
            // 
            this.show_shortcut_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_shortcut_label.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_shortcut_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.show_shortcut_label.Image = global::SelectiveScreenshot.Properties.Resources.App_keyboard_icon;
            this.show_shortcut_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_shortcut_label.Location = new System.Drawing.Point(19, 91);
            this.show_shortcut_label.Name = "show_shortcut_label";
            this.show_shortcut_label.Size = new System.Drawing.Size(142, 21);
            this.show_shortcut_label.TabIndex = 4;
            this.show_shortcut_label.Text = "Shortcut Keys";
            this.show_shortcut_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.show_shortcut_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.show_shortcut_label_MouseDown);
            // 
            // Cut_shortcut_label
            // 
            this.Cut_shortcut_label.AutoSize = true;
            this.Cut_shortcut_label.Font = new System.Drawing.Font("Linux Libertine Display G", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cut_shortcut_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Cut_shortcut_label.Location = new System.Drawing.Point(54, 6);
            this.Cut_shortcut_label.Name = "Cut_shortcut_label";
            this.Cut_shortcut_label.Size = new System.Drawing.Size(129, 17);
            this.Cut_shortcut_label.TabIndex = 6;
            this.Cut_shortcut_label.Text = "CTRL + Win Key";
            // 
            // cut_label
            // 
            this.cut_label.AutoSize = true;
            this.cut_label.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cut_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(61)))));
            this.cut_label.Location = new System.Drawing.Point(9, 6);
            this.cut_label.Name = "cut_label";
            this.cut_label.Size = new System.Drawing.Size(39, 18);
            this.cut_label.TabIndex = 7;
            this.cut_label.Text = "Cut:";
            // 
            // folder_label
            // 
            this.folder_label.AutoSize = true;
            this.folder_label.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(61)))));
            this.folder_label.Location = new System.Drawing.Point(9, 43);
            this.folder_label.Name = "folder_label";
            this.folder_label.Size = new System.Drawing.Size(60, 18);
            this.folder_label.TabIndex = 9;
            this.folder_label.Text = "Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Linux Libertine Display G", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(76, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "CTRL + F";
            // 
            // capture_label
            // 
            this.capture_label.AutoSize = true;
            this.capture_label.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(61)))));
            this.capture_label.Location = new System.Drawing.Point(9, 76);
            this.capture_label.Name = "capture_label";
            this.capture_label.Size = new System.Drawing.Size(71, 18);
            this.capture_label.TabIndex = 11;
            this.capture_label.Text = "Capture:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Linux Libertine Display G", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(86, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mouse Right Button";
            // 
            // open_in_paint_label
            // 
            this.open_in_paint_label.AutoSize = true;
            this.open_in_paint_label.Font = new System.Drawing.Font("Linux Libertine Display G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_in_paint_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(61)))));
            this.open_in_paint_label.Location = new System.Drawing.Point(14, 107);
            this.open_in_paint_label.Name = "open_in_paint_label";
            this.open_in_paint_label.Size = new System.Drawing.Size(43, 18);
            this.open_in_paint_label.TabIndex = 13;
            this.open_in_paint_label.Text = "Edit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Linux Libertine Display G", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(63, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "CTRL + E";
            // 
            // shortcut_panel
            // 
            this.shortcut_panel.Controls.Add(this.Cut_shortcut_label);
            this.shortcut_panel.Controls.Add(this.open_in_paint_label);
            this.shortcut_panel.Controls.Add(this.cut_label);
            this.shortcut_panel.Controls.Add(this.label5);
            this.shortcut_panel.Controls.Add(this.label3);
            this.shortcut_panel.Controls.Add(this.capture_label);
            this.shortcut_panel.Controls.Add(this.folder_label);
            this.shortcut_panel.Controls.Add(this.label4);
            this.shortcut_panel.Location = new System.Drawing.Point(22, 124);
            this.shortcut_panel.Name = "shortcut_panel";
            this.shortcut_panel.Size = new System.Drawing.Size(248, 131);
            this.shortcut_panel.TabIndex = 14;
            this.shortcut_panel.Visible = false;
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(320, 131);
            this.Controls.Add(this.shortcut_panel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.show_shortcut_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.change_path_button);
            this.Controls.Add(this.startup_checkBox);
            this.Controls.Add(this.close_form_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Form";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Selection Screenshot";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Deactivate += new System.EventHandler(this.Start_Form_Deactivate);
            this.Load += new System.EventHandler(this.Start_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.shortcut_panel.ResumeLayout(false);
            this.shortcut_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startup_checkBox;
        private System.Windows.Forms.Button change_path_button;
        private System.Windows.Forms.Button close_form_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label show_shortcut_label;
        private System.Windows.Forms.Label Cut_shortcut_label;
        private System.Windows.Forms.Label cut_label;
        private System.Windows.Forms.Label folder_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label capture_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label open_in_paint_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel shortcut_panel;
    }
}