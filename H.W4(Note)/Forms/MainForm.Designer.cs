namespace H.W4_Note_.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_Field = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_SpeddSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem_Select = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem_Instruction = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button_Cross = new System.Windows.Forms.Button();
            this.panelReplace = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxToReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWhatReplace = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_NameOpenFile = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.ReplaceNext = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelReplace.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Field
            // 
            this.textBox_Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Field.Location = new System.Drawing.Point(0, 55);
            this.textBox_Field.Multiline = true;
            this.textBox_Field.Name = "textBox_Field";
            this.textBox_Field.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Field.Size = new System.Drawing.Size(1195, 539);
            this.textBox_Field.TabIndex = 0;
            this.textBox_Field.TextChanged += new System.EventHandler(this.textBox_Field_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem_Edit,
            this.instructionToolStripMenuItem_Instruction});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1195, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileToolStripMenuItem_DropDownItemClicked);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem_SpeddSave,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileToolStripMenuItem_DropDownItemClicked);
            // 
            // saveToolStripMenuItem_SpeddSave
            // 
            this.saveToolStripMenuItem_SpeddSave.Enabled = false;
            this.saveToolStripMenuItem_SpeddSave.Name = "saveToolStripMenuItem_SpeddSave";
            this.saveToolStripMenuItem_SpeddSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem_SpeddSave.Size = new System.Drawing.Size(213, 26);
            this.saveToolStripMenuItem_SpeddSave.Text = "Save";
            this.saveToolStripMenuItem_SpeddSave.Click += new System.EventHandler(this.saveToolStripMenuItem_SpeddSave_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.saveToolStripMenuItem.Text = "Save as";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem_Edit
            // 
            this.editToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem_Select,
            this.toolStripSeparator3,
            this.backToolStripMenuItem,
            this.toolStripSeparator4,
            this.dateTimeToolStripMenuItem});
            this.editToolStripMenuItem_Edit.Name = "editToolStripMenuItem_Edit";
            this.editToolStripMenuItem_Edit.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem_Edit.Text = "Edit";
            this.editToolStripMenuItem_Edit.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileToolStripMenuItem_DropDownItemClicked);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // selectAllToolStripMenuItem_Select
            // 
            this.selectAllToolStripMenuItem_Select.Name = "selectAllToolStripMenuItem_Select";
            this.selectAllToolStripMenuItem_Select.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.selectAllToolStripMenuItem_Select.Size = new System.Drawing.Size(216, 26);
            this.selectAllToolStripMenuItem_Select.Text = "Select All";
            this.selectAllToolStripMenuItem_Select.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Select_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dateTimeToolStripMenuItem.Text = "Date/Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // instructionToolStripMenuItem_Instruction
            // 
            this.instructionToolStripMenuItem_Instruction.Name = "instructionToolStripMenuItem_Instruction";
            this.instructionToolStripMenuItem_Instruction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.instructionToolStripMenuItem_Instruction.Size = new System.Drawing.Size(92, 24);
            this.instructionToolStripMenuItem_Instruction.Text = "Instruction";
            this.instructionToolStripMenuItem_Instruction.Click += new System.EventHandler(this.instructionToolStripMenuItem_Instruction_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "MyText";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text file|*.txt";
            // 
            // textBox_Find
            // 
            this.textBox_Find.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Find.Location = new System.Drawing.Point(85, 3);
            this.textBox_Find.Multiline = true;
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(636, 39);
            this.textBox_Find.TabIndex = 2;
            this.textBox_Find.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Find_KeyDown);
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Next.Location = new System.Drawing.Point(0, 3);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(79, 40);
            this.button_Next.TabIndex = 4;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBox_Find);
            this.panel.Controls.Add(this.button_Next);
            this.panel.Controls.Add(this.button_Cross);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 594);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1195, 46);
            this.panel.TabIndex = 5;
            this.panel.Visible = false;
            // 
            // button_Cross
            // 
            this.button_Cross.Image = global::H.W4_Note_.Properties.Resources.cross_icon_160913__1_;
            this.button_Cross.Location = new System.Drawing.Point(727, 3);
            this.button_Cross.Name = "button_Cross";
            this.button_Cross.Size = new System.Drawing.Size(73, 40);
            this.button_Cross.TabIndex = 3;
            this.button_Cross.UseVisualStyleBackColor = true;
            this.button_Cross.Click += new System.EventHandler(this.button_Cross_Click);
            // 
            // panelReplace
            // 
            this.panelReplace.Controls.Add(this.ReplaceNext);
            this.panelReplace.Controls.Add(this.button3);
            this.panelReplace.Controls.Add(this.button1);
            this.panelReplace.Controls.Add(this.label2);
            this.panelReplace.Controls.Add(this.textBoxToReplace);
            this.panelReplace.Controls.Add(this.label1);
            this.panelReplace.Controls.Add(this.textBoxWhatReplace);
            this.panelReplace.Controls.Add(this.button2);
            this.panelReplace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReplace.Location = new System.Drawing.Point(0, 526);
            this.panelReplace.Name = "panelReplace";
            this.panelReplace.Size = new System.Drawing.Size(1195, 46);
            this.panelReplace.TabIndex = 6;
            this.panelReplace.Visible = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(898, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 40);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonReplaceAllClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // textBoxToReplace
            // 
            this.textBoxToReplace.BackColor = System.Drawing.Color.LightGray;
            this.textBoxToReplace.Location = new System.Drawing.Point(394, 4);
            this.textBoxToReplace.Multiline = true;
            this.textBoxToReplace.Name = "textBoxToReplace";
            this.textBoxToReplace.Size = new System.Drawing.Size(294, 39);
            this.textBoxToReplace.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "What:";
            // 
            // textBoxWhatReplace
            // 
            this.textBoxWhatReplace.BackColor = System.Drawing.Color.LightGray;
            this.textBoxWhatReplace.Location = new System.Drawing.Point(59, 3);
            this.textBoxWhatReplace.Multiline = true;
            this.textBoxWhatReplace.Name = "textBoxWhatReplace";
            this.textBoxWhatReplace.Size = new System.Drawing.Size(294, 39);
            this.textBoxWhatReplace.TabIndex = 2;
            this.textBoxWhatReplace.TextChanged += new System.EventHandler(this.textBoxWhatReplace_TextChanged);
            // 
            // button2
            // 
            this.button2.Image = global::H.W4_Note_.Properties.Resources.cross_icon_160913__1_;
            this.button2.Location = new System.Drawing.Point(988, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 40);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_NameOpenFile
            // 
            this.textBox_NameOpenFile.Location = new System.Drawing.Point(1095, 566);
            this.textBox_NameOpenFile.Name = "textBox_NameOpenFile";
            this.textBox_NameOpenFile.Size = new System.Drawing.Size(100, 22);
            this.textBox_NameOpenFile.TabIndex = 6;
            this.textBox_NameOpenFile.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "SimpleNotepadDocument";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfo,
            this.toolStripSeparator6,
            this.toolStripButtonSave,
            this.toolStripButtonOpen,
            this.toolStripButtonPrint,
            this.toolStripSeparator5,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1195, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonInfo.Text = "Info";
            this.toolStripButtonInfo.ToolTipText = "Info";
            this.toolStripButtonInfo.Click += new System.EventHandler(this.instructionToolStripMenuItem_Instruction_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonPrint.Text = "Print";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCut.Text = "Cut";
            this.toolStripButtonCut.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCopy.Text = "Copy";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonPaste.Text = "Paste";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1195, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(807, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 40);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonReplaceOneClick);
            // 
            // ReplaceNext
            // 
            this.ReplaceNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceNext.Location = new System.Drawing.Point(709, 6);
            this.ReplaceNext.Name = "ReplaceNext";
            this.ReplaceNext.Size = new System.Drawing.Size(79, 40);
            this.ReplaceNext.TabIndex = 5;
            this.ReplaceNext.Text = "Next";
            this.ReplaceNext.UseVisualStyleBackColor = true;
            this.ReplaceNext.Click += new System.EventHandler(this.buttonReplaceNextOneClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 640);
            this.Controls.Add(this.panelReplace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox_Field);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_NameOpenFile);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelReplace.ResumeLayout(false);
            this.panelReplace.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Field;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.Button button_Cross;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBox_NameOpenFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_SpeddSave;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem_Instruction;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem_Select;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelReplace;
        private System.Windows.Forms.TextBox textBoxWhatReplace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxToReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ReplaceNext;
        private System.Windows.Forms.Button button1;
    }
}