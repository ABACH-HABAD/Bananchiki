namespace DataIVremya
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Day = new TextBox();
            Month = new TextBox();
            Year = new TextBox();
            Today = new Button();
            Up = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "День";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Месяц";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 9);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "Год";
            // 
            // Day
            // 
            Day.Location = new Point(12, 27);
            Day.Name = "Day";
            Day.Size = new Size(34, 23);
            Day.TabIndex = 3;
            Day.Text = "1";
            Day.TextChanged += Day_TextChanged;
            // 
            // Month
            // 
            Month.Location = new Point(52, 27);
            Month.Name = "Month";
            Month.Size = new Size(43, 23);
            Month.TabIndex = 4;
            Month.Text = "1";
            Month.TextChanged += Month_TextChanged;
            // 
            // Year
            // 
            Year.Location = new Point(101, 27);
            Year.Name = "Year";
            Year.Size = new Size(71, 23);
            Year.TabIndex = 5;
            Year.Text = "1";
            Year.TextChanged += Year_TextChanged;
            // 
            // Today
            // 
            Today.Location = new Point(178, 27);
            Today.Name = "Today";
            Today.Size = new Size(60, 52);
            Today.TabIndex = 6;
            Today.Text = "Сегодня";
            Today.UseVisualStyleBackColor = true;
            Today.Click += Today_Click;
            // 
            // Up
            // 
            Up.Location = new Point(12, 56);
            Up.Name = "Up";
            Up.Size = new Size(160, 23);
            Up.TabIndex = 7;
            Up.Text = "Добавть 1 день";
            Up.UseVisualStyleBackColor = true;
            Up.Click += Up_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(245, 87);
            Controls.Add(Up);
            Controls.Add(Today);
            Controls.Add(Year);
            Controls.Add(Month);
            Controls.Add(Day);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Дата";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Day;
        private TextBox Month;
        private TextBox Year;
        private Button Today;
        private Button Up;
    }
}
