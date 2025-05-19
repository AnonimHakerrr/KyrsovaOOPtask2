namespace KyrsovaOOPtask2
{
    partial class AddStud
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NameStudent = new System.Windows.Forms.TextBox();
            this.LastNameStudent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ім\'я  Студента";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Прізвище Студента";
            // 
            // NameStudent
            // 
            this.NameStudent.Location = new System.Drawing.Point(163, 128);
            this.NameStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.Size = new System.Drawing.Size(137, 22);
            this.NameStudent.TabIndex = 31;
            this.NameStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Click_KeyDown);
            // 
            // LastNameStudent
            // 
            this.LastNameStudent.Location = new System.Drawing.Point(19, 128);
            this.LastNameStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameStudent.Name = "LastNameStudent";
            this.LastNameStudent.Size = new System.Drawing.Size(137, 22);
            this.LastNameStudent.TabIndex = 30;
            this.LastNameStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Click_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Номер групи";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listGroup
            // 
            this.listGroup.FormattingEnabled = true;
            this.listGroup.Location = new System.Drawing.Point(19, 69);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(121, 24);
            this.listGroup.TabIndex = 35;
            // 
            // AddStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 250);
            this.Controls.Add(this.listGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NameStudent);
            this.Controls.Add(this.LastNameStudent);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddStud";
            this.Text = "AddStud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameStudent;
        private System.Windows.Forms.TextBox LastNameStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox listGroup;
    }
}