using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptoNote
{
    public partial class KriptoNote : Form
    {
        public KriptoNote()
        {
            InitializeComponent();
        }

        private void KriptoNote_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox.TextLength != 0)
            {
                int lineCount = richTextBox.Lines.Length;
                int columnCount = richTextBox.Lines[lineCount - 1].Length+1;
                linecolumnToolStripStatusLabel.Text = "Ln: " + lineCount + ", Col: " + columnCount;
            }
            else
                linecolumnToolStripStatusLabel.Text = "Ln: 1, Col: 1";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            encrypt.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
