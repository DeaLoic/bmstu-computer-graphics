namespace lab_10
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
            this.radioButtonEnterEllipsoid = new System.Windows.Forms.RadioButton();
            this.radioButtonEnterHyperbOne = new System.Windows.Forms.RadioButton();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonEnterHyperbParab = new System.Windows.Forms.RadioButton();
            this.radioButtonEnterHyperbTwo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.textBoxStartZ = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStepZ = new System.Windows.Forms.TextBox();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEndZ = new System.Windows.Forms.TextBox();
            this.textBoxEndX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textBoxRotateY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRotateZ = new System.Windows.Forms.TextBox();
            this.textBoxRotateX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupColor.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.colorButton.Location = new System.Drawing.Point(63, 19);
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
            this.groupColor.Controls.Add(this.colorButton);
            this.groupColor.Location = new System.Drawing.Point(631, 70);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(185, 58);
            this.groupColor.TabIndex = 53;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Выбор цвета";
            // 
            // radioButtonEnterEllipsoid
            // 
            this.radioButtonEnterEllipsoid.AutoSize = true;
            this.radioButtonEnterEllipsoid.Checked = true;
            this.radioButtonEnterEllipsoid.Location = new System.Drawing.Point(10, 19);
            this.radioButtonEnterEllipsoid.Name = "radioButtonEnterEllipsoid";
            this.radioButtonEnterEllipsoid.Size = new System.Drawing.Size(80, 17);
            this.radioButtonEnterEllipsoid.TabIndex = 54;
            this.radioButtonEnterEllipsoid.TabStop = true;
            this.radioButtonEnterEllipsoid.Text = "Эллипсоид";
            this.radioButtonEnterEllipsoid.UseVisualStyleBackColor = true;
            this.radioButtonEnterEllipsoid.CheckedChanged += new System.EventHandler(this.radioButtonEnterEllipsoid_CheckedChanged);
            // 
            // radioButtonEnterHyperbOne
            // 
            this.radioButtonEnterHyperbOne.AutoSize = true;
            this.radioButtonEnterHyperbOne.Location = new System.Drawing.Point(10, 42);
            this.radioButtonEnterHyperbOne.Name = "radioButtonEnterHyperbOne";
            this.radioButtonEnterHyperbOne.Size = new System.Drawing.Size(174, 17);
            this.radioButtonEnterHyperbOne.TabIndex = 55;
            this.radioButtonEnterHyperbOne.Text = "Однополостный гиперболоид";
            this.radioButtonEnterHyperbOne.UseVisualStyleBackColor = true;
            this.radioButtonEnterHyperbOne.CheckedChanged += new System.EventHandler(this.radioButtonEnterHyperbOne_CheckedChanged);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonEnterHyperbParab);
            this.groupBoxType.Controls.Add(this.radioButtonEnterHyperbTwo);
            this.groupBoxType.Controls.Add(this.radioButtonEnterEllipsoid);
            this.groupBoxType.Controls.Add(this.radioButtonEnterHyperbOne);
            this.groupBoxType.Location = new System.Drawing.Point(631, 134);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(185, 120);
            this.groupBoxType.TabIndex = 56;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Ввод";
            // 
            // radioButtonEnterHyperbParab
            // 
            this.radioButtonEnterHyperbParab.AutoSize = true;
            this.radioButtonEnterHyperbParab.Location = new System.Drawing.Point(10, 88);
            this.radioButtonEnterHyperbParab.Name = "radioButtonEnterHyperbParab";
            this.radioButtonEnterHyperbParab.Size = new System.Drawing.Size(177, 17);
            this.radioButtonEnterHyperbParab.TabIndex = 57;
            this.radioButtonEnterHyperbParab.Text = "Гиперболический параболоид";
            this.radioButtonEnterHyperbParab.UseVisualStyleBackColor = true;
            this.radioButtonEnterHyperbParab.CheckedChanged += new System.EventHandler(this.radioButtonEnterHyperbParab_CheckedChanged);
            // 
            // radioButtonEnterHyperbTwo
            // 
            this.radioButtonEnterHyperbTwo.AutoSize = true;
            this.radioButtonEnterHyperbTwo.Location = new System.Drawing.Point(10, 65);
            this.radioButtonEnterHyperbTwo.Name = "radioButtonEnterHyperbTwo";
            this.radioButtonEnterHyperbTwo.Size = new System.Drawing.Size(168, 17);
            this.radioButtonEnterHyperbTwo.TabIndex = 56;
            this.radioButtonEnterHyperbTwo.Text = "Двуполостный гиперболоид";
            this.radioButtonEnterHyperbTwo.UseVisualStyleBackColor = true;
            this.radioButtonEnterHyperbTwo.CheckedChanged += new System.EventHandler(this.radioButtonEnterHyperbTwo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Z";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(28, 19);
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(47, 20);
            this.textBoxStartX.TabIndex = 65;
            this.textBoxStartX.Text = "1";
            // 
            // textBoxStartZ
            // 
            this.textBoxStartZ.Location = new System.Drawing.Point(123, 19);
            this.textBoxStartZ.Name = "textBoxStartZ";
            this.textBoxStartZ.Size = new System.Drawing.Size(47, 20);
            this.textBoxStartZ.TabIndex = 66;
            this.textBoxStartZ.Text = "1";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(10, 99);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(159, 35);
            this.buttonDraw.TabIndex = 67;
            this.buttonDraw.Text = "Отрисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxStepZ);
            this.groupBox1.Controls.Add(this.textBoxStepX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxEndZ);
            this.groupBox1.Controls.Add(this.textBoxEndX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonDraw);
            this.groupBox1.Controls.Add(this.textBoxStartZ);
            this.groupBox1.Controls.Add(this.textBoxStartX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(631, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 140);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод шага";
            // 
            // textBoxStepZ
            // 
            this.textBoxStepZ.Location = new System.Drawing.Point(129, 68);
            this.textBoxStepZ.Name = "textBoxStepZ";
            this.textBoxStepZ.Size = new System.Drawing.Size(47, 20);
            this.textBoxStepZ.TabIndex = 75;
            this.textBoxStepZ.Text = "0.1";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(34, 68);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(47, 20);
            this.textBoxStepX.TabIndex = 74;
            this.textBoxStepX.Text = "0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "ZStep";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Xstep";
            // 
            // textBoxEndZ
            // 
            this.textBoxEndZ.Location = new System.Drawing.Point(124, 45);
            this.textBoxEndZ.Name = "textBoxEndZ";
            this.textBoxEndZ.Size = new System.Drawing.Size(47, 20);
            this.textBoxEndZ.TabIndex = 71;
            this.textBoxEndZ.Text = "-1";
            // 
            // textBoxEndX
            // 
            this.textBoxEndX.Location = new System.Drawing.Point(29, 45);
            this.textBoxEndX.Name = "textBoxEndX";
            this.textBoxEndX.Size = new System.Drawing.Size(47, 20);
            this.textBoxEndX.TabIndex = 70;
            this.textBoxEndX.Text = "-1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "ZEnd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Xend";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRotate);
            this.groupBox2.Controls.Add(this.textBoxRotateY);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxRotateZ);
            this.groupBox2.Controls.Add(this.textBoxRotateX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(632, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 155);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поворот";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(12, 104);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(159, 35);
            this.buttonRotate.TabIndex = 68;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textBoxRotateY
            // 
            this.textBoxRotateY.Location = new System.Drawing.Point(28, 45);
            this.textBoxRotateY.Name = "textBoxRotateY";
            this.textBoxRotateY.Size = new System.Drawing.Size(47, 20);
            this.textBoxRotateY.TabIndex = 73;
            this.textBoxRotateY.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Y";
            // 
            // textBoxRotateZ
            // 
            this.textBoxRotateZ.Location = new System.Drawing.Point(28, 69);
            this.textBoxRotateZ.Name = "textBoxRotateZ";
            this.textBoxRotateZ.Size = new System.Drawing.Size(47, 20);
            this.textBoxRotateZ.TabIndex = 71;
            this.textBoxRotateZ.Text = "100";
            // 
            // textBoxRotateX
            // 
            this.textBoxRotateX.Location = new System.Drawing.Point(28, 19);
            this.textBoxRotateX.Name = "textBoxRotateX";
            this.textBoxRotateX.Size = new System.Drawing.Size(47, 20);
            this.textBoxRotateX.TabIndex = 70;
            this.textBoxRotateX.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Z";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.mainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 10. Хетагуров Павел";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupColor.ResumeLayout(false);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.RadioButton radioButtonEnterEllipsoid;
        private System.Windows.Forms.RadioButton radioButtonEnterHyperbOne;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.TextBox textBoxStartZ;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEnterHyperbParab;
        private System.Windows.Forms.RadioButton radioButtonEnterHyperbTwo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.TextBox textBoxRotateY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRotateZ;
        private System.Windows.Forms.TextBox textBoxRotateX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStepZ;
        private System.Windows.Forms.TextBox textBoxStepX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEndZ;
        private System.Windows.Forms.TextBox textBoxEndX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

