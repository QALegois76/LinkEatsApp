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
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aleScrollBar1 = new ALEControlLibrary.ALEScrollBar();
            this.SuspendLayout();
            // 
            // aleGridView1
            // 
            this.aleGridView1.BorderSize = 2;
            this.aleGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.aleGridView1.GridLineSize = 1;
            this.aleGridView1.IsDebug = false;
            this.aleGridView1.Location = new System.Drawing.Point(0, 0);
            this.aleGridView1.Name = "aleGridView1";
            this.aleGridView1.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.aleGridView1.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.aleGridView1.Size = new System.Drawing.Size(694, 636);
            this.aleGridView1.TabIndex = 0;
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(822, 162);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(100, 23);
            this.btn_random.TabIndex = 1;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(742, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(241, 41);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(822, 81);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(158, 23);
            this.tb_name.TabIndex = 4;
            this.tb_name.Text = "Antoine";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(822, 121);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(158, 23);
            this.tb_lastName.TabIndex = 6;
            this.tb_lastName.Text = "LEGOIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName : ";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(822, 37);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(158, 23);
            this.tb_id.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD 100 Random";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aleScrollBar1
            // 
            this.aleScrollBar1.BorderSize = 1;
            this.aleScrollBar1.CornerRadius = 15;
            this.aleScrollBar1.GapBorderGrip = 2;
            this.aleScrollBar1.GripSize = 35;
            this.aleScrollBar1.IsAllowClickGoTo = false;
            this.aleScrollBar1.Location = new System.Drawing.Point(692, 0);
            this.aleScrollBar1.Maximum = 100;
            this.aleScrollBar1.Minimum = 0;
            this.aleScrollBar1.Mode = ALEControlLibrary.ALEScrollBar.EMode.Vertical;
            this.aleScrollBar1.Name = "aleScrollBar1";
            this.aleScrollBar1.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.aleScrollBar1.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.aleScrollBar1.Size = new System.Drawing.Size(26, 636);
            this.aleScrollBar1.TabIndex = 10;
            this.aleScrollBar1.Value = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 636);
            this.Controls.Add(this.aleScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.aleGridView1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ALEControlLibrary.CTRL.ALEGridView aleGridView1;
        private Button btn_random;
        private Button btn_add;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_lastName;
        private Label label2;
        private TextBox tb_id;
        private Label label3;
        private Button button1;
        private ALEControlLibrary.ALEScrollBar aleScrollBar1;
    }
}