namespace ALEControlLibrary.CTRL
{
    partial class ALERoundedTextbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Location = new System.Drawing.Point(3, 6);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(210, 16);
            this.tb.TabIndex = 0;
            // 
            // ALERoundedTextbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tb);
            this.Name = "ALERoundedTextbox";
            this.Size = new System.Drawing.Size(218, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb;
    }
}
