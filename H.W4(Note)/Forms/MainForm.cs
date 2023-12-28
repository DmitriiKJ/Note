using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace H.W4_Note_.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool save = false;
        Stack<string> history = new Stack<string>();
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = textBox_Field.Font;
            fontDialog.Color = textBox_Field.ForeColor;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_Field.Font = fontDialog.Font;
                textBox_Field.ForeColor = fontDialog.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.Color = textBox_Field.ForeColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                 textBox_Field.ForeColor = colorDialog.Color;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!saveFileDialog.FileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    saveFileDialog.FileName += ".txt";
                }

                if(string.IsNullOrWhiteSpace(textBox_Field.Text))
                {
                    MessageBox.Show("File is empty!");
                    return;
                }

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(textBox_Field.Text);
                }
                textBox_NameOpenFile.Text = saveFileDialog.FileName;
                saveToolStripMenuItem_SpeddSave.Enabled = true;
                save = false;

                MessageBox.Show("OK");
            }
            else
            {
                if (sender is MainForm)
                {
                    // Windows not close if user click cancel in saveFile
                    FormClosingEventArgs newE = e as FormClosingEventArgs;
                    newE.Cancel = true;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save)
            {
                MainForm_FormClosing(null, null);
            }

            if (!save)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        textBox_Field.Text = reader.ReadToEnd();
                        textBox_NameOpenFile.Text = openFileDialog.FileName;
                    }
                    save = false;
                }

                if (!string.IsNullOrEmpty(textBox_NameOpenFile.Text))
                {
                    saveToolStripMenuItem_SpeddSave.Enabled = true;
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            textBox_Find.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button_Cross.Parent = panel;
            button_Cross.Dock = DockStyle.Right;
            button_Next.Parent = panel;
            button_Next.Dock = DockStyle.Left;
            textBox_Find.Parent = panel;
            textBox_Find.Dock = DockStyle.Fill;
            history.Push(textBox_Field.Text);
            backToolStripMenuItem.Enabled = false;
            if(string.IsNullOrEmpty(Clipboard.GetText()))
            {
                Clipboard.SetText(" ");
            }
        }

        private void button_Cross_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
        }

        int selectStart = 0;
        private void textBox_Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox_Find.Text) && textBox_Field.Text.IndexOf(textBox_Find.Text) != -1)
                {
                    textBox_Field.Focus();
                    textBox_Field.Select(textBox_Field.Text.IndexOf(textBox_Find.Text), textBox_Find.Text.Length);

                    selectStart = textBox_Field.Text.IndexOf(textBox_Find.Text) + textBox_Find.Text.Length;
                }
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Find.Text) && textBox_Field.Text.IndexOf(textBox_Find.Text.Trim(), selectStart, StringComparison.Ordinal) != -1)
            {
                textBox_Field.Focus();
                textBox_Field.Select(textBox_Field.Text.IndexOf(textBox_Find.Text.Trim(), selectStart, StringComparison.Ordinal), textBox_Find.Text.Trim().Length);

                selectStart = textBox_Field.Text.IndexOf(textBox_Find.Text.Trim(), selectStart) + textBox_Find.Text.Trim().Length;
            }
        }

        private void saveToolStripMenuItem_SpeddSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(textBox_NameOpenFile.Text))
            {
                writer.Write(textBox_Field.Text);
            }
            MessageBox.Show("OK");
            save = false;

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Field.Text) && save)
            {
                DialogResult res = MessageBox.Show("Do you want to save document?", "Message", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(textBox_NameOpenFile.Text))
                    {
                        saveToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        saveToolStripMenuItem_SpeddSave_Click(null, null);
                    }
                }
                else if (res == DialogResult.No) { save = false; }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBox_Field_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Field.Text))
            {
                save = false;
            }
            else
            {
                save = true;
            }

            if (history.Peek() != textBox_Field.Text)
            {
                history.Push(textBox_Field.Text);
            }

            if(history.Count != 1)
            {
                backToolStripMenuItem.Enabled = true;
            }
            else
            {
                backToolStripMenuItem.Enabled = false;
            }
        }

        private void selectAllToolStripMenuItem_Select_Click(object sender, EventArgs e)
        {
            textBox_Field.SelectAll();
        }

        private void instructionToolStripMenuItem_Instruction_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.ShowDialog();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox_Field.SelectedText))
            Clipboard.SetText(textBox_Field.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string start = textBox_Field.Text.Substring(0, textBox_Field.SelectionStart);
            string end = textBox_Field.Text.Substring(textBox_Field.SelectionStart);
            textBox_Field.Text = start + Clipboard.GetText() + end;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Field.SelectedText = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            deleteToolStripMenuItem_Click(null, null);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history.Pop();
            textBox_Field.Text = history.Peek();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tmp = Clipboard.GetText();
            Clipboard.SetText(DateTime.Now.ToString());
            pasteToolStripMenuItem_Click(null, null);
            Clipboard.SetText(tmp);
        }
    }
}
