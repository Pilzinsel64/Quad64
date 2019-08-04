﻿namespace Quad64.src.Forms
{
    partial class ThemeSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeSelector));
            this.themes = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancel_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themes
            // 
            this.themes.AutoArrange = false;
            this.themes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.author});
            this.themes.FullRowSelect = true;
            this.themes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.themes.Location = new System.Drawing.Point(12, 12);
            this.themes.Name = "themes";
            this.themes.ShowGroups = false;
            this.themes.Size = new System.Drawing.Size(350, 170);
            this.themes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.themes.TabIndex = 0;
            this.themes.TabStop = false;
            this.themes.UseCompatibleStateImageBehavior = false;
            this.themes.View = System.Windows.Forms.View.Details;
            this.themes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.themes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Themes_MouseDoubleClick);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 250;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.Width = 96;
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Location = new System.Drawing.Point(187, 188);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(104, 29);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // load_button
            // 
            this.load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_button.Location = new System.Drawing.Point(77, 188);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(104, 29);
            this.load_button.TabIndex = 3;
            this.load_button.Text = "Select";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // ThemeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 223);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.themes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Theme";
            this.Load += new System.EventHandler(this.ThemeSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView themes;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button load_button;
    }
}