namespace H.W4_Note_.Forms
{
    partial class Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruction));
            this.textBox_Instruction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Instruction
            // 
            this.textBox_Instruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Instruction.Location = new System.Drawing.Point(0, 0);
            this.textBox_Instruction.Multiline = true;
            this.textBox_Instruction.Name = "textBox_Instruction";
            this.textBox_Instruction.ReadOnly = true;
            this.textBox_Instruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Instruction.Size = new System.Drawing.Size(800, 450);
            this.textBox_Instruction.TabIndex = 0;
            this.textBox_Instruction.Text = resources.GetString("textBox_Instruction.Text");
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Instruction);
            this.Name = "Instruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Instruction;
    }
}