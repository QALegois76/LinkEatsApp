namespace LinkEatsApp.UC
{
    partial class FormTest
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
            this.aleGridView1 = new ALEControlLibrary.CTRL.ALEGridView();
            this.SuspendLayout();
            // 
            // aleGridView1
            // 
            this.aleGridView1.BorderSize = 2;
            this.aleGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aleGridView1.GridLineSize = 1;
            this.aleGridView1.IsDebug = true;
            this.aleGridView1.Location = new System.Drawing.Point(0, 0);
            this.aleGridView1.Name = "aleGridView1";
            this.aleGridView1.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.aleGridView1.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleGridView1.Size = new System.Drawing.Size(800, 450);
            this.aleGridView1.TabIndex = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aleGridView1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private ALEControlLibrary.CTRL.ALEGridView aleGridView1;
    }
}