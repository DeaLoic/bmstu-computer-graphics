namespace lab_01
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearAllFirstBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.textOut = new System.Windows.Forms.TextBox();
            this.enterDotFirstBtn = new System.Windows.Forms.Button();
            this.xEnterFirst = new System.Windows.Forms.TextBox();
            this.yEnterFirst = new System.Windows.Forms.TextBox();
            this.deleteDotFirstBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yEnterSecond = new System.Windows.Forms.TextBox();
            this.xEnterSecond = new System.Windows.Forms.TextBox();
            this.enterDotSecondBtn = new System.Windows.Forms.Button();
            this.clearAllSecondBtn = new System.Windows.Forms.Button();
            this.leftDotDelNumber = new System.Windows.Forms.TextBox();
            this.rightDotDelNumber = new System.Windows.Forms.TextBox();
            this.deleteDotSecondBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 468);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 24;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(171, 399);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridView1_RowPrePaint);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeight = 24;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(799, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(171, 399);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridView2_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первое множество";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Второе множество";
            // 
            // clearAllFirstBtn
            // 
            this.clearAllFirstBtn.Location = new System.Drawing.Point(12, 444);
            this.clearAllFirstBtn.Name = "clearAllFirstBtn";
            this.clearAllFirstBtn.Size = new System.Drawing.Size(171, 36);
            this.clearAllFirstBtn.TabIndex = 5;
            this.clearAllFirstBtn.Text = "Очистить все";
            this.clearAllFirstBtn.UseVisualStyleBackColor = true;
            this.clearAllFirstBtn.Click += new System.EventHandler(this.ClearAllFirstBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.LightCoral;
            this.calculateBtn.Location = new System.Drawing.Point(189, 486);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(195, 54);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Рассчет";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textOut
            // 
            this.textOut.BackColor = System.Drawing.SystemColors.Info;
            this.textOut.Location = new System.Drawing.Point(390, 486);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.ReadOnly = true;
            this.textOut.Size = new System.Drawing.Size(403, 110);
            this.textOut.TabIndex = 8;
            // 
            // enterDotFirstBtn
            // 
            this.enterDotFirstBtn.Location = new System.Drawing.Point(32, 567);
            this.enterDotFirstBtn.Name = "enterDotFirstBtn";
            this.enterDotFirstBtn.Size = new System.Drawing.Size(137, 29);
            this.enterDotFirstBtn.TabIndex = 9;
            this.enterDotFirstBtn.Text = "Ввести точку";
            this.enterDotFirstBtn.UseVisualStyleBackColor = true;
            this.enterDotFirstBtn.Click += new System.EventHandler(this.EnterDotFirstBtn_Click);
            // 
            // xEnterFirst
            // 
            this.xEnterFirst.Location = new System.Drawing.Point(32, 539);
            this.xEnterFirst.Name = "xEnterFirst";
            this.xEnterFirst.Size = new System.Drawing.Size(58, 20);
            this.xEnterFirst.TabIndex = 10;
            // 
            // yEnterFirst
            // 
            this.yEnterFirst.Location = new System.Drawing.Point(121, 539);
            this.yEnterFirst.Name = "yEnterFirst";
            this.yEnterFirst.Size = new System.Drawing.Size(62, 20);
            this.yEnterFirst.TabIndex = 11;
            // 
            // deleteDotFirstBtn
            // 
            this.deleteDotFirstBtn.Location = new System.Drawing.Point(12, 490);
            this.deleteDotFirstBtn.Name = "deleteDotFirstBtn";
            this.deleteDotFirstBtn.Size = new System.Drawing.Size(129, 29);
            this.deleteDotFirstBtn.TabIndex = 12;
            this.deleteDotFirstBtn.Text = "Удалить точку :";
            this.deleteDotFirstBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDotFirstBtn.UseVisualStyleBackColor = true;
            this.deleteDotFirstBtn.Click += new System.EventHandler(this.DeleteDotFirstBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(883, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(796, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "X:";
            // 
            // yEnterSecond
            // 
            this.yEnterSecond.Location = new System.Drawing.Point(908, 539);
            this.yEnterSecond.Name = "yEnterSecond";
            this.yEnterSecond.Size = new System.Drawing.Size(62, 20);
            this.yEnterSecond.TabIndex = 18;
            // 
            // xEnterSecond
            // 
            this.xEnterSecond.Location = new System.Drawing.Point(819, 539);
            this.xEnterSecond.Name = "xEnterSecond";
            this.xEnterSecond.Size = new System.Drawing.Size(58, 20);
            this.xEnterSecond.TabIndex = 17;
            // 
            // enterDotSecondBtn
            // 
            this.enterDotSecondBtn.Location = new System.Drawing.Point(819, 567);
            this.enterDotSecondBtn.Name = "enterDotSecondBtn";
            this.enterDotSecondBtn.Size = new System.Drawing.Size(137, 29);
            this.enterDotSecondBtn.TabIndex = 16;
            this.enterDotSecondBtn.Text = "Ввести точку";
            this.enterDotSecondBtn.UseVisualStyleBackColor = true;
            this.enterDotSecondBtn.Click += new System.EventHandler(this.EnterDotSecondBtn_Click);
            // 
            // clearAllSecondBtn
            // 
            this.clearAllSecondBtn.Location = new System.Drawing.Point(799, 444);
            this.clearAllSecondBtn.Name = "clearAllSecondBtn";
            this.clearAllSecondBtn.Size = new System.Drawing.Size(171, 36);
            this.clearAllSecondBtn.TabIndex = 15;
            this.clearAllSecondBtn.Text = "Очистить все";
            this.clearAllSecondBtn.UseVisualStyleBackColor = true;
            this.clearAllSecondBtn.Click += new System.EventHandler(this.ClearAllSecondBtn_Click);
            // 
            // leftDotDelNumber
            // 
            this.leftDotDelNumber.Location = new System.Drawing.Point(147, 493);
            this.leftDotDelNumber.Name = "leftDotDelNumber";
            this.leftDotDelNumber.Size = new System.Drawing.Size(36, 20);
            this.leftDotDelNumber.TabIndex = 22;
            // 
            // rightDotDelNumber
            // 
            this.rightDotDelNumber.Location = new System.Drawing.Point(934, 496);
            this.rightDotDelNumber.Name = "rightDotDelNumber";
            this.rightDotDelNumber.Size = new System.Drawing.Size(36, 20);
            this.rightDotDelNumber.TabIndex = 24;
            // 
            // deleteDotSecondBtn
            // 
            this.deleteDotSecondBtn.Location = new System.Drawing.Point(799, 493);
            this.deleteDotSecondBtn.Name = "deleteDotSecondBtn";
            this.deleteDotSecondBtn.Size = new System.Drawing.Size(129, 29);
            this.deleteDotSecondBtn.TabIndex = 23;
            this.deleteDotSecondBtn.Text = "Удалить точку :";
            this.deleteDotSecondBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDotSecondBtn.UseVisualStyleBackColor = true;
            this.deleteDotSecondBtn.Click += new System.EventHandler(this.DeleteDotSecondBtn_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(982, 606);
            this.Controls.Add(this.rightDotDelNumber);
            this.Controls.Add(this.deleteDotSecondBtn);
            this.Controls.Add(this.leftDotDelNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yEnterSecond);
            this.Controls.Add(this.xEnterSecond);
            this.Controls.Add(this.enterDotSecondBtn);
            this.Controls.Add(this.clearAllSecondBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteDotFirstBtn);
            this.Controls.Add(this.yEnterFirst);
            this.Controls.Add(this.xEnterFirst);
            this.Controls.Add(this.enterDotFirstBtn);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.clearAllFirstBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button clearAllFirstBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Button enterDotFirstBtn;
        private System.Windows.Forms.TextBox xEnterFirst;
        private System.Windows.Forms.TextBox yEnterFirst;
        private System.Windows.Forms.Button deleteDotFirstBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yEnterSecond;
        private System.Windows.Forms.TextBox xEnterSecond;
        private System.Windows.Forms.Button enterDotSecondBtn;
        private System.Windows.Forms.Button clearAllSecondBtn;
        private System.Windows.Forms.TextBox leftDotDelNumber;
        private System.Windows.Forms.TextBox rightDotDelNumber;
        private System.Windows.Forms.Button deleteDotSecondBtn;
    }
}