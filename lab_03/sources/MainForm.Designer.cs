namespace lab_03
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
            this.groupSimpleDraw = new System.Windows.Forms.GroupBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.backColorSimpleLabel = new System.Windows.Forms.Label();
            this.choosedDrawSimpleLabel = new System.Windows.Forms.Label();
            this.choosedColorSimpleLabel = new System.Windows.Forms.Label();
            this.methodNameSimple = new System.Windows.Forms.Label();
            this.DDABackSimpleBtn = new System.Windows.Forms.Button();
            this.DDAColorSimpleBtn = new System.Windows.Forms.Button();
            this.DDAColorButton = new System.Windows.Forms.Button();
            this.standartBackSimpleButton = new System.Windows.Forms.Button();
            this.standartColorSimpleButton = new System.Windows.Forms.Button();
            this.vuBackSimpleButton = new System.Windows.Forms.Button();
            this.vuColorSimpleButton = new System.Windows.Forms.Button();
            this.brazenheimFlatBackSimpleButton = new System.Windows.Forms.Button();
            this.brazenheimFlatColorSimpleButton = new System.Windows.Forms.Button();
            this.brazenheimIntBackSimpleButton = new System.Windows.Forms.Button();
            this.brazenheimIntColorSimpleButton = new System.Windows.Forms.Button();
            this.brazenheimBackSimpleButton = new System.Windows.Forms.Button();
            this.brazenheimColorSimpleButton = new System.Windows.Forms.Button();
            this.standartColorButton = new System.Windows.Forms.Button();
            this.vuColorButton = new System.Windows.Forms.Button();
            this.brezenheimFlatColorButton = new System.Windows.Forms.Button();
            this.brezenheimIntColorButton = new System.Windows.Forms.Button();
            this.brezenheimColorButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BrezenhaimSimpleLabel = new System.Windows.Forms.Label();
            this.labelDigitAnalyzator = new System.Windows.Forms.Label();
            this.labelYFirst = new System.Windows.Forms.Label();
            this.labelXSecond = new System.Windows.Forms.Label();
            this.labelYSecond = new System.Windows.Forms.Label();
            this.labelXFirst = new System.Windows.Forms.Label();
            this.groupSun = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupSimpleDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.Cornsilk;
            this.mainCanvas.Location = new System.Drawing.Point(4, 6);
            this.mainCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(615, 551);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Location = new System.Drawing.Point(11, 559);
            this.coordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(31, 13);
            this.coordsLabel.TabIndex = 7;
            this.coordsLabel.Text = "(0, 0)";
            // 
            // groupSimpleDraw
            // 
            this.groupSimpleDraw.Controls.Add(this.textBoxY1);
            this.groupSimpleDraw.Controls.Add(this.textBoxX1);
            this.groupSimpleDraw.Controls.Add(this.textBoxY0);
            this.groupSimpleDraw.Controls.Add(this.textBoxX0);
            this.groupSimpleDraw.Controls.Add(this.backColorSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.choosedDrawSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.choosedColorSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.methodNameSimple);
            this.groupSimpleDraw.Controls.Add(this.DDABackSimpleBtn);
            this.groupSimpleDraw.Controls.Add(this.DDAColorSimpleBtn);
            this.groupSimpleDraw.Controls.Add(this.DDAColorButton);
            this.groupSimpleDraw.Controls.Add(this.standartBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.standartColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.vuBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.vuColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.brazenheimFlatBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.brazenheimFlatColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.brazenheimIntBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.brazenheimIntColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.brazenheimBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.brazenheimColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.standartColorButton);
            this.groupSimpleDraw.Controls.Add(this.vuColorButton);
            this.groupSimpleDraw.Controls.Add(this.brezenheimFlatColorButton);
            this.groupSimpleDraw.Controls.Add(this.brezenheimIntColorButton);
            this.groupSimpleDraw.Controls.Add(this.brezenheimColorButton);
            this.groupSimpleDraw.Controls.Add(this.label5);
            this.groupSimpleDraw.Controls.Add(this.label4);
            this.groupSimpleDraw.Controls.Add(this.label3);
            this.groupSimpleDraw.Controls.Add(this.label2);
            this.groupSimpleDraw.Controls.Add(this.BrezenhaimSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.labelDigitAnalyzator);
            this.groupSimpleDraw.Controls.Add(this.labelYFirst);
            this.groupSimpleDraw.Controls.Add(this.labelXSecond);
            this.groupSimpleDraw.Controls.Add(this.labelYSecond);
            this.groupSimpleDraw.Controls.Add(this.labelXFirst);
            this.groupSimpleDraw.Location = new System.Drawing.Point(635, 12);
            this.groupSimpleDraw.Name = "groupSimpleDraw";
            this.groupSimpleDraw.Size = new System.Drawing.Size(332, 267);
            this.groupSimpleDraw.TabIndex = 8;
            this.groupSimpleDraw.TabStop = false;
            this.groupSimpleDraw.Text = "Отрезок";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(166, 35);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(74, 20);
            this.textBoxY1.TabIndex = 45;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(166, 13);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(74, 20);
            this.textBoxX1.TabIndex = 44;
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(32, 35);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(74, 20);
            this.textBoxY0.TabIndex = 43;
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(32, 13);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(74, 20);
            this.textBoxX0.TabIndex = 42;
            // 
            // backColorSimpleLabel
            // 
            this.backColorSimpleLabel.Location = new System.Drawing.Point(258, 55);
            this.backColorSimpleLabel.Name = "backColorSimpleLabel";
            this.backColorSimpleLabel.Size = new System.Drawing.Size(56, 27);
            this.backColorSimpleLabel.TabIndex = 41;
            this.backColorSimpleLabel.Text = "Рисовать фоновым";
            // 
            // choosedDrawSimpleLabel
            // 
            this.choosedDrawSimpleLabel.Location = new System.Drawing.Point(206, 55);
            this.choosedDrawSimpleLabel.Name = "choosedDrawSimpleLabel";
            this.choosedDrawSimpleLabel.Size = new System.Drawing.Size(55, 26);
            this.choosedDrawSimpleLabel.TabIndex = 40;
            this.choosedDrawSimpleLabel.Text = "Рисовать цветом";
            this.choosedDrawSimpleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choosedColorSimpleLabel
            // 
            this.choosedColorSimpleLabel.AutoSize = true;
            this.choosedColorSimpleLabel.Location = new System.Drawing.Point(111, 60);
            this.choosedColorSimpleLabel.Name = "choosedColorSimpleLabel";
            this.choosedColorSimpleLabel.Size = new System.Drawing.Size(92, 13);
            this.choosedColorSimpleLabel.TabIndex = 39;
            this.choosedColorSimpleLabel.Text = "Выбранный цвет";
            // 
            // methodNameSimple
            // 
            this.methodNameSimple.AutoSize = true;
            this.methodNameSimple.Location = new System.Drawing.Point(9, 61);
            this.methodNameSimple.Name = "methodNameSimple";
            this.methodNameSimple.Size = new System.Drawing.Size(39, 13);
            this.methodNameSimple.TabIndex = 38;
            this.methodNameSimple.Text = "Метод";
            // 
            // DDABackSimpleBtn
            // 
            this.DDABackSimpleBtn.Location = new System.Drawing.Point(261, 85);
            this.DDABackSimpleBtn.Name = "DDABackSimpleBtn";
            this.DDABackSimpleBtn.Size = new System.Drawing.Size(53, 22);
            this.DDABackSimpleBtn.TabIndex = 37;
            this.DDABackSimpleBtn.Text = "Фон";
            this.DDABackSimpleBtn.UseVisualStyleBackColor = true;
            this.DDABackSimpleBtn.Click += new System.EventHandler(this.DDABackSimpleBtn_Click);
            // 
            // DDAColorSimpleBtn
            // 
            this.DDAColorSimpleBtn.Location = new System.Drawing.Point(203, 84);
            this.DDAColorSimpleBtn.Name = "DDAColorSimpleBtn";
            this.DDAColorSimpleBtn.Size = new System.Drawing.Size(53, 23);
            this.DDAColorSimpleBtn.TabIndex = 36;
            this.DDAColorSimpleBtn.Text = "Цвет";
            this.DDAColorSimpleBtn.UseVisualStyleBackColor = true;
            this.DDAColorSimpleBtn.Click += new System.EventHandler(this.DDAColorSimpleBtn_Click);
            // 
            // DDAColorButton
            // 
            this.DDAColorButton.BackColor = System.Drawing.Color.Red;
            this.DDAColorButton.Location = new System.Drawing.Point(158, 85);
            this.DDAColorButton.Name = "DDAColorButton";
            this.DDAColorButton.Size = new System.Drawing.Size(30, 22);
            this.DDAColorButton.TabIndex = 35;
            this.DDAColorButton.UseVisualStyleBackColor = false;
            this.DDAColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartBackSimpleButton
            // 
            this.standartBackSimpleButton.Location = new System.Drawing.Point(261, 235);
            this.standartBackSimpleButton.Name = "standartBackSimpleButton";
            this.standartBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.standartBackSimpleButton.TabIndex = 34;
            this.standartBackSimpleButton.Text = "Фон";
            this.standartBackSimpleButton.UseVisualStyleBackColor = true;
            this.standartBackSimpleButton.Click += new System.EventHandler(this.standartBackSimpleButton_Click);
            // 
            // standartColorSimpleButton
            // 
            this.standartColorSimpleButton.Location = new System.Drawing.Point(202, 235);
            this.standartColorSimpleButton.Name = "standartColorSimpleButton";
            this.standartColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.standartColorSimpleButton.TabIndex = 33;
            this.standartColorSimpleButton.Text = "Цвет";
            this.standartColorSimpleButton.UseVisualStyleBackColor = true;
            this.standartColorSimpleButton.Click += new System.EventHandler(this.standartColorSimpleButton_Click);
            // 
            // vuBackSimpleButton
            // 
            this.vuBackSimpleButton.Location = new System.Drawing.Point(261, 205);
            this.vuBackSimpleButton.Name = "vuBackSimpleButton";
            this.vuBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.vuBackSimpleButton.TabIndex = 32;
            this.vuBackSimpleButton.Text = "Фон";
            this.vuBackSimpleButton.UseVisualStyleBackColor = true;
            this.vuBackSimpleButton.Click += new System.EventHandler(this.vuBackSimpleButton_Click);
            // 
            // vuColorSimpleButton
            // 
            this.vuColorSimpleButton.Location = new System.Drawing.Point(202, 205);
            this.vuColorSimpleButton.Name = "vuColorSimpleButton";
            this.vuColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.vuColorSimpleButton.TabIndex = 31;
            this.vuColorSimpleButton.Text = "Цвет";
            this.vuColorSimpleButton.UseVisualStyleBackColor = true;
            this.vuColorSimpleButton.Click += new System.EventHandler(this.vuColorSimpleButton_Click);
            // 
            // brazenheimFlatBackSimpleButton
            // 
            this.brazenheimFlatBackSimpleButton.Location = new System.Drawing.Point(261, 175);
            this.brazenheimFlatBackSimpleButton.Name = "brazenheimFlatBackSimpleButton";
            this.brazenheimFlatBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.brazenheimFlatBackSimpleButton.TabIndex = 30;
            this.brazenheimFlatBackSimpleButton.Text = "Фон";
            this.brazenheimFlatBackSimpleButton.UseVisualStyleBackColor = true;
            this.brazenheimFlatBackSimpleButton.Click += new System.EventHandler(this.brazenheimFlatBackSimpleButton_Click);
            // 
            // brazenheimFlatColorSimpleButton
            // 
            this.brazenheimFlatColorSimpleButton.Location = new System.Drawing.Point(202, 175);
            this.brazenheimFlatColorSimpleButton.Name = "brazenheimFlatColorSimpleButton";
            this.brazenheimFlatColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.brazenheimFlatColorSimpleButton.TabIndex = 29;
            this.brazenheimFlatColorSimpleButton.Text = "Цвет";
            this.brazenheimFlatColorSimpleButton.UseVisualStyleBackColor = true;
            this.brazenheimFlatColorSimpleButton.Click += new System.EventHandler(this.brazenheimFlatColorSimpleButton_Click);
            // 
            // brazenheimIntBackSimpleButton
            // 
            this.brazenheimIntBackSimpleButton.Location = new System.Drawing.Point(261, 146);
            this.brazenheimIntBackSimpleButton.Name = "brazenheimIntBackSimpleButton";
            this.brazenheimIntBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.brazenheimIntBackSimpleButton.TabIndex = 28;
            this.brazenheimIntBackSimpleButton.Text = "Фон";
            this.brazenheimIntBackSimpleButton.UseVisualStyleBackColor = true;
            this.brazenheimIntBackSimpleButton.Click += new System.EventHandler(this.brazenheimIntBackSimpleButton_Click);
            // 
            // brazenheimIntColorSimpleButton
            // 
            this.brazenheimIntColorSimpleButton.Location = new System.Drawing.Point(202, 146);
            this.brazenheimIntColorSimpleButton.Name = "brazenheimIntColorSimpleButton";
            this.brazenheimIntColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.brazenheimIntColorSimpleButton.TabIndex = 27;
            this.brazenheimIntColorSimpleButton.Text = "Цвет";
            this.brazenheimIntColorSimpleButton.UseVisualStyleBackColor = true;
            this.brazenheimIntColorSimpleButton.Click += new System.EventHandler(this.brazenheimIntColorSimpleButton_Click);
            // 
            // brazenheimBackSimpleButton
            // 
            this.brazenheimBackSimpleButton.Location = new System.Drawing.Point(261, 116);
            this.brazenheimBackSimpleButton.Name = "brazenheimBackSimpleButton";
            this.brazenheimBackSimpleButton.Size = new System.Drawing.Size(53, 22);
            this.brazenheimBackSimpleButton.TabIndex = 26;
            this.brazenheimBackSimpleButton.Text = "Фон";
            this.brazenheimBackSimpleButton.UseVisualStyleBackColor = true;
            this.brazenheimBackSimpleButton.Click += new System.EventHandler(this.brazenheimBackSimpleButton_Click);
            // 
            // brazenheimColorSimpleButton
            // 
            this.brazenheimColorSimpleButton.Location = new System.Drawing.Point(202, 115);
            this.brazenheimColorSimpleButton.Name = "brazenheimColorSimpleButton";
            this.brazenheimColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.brazenheimColorSimpleButton.TabIndex = 25;
            this.brazenheimColorSimpleButton.Text = "Цвет";
            this.brazenheimColorSimpleButton.UseVisualStyleBackColor = true;
            this.brazenheimColorSimpleButton.Click += new System.EventHandler(this.brazenheimColorSimpleButton_Click);
            // 
            // standartColorButton
            // 
            this.standartColorButton.BackColor = System.Drawing.Color.Red;
            this.standartColorButton.Location = new System.Drawing.Point(157, 235);
            this.standartColorButton.Name = "standartColorButton";
            this.standartColorButton.Size = new System.Drawing.Size(30, 23);
            this.standartColorButton.TabIndex = 24;
            this.standartColorButton.UseVisualStyleBackColor = false;
            this.standartColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // vuColorButton
            // 
            this.vuColorButton.BackColor = System.Drawing.Color.Red;
            this.vuColorButton.Location = new System.Drawing.Point(157, 205);
            this.vuColorButton.Name = "vuColorButton";
            this.vuColorButton.Size = new System.Drawing.Size(30, 23);
            this.vuColorButton.TabIndex = 23;
            this.vuColorButton.UseVisualStyleBackColor = false;
            this.vuColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // brezenheimFlatColorButton
            // 
            this.brezenheimFlatColorButton.BackColor = System.Drawing.Color.Red;
            this.brezenheimFlatColorButton.Location = new System.Drawing.Point(157, 175);
            this.brezenheimFlatColorButton.Name = "brezenheimFlatColorButton";
            this.brezenheimFlatColorButton.Size = new System.Drawing.Size(30, 23);
            this.brezenheimFlatColorButton.TabIndex = 22;
            this.brezenheimFlatColorButton.UseVisualStyleBackColor = false;
            this.brezenheimFlatColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // brezenheimIntColorButton
            // 
            this.brezenheimIntColorButton.BackColor = System.Drawing.Color.Red;
            this.brezenheimIntColorButton.Location = new System.Drawing.Point(157, 146);
            this.brezenheimIntColorButton.Name = "brezenheimIntColorButton";
            this.brezenheimIntColorButton.Size = new System.Drawing.Size(30, 23);
            this.brezenheimIntColorButton.TabIndex = 21;
            this.brezenheimIntColorButton.UseVisualStyleBackColor = false;
            this.brezenheimIntColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // brezenheimColorButton
            // 
            this.brezenheimColorButton.BackColor = System.Drawing.Color.Red;
            this.brezenheimColorButton.Location = new System.Drawing.Point(157, 116);
            this.brezenheimColorButton.Name = "brezenheimColorButton";
            this.brezenheimColorButton.Size = new System.Drawing.Size(30, 22);
            this.brezenheimColorButton.TabIndex = 20;
            this.brezenheimColorButton.UseVisualStyleBackColor = false;
            this.brezenheimColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Библиотечный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ву";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Брезенхейм с устранением";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Брезенхейм целочисленный";
            // 
            // BrezenhaimSimpleLabel
            // 
            this.BrezenhaimSimpleLabel.AutoSize = true;
            this.BrezenhaimSimpleLabel.Location = new System.Drawing.Point(9, 116);
            this.BrezenhaimSimpleLabel.Name = "BrezenhaimSimpleLabel";
            this.BrezenhaimSimpleLabel.Size = new System.Drawing.Size(69, 13);
            this.BrezenhaimSimpleLabel.TabIndex = 15;
            this.BrezenhaimSimpleLabel.Text = "Брезенхейм";
            // 
            // labelDigitAnalyzator
            // 
            this.labelDigitAnalyzator.AutoSize = true;
            this.labelDigitAnalyzator.Location = new System.Drawing.Point(9, 86);
            this.labelDigitAnalyzator.Name = "labelDigitAnalyzator";
            this.labelDigitAnalyzator.Size = new System.Drawing.Size(31, 13);
            this.labelDigitAnalyzator.TabIndex = 14;
            this.labelDigitAnalyzator.Text = "ЦДА";
            // 
            // labelYFirst
            // 
            this.labelYFirst.AutoSize = true;
            this.labelYFirst.Location = new System.Drawing.Point(6, 38);
            this.labelYFirst.Name = "labelYFirst";
            this.labelYFirst.Size = new System.Drawing.Size(20, 13);
            this.labelYFirst.TabIndex = 13;
            this.labelYFirst.Text = "Y0";
            // 
            // labelXSecond
            // 
            this.labelXSecond.AutoSize = true;
            this.labelXSecond.Location = new System.Drawing.Point(140, 16);
            this.labelXSecond.Name = "labelXSecond";
            this.labelXSecond.Size = new System.Drawing.Size(20, 13);
            this.labelXSecond.TabIndex = 12;
            this.labelXSecond.Text = "X1";
            // 
            // labelYSecond
            // 
            this.labelYSecond.AutoSize = true;
            this.labelYSecond.Location = new System.Drawing.Point(140, 38);
            this.labelYSecond.Name = "labelYSecond";
            this.labelYSecond.Size = new System.Drawing.Size(20, 13);
            this.labelYSecond.TabIndex = 11;
            this.labelYSecond.Text = "Y1";
            // 
            // labelXFirst
            // 
            this.labelXFirst.AutoSize = true;
            this.labelXFirst.Location = new System.Drawing.Point(6, 16);
            this.labelXFirst.Name = "labelXFirst";
            this.labelXFirst.Size = new System.Drawing.Size(20, 13);
            this.labelXFirst.TabIndex = 10;
            this.labelXFirst.Text = "X0";
            // 
            // groupSun
            // 
            this.groupSun.Location = new System.Drawing.Point(635, 290);
            this.groupSun.Name = "groupSun";
            this.groupSun.Size = new System.Drawing.Size(332, 267);
            this.groupSun.TabIndex = 9;
            this.groupSun.TabStop = false;
            this.groupSun.Text = "groupSimpleDraw";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 577);
            this.Controls.Add(this.groupSun);
            this.Controls.Add(this.groupSimpleDraw);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.mainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 2";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupSimpleDraw.ResumeLayout(false);
            this.groupSimpleDraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.GroupBox groupSimpleDraw;
        private System.Windows.Forms.GroupBox groupSun;
        private System.Windows.Forms.Label backColorSimpleLabel;
        private System.Windows.Forms.Label choosedDrawSimpleLabel;
        private System.Windows.Forms.Label choosedColorSimpleLabel;
        private System.Windows.Forms.Label methodNameSimple;
        private System.Windows.Forms.Button DDABackSimpleBtn;
        private System.Windows.Forms.Button DDAColorSimpleBtn;
        private System.Windows.Forms.Button DDAColorButton;
        private System.Windows.Forms.Button standartBackSimpleButton;
        private System.Windows.Forms.Button standartColorSimpleButton;
        private System.Windows.Forms.Button vuBackSimpleButton;
        private System.Windows.Forms.Button vuColorSimpleButton;
        private System.Windows.Forms.Button brazenheimFlatBackSimpleButton;
        private System.Windows.Forms.Button brazenheimFlatColorSimpleButton;
        private System.Windows.Forms.Button brazenheimIntBackSimpleButton;
        private System.Windows.Forms.Button brazenheimIntColorSimpleButton;
        private System.Windows.Forms.Button brazenheimBackSimpleButton;
        private System.Windows.Forms.Button brazenheimColorSimpleButton;
        private System.Windows.Forms.Button standartColorButton;
        private System.Windows.Forms.Button vuColorButton;
        private System.Windows.Forms.Button brezenheimFlatColorButton;
        private System.Windows.Forms.Button brezenheimIntColorButton;
        private System.Windows.Forms.Button brezenheimColorButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BrezenhaimSimpleLabel;
        private System.Windows.Forms.Label labelDigitAnalyzator;
        private System.Windows.Forms.Label labelYFirst;
        private System.Windows.Forms.Label labelXSecond;
        private System.Windows.Forms.Label labelYSecond;
        private System.Windows.Forms.Label labelXFirst;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxX0;
    }
}

