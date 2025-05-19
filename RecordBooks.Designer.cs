namespace KyrsovaOOPtask2
{
    partial class RecordBooks
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читанняЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивідСтруденівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнійБалСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивідЕкзаменівСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнійБалПоЕкзаменуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивідСтудентівПоЕкзаменуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додаванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додаванняСтрудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додаванняЕкзаменуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteExamMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateRatingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.додаванняToolStripMenuItem,
            this.DeleteMenuItem,
            this.пошукСтудентаToolStripMenuItem,
            this.UpdateRatingMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читанняЗФайлуToolStripMenuItem,
            this.записВФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // читанняЗФайлуToolStripMenuItem
            // 
            this.читанняЗФайлуToolStripMenuItem.Name = "читанняЗФайлуToolStripMenuItem";
            this.читанняЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.читанняЗФайлуToolStripMenuItem.Text = "Читання з файлу";
            this.читанняЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.ReadFile);
            // 
            // записВФайлToolStripMenuItem
            // 
            this.записВФайлToolStripMenuItem.Name = "записВФайлToolStripMenuItem";
            this.записВФайлToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.записВФайлToolStripMenuItem.Text = "Запис в файл";
            this.записВФайлToolStripMenuItem.Click += new System.EventHandler(this.WriteFile);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вивідСтруденівToolStripMenuItem,
            this.середнійБалПоЕкзаменуToolStripMenuItem,
            this.сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem,
            this.вивідСтудентівПоЕкзаменуToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.filterToolStripMenuItem.Text = "Фільтр";
            // 
            // вивідСтруденівToolStripMenuItem
            // 
            this.вивідСтруденівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.середнійБалСтудентаToolStripMenuItem,
            this.вивідЕкзаменівСтудентаToolStripMenuItem});
            this.вивідСтруденівToolStripMenuItem.Name = "вивідСтруденівToolStripMenuItem";
            this.вивідСтруденівToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.вивідСтруденівToolStripMenuItem.Text = "Вивід студентів";
            this.вивідСтруденівToolStripMenuItem.Click += new System.EventHandler(this.ViewListStudent);
            // 
            // середнійБалСтудентаToolStripMenuItem
            // 
            this.середнійБалСтудентаToolStripMenuItem.Name = "середнійБалСтудентаToolStripMenuItem";
            this.середнійБалСтудентаToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.середнійБалСтудентаToolStripMenuItem.Text = "Середній бал студента";
            this.середнійБалСтудентаToolStripMenuItem.Click += new System.EventHandler(this.AverageScoreToStudent);
            // 
            // вивідЕкзаменівСтудентаToolStripMenuItem
            // 
            this.вивідЕкзаменівСтудентаToolStripMenuItem.Name = "вивідЕкзаменівСтудентаToolStripMenuItem";
            this.вивідЕкзаменівСтудентаToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.вивідЕкзаменівСтудентаToolStripMenuItem.Text = "Вивід екзаменів студента";
            this.вивідЕкзаменівСтудентаToolStripMenuItem.Click += new System.EventHandler(this.ViewExamsToStudent);
            // 
            // середнійБалПоЕкзаменуToolStripMenuItem
            // 
            this.середнійБалПоЕкзаменуToolStripMenuItem.Name = "середнійБалПоЕкзаменуToolStripMenuItem";
            this.середнійБалПоЕкзаменуToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.середнійБалПоЕкзаменуToolStripMenuItem.Text = "Сортування  по середньому балу";
            this.середнійБалПоЕкзаменуToolStripMenuItem.Click += new System.EventHandler(this.SortStudentsAverage);
            // 
            // сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem
            // 
            this.сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem.Name = "сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem";
            this.сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem.Text = "Сортування студентів по оцінці екзамен";
            this.сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem.Click += new System.EventHandler(this.SortStudentsRatingExam);
            // 
            // вивідСтудентівПоЕкзаменуToolStripMenuItem
            // 
            this.вивідСтудентівПоЕкзаменуToolStripMenuItem.Name = "вивідСтудентівПоЕкзаменуToolStripMenuItem";
            this.вивідСтудентівПоЕкзаменуToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.вивідСтудентівПоЕкзаменуToolStripMenuItem.Text = "Вивід студентів по екзамену";
            this.вивідСтудентівПоЕкзаменуToolStripMenuItem.Click += new System.EventHandler(this.ViewStudentsOnExam);
            // 
            // додаванняToolStripMenuItem
            // 
            this.додаванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додаванняСтрудентаToolStripMenuItem,
            this.додаванняЕкзаменуToolStripMenuItem});
            this.додаванняToolStripMenuItem.Name = "додаванняToolStripMenuItem";
            this.додаванняToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.додаванняToolStripMenuItem.Text = "Додавання";
            // 
            // додаванняСтрудентаToolStripMenuItem
            // 
            this.додаванняСтрудентаToolStripMenuItem.Name = "додаванняСтрудентаToolStripMenuItem";
            this.додаванняСтрудентаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.додаванняСтрудентаToolStripMenuItem.Text = "Додавання студента";
            this.додаванняСтрудентаToolStripMenuItem.Click += new System.EventHandler(this.AddStudent);
            // 
            // додаванняЕкзаменуToolStripMenuItem
            // 
            this.додаванняЕкзаменуToolStripMenuItem.Name = "додаванняЕкзаменуToolStripMenuItem";
            this.додаванняЕкзаменуToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.додаванняЕкзаменуToolStripMenuItem.Text = "Додавання екзамену";
            this.додаванняЕкзаменуToolStripMenuItem.Click += new System.EventHandler(this.AddExamToStudent);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteStudentMenuItem,
            this.DeleteExamMenuItem});
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(101, 24);
            this.DeleteMenuItem.Text = "Видалення";
            this.DeleteMenuItem.Visible = false;
            // 
            // DeleteStudentMenuItem
            // 
            this.DeleteStudentMenuItem.Name = "DeleteStudentMenuItem";
            this.DeleteStudentMenuItem.Size = new System.Drawing.Size(225, 26);
            this.DeleteStudentMenuItem.Text = "Студента";
            this.DeleteStudentMenuItem.Visible = false;
            this.DeleteStudentMenuItem.Click += new System.EventHandler(this.DeleteStudent);
            // 
            // DeleteExamMenuItem
            // 
            this.DeleteExamMenuItem.Name = "DeleteExamMenuItem";
            this.DeleteExamMenuItem.Size = new System.Drawing.Size(225, 26);
            this.DeleteExamMenuItem.Text = "Екзамену студента";
            this.DeleteExamMenuItem.Visible = false;
            this.DeleteExamMenuItem.Click += new System.EventHandler(this.DeleteExamToStudent);
            // 
            // пошукСтудентаToolStripMenuItem
            // 
            this.пошукСтудентаToolStripMenuItem.Name = "пошукСтудентаToolStripMenuItem";
            this.пошукСтудентаToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.пошукСтудентаToolStripMenuItem.Text = "Пошук студента";
            this.пошукСтудентаToolStripMenuItem.Click += new System.EventHandler(this.SeachStudent);
            // 
            // UpdateRatingMenuItem
            // 
            this.UpdateRatingMenuItem.Name = "UpdateRatingMenuItem";
            this.UpdateRatingMenuItem.Size = new System.Drawing.Size(174, 24);
            this.UpdateRatingMenuItem.Text = "Редагуванння оцінки";
            this.UpdateRatingMenuItem.Visible = false;
            this.UpdateRatingMenuItem.Click += new System.EventHandler(this.UpdateRatingExam);
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(808, 436);
            this.listBox1.TabIndex = 6;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            // 
            // RecordBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(873, 514);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecordBooks";
            this.Text = "RecordBooks";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнійБалПоЕкзаменуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивідСтруденівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивідСтудентівПоЕкзаменуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додаванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додаванняСтрудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додаванняЕкзаменуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteExamMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читанняЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateRatingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнійБалСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивідЕкзаменівСтудентаToolStripMenuItem;
    }
}

