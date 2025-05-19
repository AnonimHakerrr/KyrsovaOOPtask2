namespace KyrsovaOOPtask2
{
    partial class AddExam
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Predmet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastNameTheacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateProv = new System.Windows.Forms.DateTimePicker();
            this.NameTheacher = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.Rating = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предмет";
            // 
            // Predmet
            // 
            this.Predmet.Location = new System.Drawing.Point(32, 52);
            this.Predmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Predmet.Name = "Predmet";
            this.Predmet.Size = new System.Drawing.Size(100, 22);
            this.Predmet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата проведення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кількість годин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Оцінка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Посада Викладача";
            // 
            // LastNameTheacher
            // 
            this.LastNameTheacher.Location = new System.Drawing.Point(33, 242);
            this.LastNameTheacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTheacher.Name = "LastNameTheacher";
            this.LastNameTheacher.Size = new System.Drawing.Size(137, 22);
            this.LastNameTheacher.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Прізвище Викладача";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ім\'я Викладача";
            // 
            // DateProv
            // 
            this.DateProv.Location = new System.Drawing.Point(155, 52);
            this.DateProv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateProv.Name = "DateProv";
            this.DateProv.Size = new System.Drawing.Size(200, 22);
            this.DateProv.TabIndex = 20;
            // 
            // NameTheacher
            // 
            this.NameTheacher.Location = new System.Drawing.Point(177, 242);
            this.NameTheacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTheacher.Name = "NameTheacher";
            this.NameTheacher.Size = new System.Drawing.Size(137, 22);
            this.NameTheacher.TabIndex = 21;
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            " Асистент",
            " Викладач",
            " СтаршийВиклдач",
            " Доцент",
            " Професор"});
            this.Position.Location = new System.Drawing.Point(33, 187);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(121, 24);
            this.Position.TabIndex = 22;
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(155, 115);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(93, 22);
            this.Rating.TabIndex = 23;
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(29, 115);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(103, 22);
            this.Hours.TabIndex = 24;
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(367, 355);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.NameTheacher);
            this.Controls.Add(this.DateProv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LastNameTheacher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Predmet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddExam";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Predmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastNameTheacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateProv;
        private System.Windows.Forms.TextBox NameTheacher;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.NumericUpDown Rating;
        private System.Windows.Forms.NumericUpDown Hours;
    }
}