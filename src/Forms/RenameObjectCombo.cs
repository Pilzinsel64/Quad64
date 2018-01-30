﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quad64.src.Forms
{
    public partial class RenameObjectCombo : Form
    {
        public bool ClickedSelect { get; set; }
        public string ReturnName { get; set; }

        public RenameObjectCombo(string input)
        {
            InitializeComponent();
            textBox.Text = input;
            ClickedSelect = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.StartsWith("Undefined Combo"))
            {
                ReturnName = textBox.Text;
                ClickedSelect = true;
                Hide();
            }
            else
            {
                MessageBox.Show("You cannot have the combo name start with \"Undefined Combo\".");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClickedSelect = false;
            Hide();
        }
    }
}
