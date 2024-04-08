namespace ListBox
{
    partial class FormList
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
            listBox1 = new System.Windows.Forms.ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MaxBox = new TextBox();
            listBox2 = new System.Windows.Forms.ListBox();
            MinBox = new TextBox();
            SizeBox = new TextBox();
            label6 = new Label();
            ResoltBox = new TextBox();
            CreateNew = new Button();
            FillRandom = new Button();
            CurrentState = new Button();
            Transformation = new Button();
            CurrentState2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Размер массива";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 2;
            label2.Text = "Мин. значение элемента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 3;
            label3.Text = "Макс. значение элемента";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 4;
            label4.Text = "Массив исходный";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 119);
            label5.Name = "label5";
            label5.Size = new Size(153, 15);
            label5.TabIndex = 5;
            label5.Text = "Массив преобразованный";
            // 
            // MaxBox
            // 
            MaxBox.Location = new Point(166, 71);
            MaxBox.Name = "MaxBox";
            MaxBox.Size = new Size(100, 23);
            MaxBox.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(226, 137);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 169);
            listBox2.TabIndex = 7;
            // 
            // MinBox
            // 
            MinBox.Location = new Point(166, 37);
            MinBox.Name = "MinBox";
            MinBox.Size = new Size(100, 23);
            MinBox.TabIndex = 8;
            // 
            // SizeBox
            // 
            SizeBox.Location = new Point(166, 8);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(100, 23);
            SizeBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 318);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 10;
            label6.Text = "Результат операции";
            // 
            // ResoltBox
            // 
            ResoltBox.Location = new Point(12, 336);
            ResoltBox.Multiline = true;
            ResoltBox.Name = "ResoltBox";
            ResoltBox.Size = new Size(334, 66);
            ResoltBox.TabIndex = 11;
            // 
            // CreateNew
            // 
            CreateNew.Location = new Point(81, 408);
            CreateNew.Name = "CreateNew";
            CreateNew.Size = new Size(195, 40);
            CreateNew.TabIndex = 12;
            CreateNew.Text = "Создать массив";
            CreateNew.UseVisualStyleBackColor = true;
            CreateNew.Click += CreateNew_Click;
            // 
            // FillRandom
            // 
            FillRandom.Location = new Point(81, 454);
            FillRandom.Name = "FillRandom";
            FillRandom.Size = new Size(195, 40);
            FillRandom.TabIndex = 13;
            FillRandom.Text = "Заполнить случайными числами";
            FillRandom.UseVisualStyleBackColor = true;
            FillRandom.Click += FillRandom_Click;
            // 
            // CurrentState
            // 
            CurrentState.Location = new Point(81, 500);
            CurrentState.Name = "CurrentState";
            CurrentState.Size = new Size(195, 40);
            CurrentState.TabIndex = 14;
            CurrentState.Text = "Текущее состояние";
            CurrentState.UseVisualStyleBackColor = true;
            CurrentState.Click += CurrentState_Click;
            // 
            // Transformation
            // 
            Transformation.Location = new Point(81, 546);
            Transformation.Name = "Transformation";
            Transformation.Size = new Size(195, 40);
            Transformation.TabIndex = 15;
            Transformation.Text = "Преобразовать массив";
            Transformation.UseVisualStyleBackColor = true;
            Transformation.Click += Transformation_Click;
            // 
            // CurrentState2
            // 
            CurrentState2.Location = new Point(81, 592);
            CurrentState2.Name = "CurrentState2";
            CurrentState2.Size = new Size(195, 40);
            CurrentState2.TabIndex = 16;
            CurrentState2.Text = "Состояние преобразованного";
            CurrentState2.UseVisualStyleBackColor = true;
            CurrentState2.Click += CurrentState2_Click;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 650);
            Controls.Add(CurrentState2);
            Controls.Add(Transformation);
            Controls.Add(CurrentState);
            Controls.Add(FillRandom);
            Controls.Add(CreateNew);
            Controls.Add(ResoltBox);
            Controls.Add(label6);
            Controls.Add(SizeBox);
            Controls.Add(MinBox);
            Controls.Add(listBox2);
            Controls.Add(MaxBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "FormList";
            Text = "Список";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox MaxBox;
        private System.Windows.Forms.ListBox listBox2;
        private TextBox MinBox;
        private TextBox SizeBox;
        private Label label6;
        private TextBox ResoltBox;
        private Button CreateNew;
        private Button FillRandom;
        private Button CurrentState;
        private Button Transformation;
        private Button CurrentState2;
    }
}
