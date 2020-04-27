namespace lab_07
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
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.coordsLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonEnterRect = new System.Windows.Forms.RadioButton();
            this.radioButtonEnterLine = new System.Windows.Forms.RadioButton();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.buttonHorizontal = new System.Windows.Forms.Button();
            this.buttonVertical = new System.Windows.Forms.Button();
            this.groupBoxSpecific = new System.Windows.Forms.GroupBox();
            this.buttonLastDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.buttonEnterPeak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupColor.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxSpecific.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.Location = new System.Drawing.Point(11, 6);
            this.mainCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(615, 615);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseClick);
            this.mainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseMove);
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Location = new System.Drawing.Point(11, 623);
            this.coordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(31, 13);
            this.coordsLabel.TabIndex = 7;
            this.coordsLabel.Text = "(0, 0)";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.Location = new System.Drawing.Point(111, 20);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(63, 27);
            this.colorButton.TabIndex = 35;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(631, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 21);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.label6);
            this.groupColor.Controls.Add(this.colorButton);
            this.groupColor.Location = new System.Drawing.Point(631, 70);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(185, 58);
            this.groupColor.TabIndex = 53;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Выбор цвета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Цвет границ: ";
            // 
            // radioButtonEnterRect
            // 
            this.radioButtonEnterRect.AutoSize = true;
            this.radioButtonEnterRect.Checked = true;
            this.radioButtonEnterRect.Location = new System.Drawing.Point(10, 19);
            this.radioButtonEnterRect.Name = "radioButtonEnterRect";
            this.radioButtonEnterRect.Size = new System.Drawing.Size(85, 17);
            this.radioButtonEnterRect.TabIndex = 54;
            this.radioButtonEnterRect.TabStop = true;
            this.radioButtonEnterRect.Text = "Отсекателя";
            this.radioButtonEnterRect.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnterLine
            // 
            this.radioButtonEnterLine.AutoSize = true;
            this.radioButtonEnterLine.Location = new System.Drawing.Point(10, 42);
            this.radioButtonEnterLine.Name = "radioButtonEnterLine";
            this.radioButtonEnterLine.Size = new System.Drawing.Size(68, 17);
            this.radioButtonEnterLine.TabIndex = 55;
            this.radioButtonEnterLine.Text = "Отрезка";
            this.radioButtonEnterLine.UseVisualStyleBackColor = true;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonEnterRect);
            this.groupBoxType.Controls.Add(this.radioButtonEnterLine);
            this.groupBoxType.Location = new System.Drawing.Point(631, 134);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(185, 66);
            this.groupBoxType.TabIndex = 56;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Ввод";
            // 
            // buttonHorizontal
            // 
            this.buttonHorizontal.Location = new System.Drawing.Point(6, 19);
            this.buttonHorizontal.Name = "buttonHorizontal";
            this.buttonHorizontal.Size = new System.Drawing.Size(168, 23);
            this.buttonHorizontal.TabIndex = 59;
            this.buttonHorizontal.Text = "Горизонтальное ребро";
            this.buttonHorizontal.UseVisualStyleBackColor = true;
            this.buttonHorizontal.Click += new System.EventHandler(this.ButtonHorizontal_Click);
            // 
            // buttonVertical
            // 
            this.buttonVertical.Location = new System.Drawing.Point(6, 48);
            this.buttonVertical.Name = "buttonVertical";
            this.buttonVertical.Size = new System.Drawing.Size(168, 23);
            this.buttonVertical.TabIndex = 60;
            this.buttonVertical.Text = "Вертикальное ребро";
            this.buttonVertical.UseVisualStyleBackColor = true;
            this.buttonVertical.Click += new System.EventHandler(this.ButtonVertical_Click);
            // 
            // groupBoxSpecific
            // 
            this.groupBoxSpecific.Controls.Add(this.buttonLastDelete);
            this.groupBoxSpecific.Controls.Add(this.buttonVertical);
            this.groupBoxSpecific.Controls.Add(this.buttonHorizontal);
            this.groupBoxSpecific.Location = new System.Drawing.Point(631, 206);
            this.groupBoxSpecific.Name = "groupBoxSpecific";
            this.groupBoxSpecific.Size = new System.Drawing.Size(185, 109);
            this.groupBoxSpecific.TabIndex = 61;
            this.groupBoxSpecific.TabStop = false;
            this.groupBoxSpecific.Text = "Помощь при вводе";
            // 
            // buttonLastDelete
            // 
            this.buttonLastDelete.Location = new System.Drawing.Point(6, 77);
            this.buttonLastDelete.Name = "buttonLastDelete";
            this.buttonLastDelete.Size = new System.Drawing.Size(168, 21);
            this.buttonLastDelete.TabIndex = 61;
            this.buttonLastDelete.Text = "Удалить последнюю вершину";
            this.buttonLastDelete.UseVisualStyleBackColor = true;
            this.buttonLastDelete.Click += new System.EventHandler(this.ButtonLastDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Y1";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(28, 19);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(47, 20);
            this.textBoxX1.TabIndex = 65;
            this.textBoxX1.Text = "100";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(123, 19);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(47, 20);
            this.textBoxY1.TabIndex = 66;
            this.textBoxY1.Text = "100";
            // 
            // buttonEnterPeak
            // 
            this.buttonEnterPeak.Location = new System.Drawing.Point(12, 54);
            this.buttonEnterPeak.Name = "buttonEnterPeak";
            this.buttonEnterPeak.Size = new System.Drawing.Size(159, 35);
            this.buttonEnterPeak.TabIndex = 67;
            this.buttonEnterPeak.Text = "Ввести";
            this.buttonEnterPeak.UseVisualStyleBackColor = true;
            this.buttonEnterPeak.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEnterPeak);
            this.groupBox1.Controls.Add(this.textBoxY1);
            this.groupBox1.Controls.Add(this.textBoxX1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(634, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 104);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод точки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSpecific);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.mainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 7. Хетагуров Павел";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxSpecific.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonEnterRect;
        private System.Windows.Forms.RadioButton radioButtonEnterLine;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Button buttonHorizontal;
        private System.Windows.Forms.Button buttonVertical;
        private System.Windows.Forms.GroupBox groupBoxSpecific;
        private System.Windows.Forms.Button buttonLastDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Button buttonEnterPeak;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

