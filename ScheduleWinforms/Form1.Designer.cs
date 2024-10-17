namespace ScheduleWinforms
{
    partial class MainForm
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
            panel1 = new Panel();
            btnSetReminder = new Button();
            numericUpDownReminder = new NumericUpDown();
            btnAdd = new Button();
            btnRemove = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtTitle = new TextBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReminder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSetReminder);
            panel1.Controls.Add(numericUpDownReminder);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtTitle);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 514);
            panel1.TabIndex = 0;
            // 
            // btnSetReminder
            // 
            btnSetReminder.Dock = DockStyle.Bottom;
            btnSetReminder.Location = new Point(0, 317);
            btnSetReminder.Name = "btnSetReminder";
            btnSetReminder.Size = new Size(214, 58);
            btnSetReminder.TabIndex = 5;
            btnSetReminder.Text = "Установить упоминание";
            btnSetReminder.UseVisualStyleBackColor = true;
            btnSetReminder.Click += btnSetReminder_Click;
            // 
            // numericUpDownReminder
            // 
            numericUpDownReminder.Dock = DockStyle.Bottom;
            numericUpDownReminder.Location = new Point(0, 375);
            numericUpDownReminder.Name = "numericUpDownReminder";
            numericUpDownReminder.Size = new Size(214, 23);
            numericUpDownReminder.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(0, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 58);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Bottom;
            btnRemove.Location = new Point(0, 456);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(214, 58);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Top;
            dateTimePicker1.Location = new Point(0, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Top;
            txtTitle.Location = new Point(0, 0);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Название события";
            txtTitle.Size = new Size(214, 23);
            txtTitle.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(214, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(683, 514);
            listBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 514);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Расписание";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReminder).EndInit();
            ResumeLayout(false);
        }

        private void BtnSetReminder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private Button btnAdd;
        private Button btnRemove;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTitle;
        private NumericUpDown numericUpDownReminder;
        private Button btnSetReminder;
    }
}
