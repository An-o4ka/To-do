using System.Drawing.Drawing2D;

namespace WinFormsApp1
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
            TaskDelButton = new Button();
            cpicok = new CheckedListBox();
            button2 = new Button();
            buttonClear = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // TaskDelButton
            // 
            TaskDelButton.BackColor = Color.IndianRed;
            TaskDelButton.Location = new Point(42, 84);
            TaskDelButton.Name = "TaskDelButton";
            TaskDelButton.Size = new Size(230, 28);
            TaskDelButton.TabIndex = 4;
            TaskDelButton.Text = "Удалить задачу";
            TaskDelButton.UseVisualStyleBackColor = false;
            TaskDelButton.Click += TaskDelButton_Click;
            // 
            // cpicok
            // 
            cpicok.BackColor = SystemColors.Menu;
            cpicok.BorderStyle = BorderStyle.None;
            cpicok.FormattingEnabled = true;
            cpicok.Location = new Point(42, 118);
            cpicok.Name = "cpicok";
            cpicok.Size = new Size(675, 270);
            cpicok.Sorted = true;
            cpicok.TabIndex = 5;
            cpicok.SelectedIndexChanged += cpicok_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(494, 394);
            button2.Name = "button2";
            button2.Size = new Size(223, 28);
            button2.TabIndex = 8;
            button2.Text = "Загрузить сохранённый список";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseCaptureChanged += button2_MouseCaptureChanged;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.Location = new Point(494, 84);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(223, 28);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Очистить список задач";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 10;
            label1.Text = "Ого тут можно писать задачи ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(675, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(768, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonClear);
            Controls.Add(button2);
            Controls.Add(cpicok);
            Controls.Add(TaskDelButton);
            Name = "Form1";
            Text = "  ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button TaskDelButton;
        private CheckedListBox cpicok;
        private Button button2;
        private Button buttonClear;
        private Label label1;
        private TextBox textBox1;
    }
}
