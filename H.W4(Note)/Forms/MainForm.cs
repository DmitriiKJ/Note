using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace H.W4_Note_.Forms
{
    public partial class MainForm : Form
    {
        private StringReader m_myReader;
        private uint m_PrintPageNumber;
        private bool save = false;
        private Stack<string> history = new Stack<string>();
        private bool replace = false;
        private int selectStart = 0;
        private int lastSelectStart = 0;

        public MainForm()
        {
            InitializeComponent();
        }

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
            panelReplace.Visible = false;
            lastSelectStart = 0;
            selectStart = 0;
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

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            m_PrintPageNumber = 1;
            string strText = textBox_Field.Text;
            m_myReader = new StringReader(strText);
            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            m_myReader.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int lineCount = 0;
            float linesPerPage = 0;
            float yLinePosition = 0;
                                   
            string currentLine = null;
                                       
            Font printFont = textBox_Field.Font;
            SolidBrush printBrush = new SolidBrush(Color.Black);
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top +
            3 * printFont.GetHeight(e.Graphics);
            linesPerPage = (e.MarginBounds.Height -
            6 * printFont.GetHeight(e.Graphics)) /
            printFont.GetHeight(e.Graphics);
            while (lineCount < linesPerPage &&
            ((currentLine = m_myReader.ReadLine()) != null))
            {
                yLinePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(currentLine, printFont, printBrush,
                leftMargin, yLinePosition, new StringFormat());
                lineCount++;
            }
            string sPageNumber = "Page " + m_PrintPageNumber.ToString();
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(sPageNumber, printFont,
            e.MarginBounds.Right - e.MarginBounds.Left);
            e.Graphics.DrawString(sPageNumber, printFont, printBrush,
            e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top,
            new StringFormat());
            e.Graphics.DrawString(this.Text, printFont, printBrush,
            e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());
            Pen colontitulPen = new Pen(Color.Black);
            colontitulPen.Width = 2;
            e.Graphics.DrawLine(colontitulPen,
            leftMargin,
            e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
            e.MarginBounds.Right, e.MarginBounds.Top +
            printFont.GetHeight(e.Graphics) + 3);
            e.Graphics.DrawLine(colontitulPen,
            leftMargin, e.MarginBounds.Bottom - 3,
            e.MarginBounds.Right, e.MarginBounds.Bottom - 3);
            e.Graphics.DrawString(
            "SimpleNotepad",
            printFont, printBrush,
            e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());
            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }
            else
                e.HasMorePages = false;
            printBrush.Dispose();
            colontitulPen.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void UpdateStatus(ToolStripItem item)
        {
            if (item != null)
            {
                string msg = String.Format("{0} selected", item.Text);
                this.statusStrip1.Items[0].Text = msg;
            }
        }

        private void buttonReplaceAllClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxWhatReplace.Text) && textBox_Field.Text.IndexOf(textBoxWhatReplace.Text.Trim(), selectStart, StringComparison.Ordinal) != -1)
            {
                var text = textBox_Field.Text.Replace(textBoxWhatReplace.Text, textBoxToReplace.Text);

                textBox_Field.Text = text;
            }
        }

        private void buttonReplaceNextOneClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxWhatReplace.Text) && textBox_Field.Text.IndexOf(textBoxWhatReplace.Text.Trim(), selectStart, StringComparison.Ordinal) != -1)
            {
                lastSelectStart = selectStart;
                textBox_Field.Focus();
                textBox_Field.Select(textBox_Field.Text.IndexOf(textBoxWhatReplace.Text.Trim(), selectStart, StringComparison.Ordinal), textBoxWhatReplace.Text.Trim().Length);

                selectStart = textBox_Field.Text.IndexOf(textBoxWhatReplace.Text.Trim(), selectStart) + textBoxWhatReplace.Text.Trim().Length;
                replace = true;
            }
        }

        private void buttonReplaceOneClick(object sender, EventArgs e)
        {
            if (replace)
            {
                string text = textBox_Field.Text;
                int lengthToRemove = textBoxWhatReplace.Text.Trim().Length;
                var startIndex = textBox_Field.Text.IndexOf(textBoxWhatReplace.Text.Trim(), lastSelectStart, StringComparison.Ordinal);
                if (startIndex >= 0 && startIndex + lengthToRemove <= text.Length)
                {
                    text = text.Remove(startIndex, lengthToRemove)
                               .Insert(startIndex, textBoxToReplace.Text.Trim());
                }
                textBox_Field.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelReplace.Visible = false;
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelReplace.Visible = true;
            panel.Visible = false;
            lastSelectStart = 0;
            selectStart = 0;
        }

        private void textBoxWhatReplace_TextChanged(object sender, EventArgs e)
        {
            replace = false;
            lastSelectStart = 0;
            selectStart = 0;
        }
    }
}
