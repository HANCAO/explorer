﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explorer
{
    public partial class ContentForm : Form
    {
        public ContentForm()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ContentForm_Load(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (txtContent.SelectedText.Length > 0)
                txtContent.SelectedText = "";
        }

        private void tsbCut_Click(object sender, EventArgs e)
        {
            if (txtContent.SelectedText.Length > 0)
                txtContent.Cut();
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            if (txtContent.SelectedText.Length > 0)
                txtContent.Copy();
        }

        private void tsbReturn_Click(object sender, EventArgs e)
        {
            txtContent.Undo();
        }

        private void tsbSelectAll_Click(object sender, EventArgs e)
        {
            txtContent.SelectAll();
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                tsbPaste.Enabled = true;
                txtContent.Paste();
            }
            else
            {
                tsbPaste.Enabled = false;
            }
        }
    }
}
