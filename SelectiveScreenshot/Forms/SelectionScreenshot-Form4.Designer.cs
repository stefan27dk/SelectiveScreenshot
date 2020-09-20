namespace SelectiveScreenshot
{
    partial class SelectionScreenshot_Form4
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
            this.components = new System.ComponentModel.Container();
            this.help_label = new System.Windows.Forms.Label();
            this.help_button = new System.Windows.Forms.Button();
            this.openFolder_button = new System.Windows.Forms.Button();
            this.closeForm_button = new System.Windows.Forms.Button();
            this.selectionScreenshot_button = new System.Windows.Forms.Button();
            this.open_iimage_in_paint_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bottom_menu_Screenshot_panel = new System.Windows.Forms.Panel();
            this.bottom_menu_Screenshot_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // help_label
            // 
            this.help_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.help_label.AutoSize = true;
            this.help_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_label.ForeColor = System.Drawing.Color.Lavender;
            this.help_label.Location = new System.Drawing.Point(221, 415);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(663, 25);
            this.help_label.TabIndex = 4;
            this.help_label.Text = "Press Mouse Left button and drag, than press save button or Mouse Right Click";
            this.help_label.UseCompatibleTextRendering = true;
            this.help_label.Visible = false;
            // 
            // help_button
            // 
            this.help_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.help_button.BackColor = System.Drawing.Color.Transparent;
            this.help_button.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.Help_icon;
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(160, 2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(23, 23);
            this.help_button.TabIndex = 3;
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // openFolder_button
            // 
            this.openFolder_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFolder_button.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.folder_icon;
            this.openFolder_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFolder_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFolder_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openFolder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolder_button.Location = new System.Drawing.Point(40, 2);
            this.openFolder_button.Name = "openFolder_button";
            this.openFolder_button.Size = new System.Drawing.Size(23, 23);
            this.openFolder_button.TabIndex = 2;
            this.openFolder_button.UseVisualStyleBackColor = true;
            this.openFolder_button.Click += new System.EventHandler(this.openFolder_button_Click);
            this.openFolder_button.MouseHover += new System.EventHandler(this.openFolder_button_MouseHover);
            // 
            // closeForm_button
            // 
            this.closeForm_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeForm_button.BackColor = System.Drawing.Color.Transparent;
            this.closeForm_button.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.big_close_button;
            this.closeForm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeForm_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeForm_button.FlatAppearance.BorderSize = 0;
            this.closeForm_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.closeForm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeForm_button.Location = new System.Drawing.Point(119, 2);
            this.closeForm_button.Name = "closeForm_button";
            this.closeForm_button.Size = new System.Drawing.Size(23, 23);
            this.closeForm_button.TabIndex = 1;
            this.closeForm_button.UseVisualStyleBackColor = false;
            this.closeForm_button.Click += new System.EventHandler(this.closeForm_button_Click);
            this.closeForm_button.MouseHover += new System.EventHandler(this.closeForm_button_MouseHover);
            // 
            // selectionScreenshot_button
            // 
            this.selectionScreenshot_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectionScreenshot_button.BackColor = System.Drawing.Color.Transparent;
            this.selectionScreenshot_button.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.Actions_document_save_icon__1_;
            this.selectionScreenshot_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectionScreenshot_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectionScreenshot_button.FlatAppearance.BorderSize = 0;
            this.selectionScreenshot_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.selectionScreenshot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionScreenshot_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectionScreenshot_button.Location = new System.Drawing.Point(7, 2);
            this.selectionScreenshot_button.Name = "selectionScreenshot_button";
            this.selectionScreenshot_button.Size = new System.Drawing.Size(23, 23);
            this.selectionScreenshot_button.TabIndex = 0;
            this.selectionScreenshot_button.UseVisualStyleBackColor = false;
            this.selectionScreenshot_button.Click += new System.EventHandler(this.selectionScreenshot_button_Click);
            this.selectionScreenshot_button.MouseHover += new System.EventHandler(this.selectionScreenshot_button_MouseHover_1);
            // 
            // open_iimage_in_paint_button
            // 
            this.open_iimage_in_paint_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.open_iimage_in_paint_button.BackColor = System.Drawing.Color.Transparent;
            this.open_iimage_in_paint_button.BackgroundImage = global::SelectiveScreenshot.Properties.Resources.light_paint;
            this.open_iimage_in_paint_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_iimage_in_paint_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_iimage_in_paint_button.FlatAppearance.BorderSize = 0;
            this.open_iimage_in_paint_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.open_iimage_in_paint_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_iimage_in_paint_button.Location = new System.Drawing.Point(79, 2);
            this.open_iimage_in_paint_button.Name = "open_iimage_in_paint_button";
            this.open_iimage_in_paint_button.Size = new System.Drawing.Size(23, 23);
            this.open_iimage_in_paint_button.TabIndex = 5;
            this.open_iimage_in_paint_button.UseVisualStyleBackColor = false;
            this.open_iimage_in_paint_button.Click += new System.EventHandler(this.open_iimage_in_paint_button_Click);
            this.open_iimage_in_paint_button.MouseHover += new System.EventHandler(this.open_iimage_in_paint_button_MouseHover_1);
            // 
            // bottom_menu_Screenshot_panel
            // 
            this.bottom_menu_Screenshot_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottom_menu_Screenshot_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.bottom_menu_Screenshot_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottom_menu_Screenshot_panel.Controls.Add(this.help_button);
            this.bottom_menu_Screenshot_panel.Controls.Add(this.open_iimage_in_paint_button);
            this.bottom_menu_Screenshot_panel.Controls.Add(this.selectionScreenshot_button);
            this.bottom_menu_Screenshot_panel.Controls.Add(this.closeForm_button);
            this.bottom_menu_Screenshot_panel.Controls.Add(this.openFolder_button);
            this.bottom_menu_Screenshot_panel.Location = new System.Drawing.Point(14, 408);
            this.bottom_menu_Screenshot_panel.Name = "bottom_menu_Screenshot_panel";
            this.bottom_menu_Screenshot_panel.Size = new System.Drawing.Size(201, 31);
            this.bottom_menu_Screenshot_panel.TabIndex = 6;
            // 
            // SelectionScreenshot_Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bottom_menu_Screenshot_panel);
            this.Controls.Add(this.help_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionScreenshot_Form4";
            this.Text = "Selection Screenshot";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.SelectionScreenshot_Form4_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionScreenshot_Form4_FormClosing);
            this.Load += new System.EventHandler(this.SelectionScreenshot_Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectionScreenshot_Form4_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectionScreenshot_Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectionScreenshot_Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectionScreenshot_Form4_MouseUp);
            this.bottom_menu_Screenshot_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectionScreenshot_button;
        private System.Windows.Forms.Button closeForm_button;
        private System.Windows.Forms.Button openFolder_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label help_label;
        private System.Windows.Forms.Button open_iimage_in_paint_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel bottom_menu_Screenshot_panel;
    }
}