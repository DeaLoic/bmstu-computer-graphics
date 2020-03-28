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
            this.bresenhamFlatBackSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamFlatColorSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamIntBackSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamIntColorSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamBackSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamColorSimpleButton = new System.Windows.Forms.Button();
            this.standartColorButton = new System.Windows.Forms.Button();
            this.vuColorButton = new System.Windows.Forms.Button();
            this.bresenhamFlatColorButton = new System.Windows.Forms.Button();
            this.bresenhamIntColorButton = new System.Windows.Forms.Button();
            this.bresenhamColorButton = new System.Windows.Forms.Button();
            this.standartLabel = new System.Windows.Forms.Label();
            this.vuLabel = new System.Windows.Forms.Label();
            this.bresenhamFlatLabel = new System.Windows.Forms.Label();
            this.bresenhamIntLabel = new System.Windows.Forms.Label();
            this.bresenhamSimpleLabel = new System.Windows.Forms.Label();
            this.labelDigitAnalyzator = new System.Windows.Forms.Label();
            this.labelYFirst = new System.Windows.Forms.Label();
            this.labelXSecond = new System.Windows.Forms.Label();
            this.labelYSecond = new System.Windows.Forms.Label();
            this.labelXFirst = new System.Windows.Forms.Label();
            this.groupSun = new System.Windows.Forms.GroupBox();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DDABackSunAct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DDAColorSunAct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DDASunColorButton = new System.Windows.Forms.Button();
            this.bresenhamSunColorButton = new System.Windows.Forms.Button();
            this.standartBackSunAct = new System.Windows.Forms.Button();
            this.bresenhamIntSunColorButton = new System.Windows.Forms.Button();
            this.standartColorSunAct = new System.Windows.Forms.Button();
            this.bresenhamFlatSunColorButton = new System.Windows.Forms.Button();
            this.vuBackSunAct = new System.Windows.Forms.Button();
            this.vuSunColorButton = new System.Windows.Forms.Button();
            this.vuColorSunAct = new System.Windows.Forms.Button();
            this.standartSunColorButton = new System.Windows.Forms.Button();
            this.bresenhamFlatBackSunAct = new System.Windows.Forms.Button();
            this.bresenhamColorSunAct = new System.Windows.Forms.Button();
            this.bresenhamFlatColorSunAct = new System.Windows.Forms.Button();
            this.bresenhamBackSunAct = new System.Windows.Forms.Button();
            this.bresenhamIntBackSunAct = new System.Windows.Forms.Button();
            this.bresenhamIntColorSunAct = new System.Windows.Forms.Button();
            this.clearButtno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupSimpleDraw.SuspendLayout();
            this.groupSun.SuspendLayout();
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
            this.groupSimpleDraw.Controls.Add(this.clearButtno);
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
            this.groupSimpleDraw.Controls.Add(this.bresenhamFlatBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamFlatColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamIntBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamIntColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.standartColorButton);
            this.groupSimpleDraw.Controls.Add(this.vuColorButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamFlatColorButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamIntColorButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamColorButton);
            this.groupSimpleDraw.Controls.Add(this.standartLabel);
            this.groupSimpleDraw.Controls.Add(this.vuLabel);
            this.groupSimpleDraw.Controls.Add(this.bresenhamFlatLabel);
            this.groupSimpleDraw.Controls.Add(this.bresenhamIntLabel);
            this.groupSimpleDraw.Controls.Add(this.bresenhamSimpleLabel);
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
            this.textBoxY1.Text = "200";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(166, 13);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(74, 20);
            this.textBoxX1.TabIndex = 44;
            this.textBoxX1.Text = "200";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(32, 35);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(74, 20);
            this.textBoxY0.TabIndex = 43;
            this.textBoxY0.Text = "100";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(32, 13);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(74, 20);
            this.textBoxX0.TabIndex = 42;
            this.textBoxX0.Text = "100";
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
            // bresenhamFlatBackSimpleButton
            // 
            this.bresenhamFlatBackSimpleButton.Location = new System.Drawing.Point(261, 175);
            this.bresenhamFlatBackSimpleButton.Name = "bresenhamFlatBackSimpleButton";
            this.bresenhamFlatBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.bresenhamFlatBackSimpleButton.TabIndex = 30;
            this.bresenhamFlatBackSimpleButton.Text = "Фон";
            this.bresenhamFlatBackSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamFlatBackSimpleButton.Click += new System.EventHandler(this.bresenhamFlatBackSimpleButton_Click);
            // 
            // bresenhamFlatColorSimpleButton
            // 
            this.bresenhamFlatColorSimpleButton.Location = new System.Drawing.Point(202, 175);
            this.bresenhamFlatColorSimpleButton.Name = "bresenhamFlatColorSimpleButton";
            this.bresenhamFlatColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.bresenhamFlatColorSimpleButton.TabIndex = 29;
            this.bresenhamFlatColorSimpleButton.Text = "Цвет";
            this.bresenhamFlatColorSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamFlatColorSimpleButton.Click += new System.EventHandler(this.bresenhamFlatColorSimpleButton_Click);
            // 
            // bresenhamIntBackSimpleButton
            // 
            this.bresenhamIntBackSimpleButton.Location = new System.Drawing.Point(261, 146);
            this.bresenhamIntBackSimpleButton.Name = "bresenhamIntBackSimpleButton";
            this.bresenhamIntBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.bresenhamIntBackSimpleButton.TabIndex = 28;
            this.bresenhamIntBackSimpleButton.Text = "Фон";
            this.bresenhamIntBackSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamIntBackSimpleButton.Click += new System.EventHandler(this.bresenhamIntBackSimpleButton_Click);
            // 
            // bresenhamIntColorSimpleButton
            // 
            this.bresenhamIntColorSimpleButton.Location = new System.Drawing.Point(202, 146);
            this.bresenhamIntColorSimpleButton.Name = "bresenhamIntColorSimpleButton";
            this.bresenhamIntColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.bresenhamIntColorSimpleButton.TabIndex = 27;
            this.bresenhamIntColorSimpleButton.Text = "Цвет";
            this.bresenhamIntColorSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamIntColorSimpleButton.Click += new System.EventHandler(this.bresenhamIntColorSimpleButton_Click);
            // 
            // bresenhamBackSimpleButton
            // 
            this.bresenhamBackSimpleButton.Location = new System.Drawing.Point(261, 116);
            this.bresenhamBackSimpleButton.Name = "bresenhamBackSimpleButton";
            this.bresenhamBackSimpleButton.Size = new System.Drawing.Size(53, 22);
            this.bresenhamBackSimpleButton.TabIndex = 26;
            this.bresenhamBackSimpleButton.Text = "Фон";
            this.bresenhamBackSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamBackSimpleButton.Click += new System.EventHandler(this.bresenhamBackSimpleButton_Click);
            // 
            // bresenhamColorSimpleButton
            // 
            this.bresenhamColorSimpleButton.Location = new System.Drawing.Point(202, 115);
            this.bresenhamColorSimpleButton.Name = "bresenhamColorSimpleButton";
            this.bresenhamColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.bresenhamColorSimpleButton.TabIndex = 25;
            this.bresenhamColorSimpleButton.Text = "Цвет";
            this.bresenhamColorSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamColorSimpleButton.Click += new System.EventHandler(this.bresenhamColorSimpleButton_Click);
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
            // bresenhamFlatColorButton
            // 
            this.bresenhamFlatColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamFlatColorButton.Location = new System.Drawing.Point(157, 175);
            this.bresenhamFlatColorButton.Name = "bresenhamFlatColorButton";
            this.bresenhamFlatColorButton.Size = new System.Drawing.Size(30, 23);
            this.bresenhamFlatColorButton.TabIndex = 22;
            this.bresenhamFlatColorButton.UseVisualStyleBackColor = false;
            this.bresenhamFlatColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // bresenhamIntColorButton
            // 
            this.bresenhamIntColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamIntColorButton.Location = new System.Drawing.Point(157, 146);
            this.bresenhamIntColorButton.Name = "bresenhamIntColorButton";
            this.bresenhamIntColorButton.Size = new System.Drawing.Size(30, 23);
            this.bresenhamIntColorButton.TabIndex = 21;
            this.bresenhamIntColorButton.UseVisualStyleBackColor = false;
            this.bresenhamIntColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // bresenhamColorButton
            // 
            this.bresenhamColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamColorButton.Location = new System.Drawing.Point(157, 116);
            this.bresenhamColorButton.Name = "bresenhamColorButton";
            this.bresenhamColorButton.Size = new System.Drawing.Size(30, 22);
            this.bresenhamColorButton.TabIndex = 20;
            this.bresenhamColorButton.UseVisualStyleBackColor = false;
            this.bresenhamColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartLabel
            // 
            this.standartLabel.AutoSize = true;
            this.standartLabel.Location = new System.Drawing.Point(9, 236);
            this.standartLabel.Name = "standartLabel";
            this.standartLabel.Size = new System.Drawing.Size(80, 13);
            this.standartLabel.TabIndex = 19;
            this.standartLabel.Text = "Библиотечный";
            // 
            // vuLabel
            // 
            this.vuLabel.AutoSize = true;
            this.vuLabel.Location = new System.Drawing.Point(9, 206);
            this.vuLabel.Name = "vuLabel";
            this.vuLabel.Size = new System.Drawing.Size(19, 13);
            this.vuLabel.TabIndex = 18;
            this.vuLabel.Text = "Ву";
            // 
            // bresenhamFlatLabel
            // 
            this.bresenhamFlatLabel.AutoSize = true;
            this.bresenhamFlatLabel.Location = new System.Drawing.Point(9, 176);
            this.bresenhamFlatLabel.Name = "bresenhamFlatLabel";
            this.bresenhamFlatLabel.Size = new System.Drawing.Size(147, 13);
            this.bresenhamFlatLabel.TabIndex = 17;
            this.bresenhamFlatLabel.Text = "Брезенхейм с устранением";
            // 
            // bresenhamIntLabel
            // 
            this.bresenhamIntLabel.AutoSize = true;
            this.bresenhamIntLabel.Location = new System.Drawing.Point(9, 146);
            this.bresenhamIntLabel.Name = "bresenhamIntLabel";
            this.bresenhamIntLabel.Size = new System.Drawing.Size(151, 13);
            this.bresenhamIntLabel.TabIndex = 16;
            this.bresenhamIntLabel.Text = "Брезенхейм целочисленный";
            // 
            // bresenhamSimpleLabel
            // 
            this.bresenhamSimpleLabel.AutoSize = true;
            this.bresenhamSimpleLabel.Location = new System.Drawing.Point(9, 116);
            this.bresenhamSimpleLabel.Name = "bresenhamSimpleLabel";
            this.bresenhamSimpleLabel.Size = new System.Drawing.Size(69, 13);
            this.bresenhamSimpleLabel.TabIndex = 15;
            this.bresenhamSimpleLabel.Text = "Брезенхейм";
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
            this.groupSun.Controls.Add(this.textBoxLenght);
            this.groupSun.Controls.Add(this.textBoxAngle);
            this.groupSun.Controls.Add(this.label12);
            this.groupSun.Controls.Add(this.label11);
            this.groupSun.Controls.Add(this.label1);
            this.groupSun.Controls.Add(this.label8);
            this.groupSun.Controls.Add(this.label2);
            this.groupSun.Controls.Add(this.label10);
            this.groupSun.Controls.Add(this.label3);
            this.groupSun.Controls.Add(this.label9);
            this.groupSun.Controls.Add(this.label4);
            this.groupSun.Controls.Add(this.label7);
            this.groupSun.Controls.Add(this.DDABackSunAct);
            this.groupSun.Controls.Add(this.label6);
            this.groupSun.Controls.Add(this.DDAColorSunAct);
            this.groupSun.Controls.Add(this.label5);
            this.groupSun.Controls.Add(this.DDASunColorButton);
            this.groupSun.Controls.Add(this.bresenhamSunColorButton);
            this.groupSun.Controls.Add(this.standartBackSunAct);
            this.groupSun.Controls.Add(this.bresenhamIntSunColorButton);
            this.groupSun.Controls.Add(this.standartColorSunAct);
            this.groupSun.Controls.Add(this.bresenhamFlatSunColorButton);
            this.groupSun.Controls.Add(this.vuBackSunAct);
            this.groupSun.Controls.Add(this.vuSunColorButton);
            this.groupSun.Controls.Add(this.vuColorSunAct);
            this.groupSun.Controls.Add(this.standartSunColorButton);
            this.groupSun.Controls.Add(this.bresenhamFlatBackSunAct);
            this.groupSun.Controls.Add(this.bresenhamColorSunAct);
            this.groupSun.Controls.Add(this.bresenhamFlatColorSunAct);
            this.groupSun.Controls.Add(this.bresenhamBackSunAct);
            this.groupSun.Controls.Add(this.bresenhamIntBackSunAct);
            this.groupSun.Controls.Add(this.bresenhamIntColorSunAct);
            this.groupSun.Location = new System.Drawing.Point(635, 290);
            this.groupSun.Name = "groupSun";
            this.groupSun.Size = new System.Drawing.Size(332, 267);
            this.groupSun.TabIndex = 9;
            this.groupSun.TabStop = false;
            this.groupSun.Text = "Cолнышко";
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(210, 18);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(74, 20);
            this.textBoxLenght.TabIndex = 76;
            this.textBoxLenght.Text = "200";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(73, 18);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(74, 20);
            this.textBoxAngle.TabIndex = 46;
            this.textBoxAngle.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Длина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Шаг угла";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(258, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 73;
            this.label1.Text = "Рисовать фоновым";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Брезенхейм целочисленный";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(206, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 72;
            this.label2.Text = "Рисовать цветом";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "ЦДА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Выбранный цвет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Брезенхейм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Метод";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Брезенхейм с устранением";
            // 
            // DDABackSunAct
            // 
            this.DDABackSunAct.Location = new System.Drawing.Point(261, 86);
            this.DDABackSunAct.Name = "DDABackSunAct";
            this.DDABackSunAct.Size = new System.Drawing.Size(53, 22);
            this.DDABackSunAct.TabIndex = 69;
            this.DDABackSunAct.Text = "Фон";
            this.DDABackSunAct.UseVisualStyleBackColor = true;
            this.DDABackSunAct.Click += new System.EventHandler(this.DDABackSunAct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ву";
            // 
            // DDAColorSunAct
            // 
            this.DDAColorSunAct.Location = new System.Drawing.Point(203, 85);
            this.DDAColorSunAct.Name = "DDAColorSunAct";
            this.DDAColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.DDAColorSunAct.TabIndex = 68;
            this.DDAColorSunAct.Text = "Цвет";
            this.DDAColorSunAct.UseVisualStyleBackColor = true;
            this.DDAColorSunAct.Click += new System.EventHandler(this.DDAColorSunAct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Библиотечный";
            // 
            // DDASunColorButton
            // 
            this.DDASunColorButton.BackColor = System.Drawing.Color.Red;
            this.DDASunColorButton.Location = new System.Drawing.Point(158, 86);
            this.DDASunColorButton.Name = "DDASunColorButton";
            this.DDASunColorButton.Size = new System.Drawing.Size(30, 22);
            this.DDASunColorButton.TabIndex = 67;
            this.DDASunColorButton.UseVisualStyleBackColor = false;
            this.DDASunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // bresenhamSunColorButton
            // 
            this.bresenhamSunColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamSunColorButton.Location = new System.Drawing.Point(157, 117);
            this.bresenhamSunColorButton.Name = "bresenhamSunColorButton";
            this.bresenhamSunColorButton.Size = new System.Drawing.Size(30, 22);
            this.bresenhamSunColorButton.TabIndex = 52;
            this.bresenhamSunColorButton.UseVisualStyleBackColor = false;
            this.bresenhamSunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartBackSunAct
            // 
            this.standartBackSunAct.Location = new System.Drawing.Point(261, 236);
            this.standartBackSunAct.Name = "standartBackSunAct";
            this.standartBackSunAct.Size = new System.Drawing.Size(53, 23);
            this.standartBackSunAct.TabIndex = 66;
            this.standartBackSunAct.Text = "Фон";
            this.standartBackSunAct.UseVisualStyleBackColor = true;
            this.standartBackSunAct.Click += new System.EventHandler(this.standartBackSunAct_Click);
            // 
            // bresenhamIntSunColorButton
            // 
            this.bresenhamIntSunColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamIntSunColorButton.Location = new System.Drawing.Point(157, 147);
            this.bresenhamIntSunColorButton.Name = "bresenhamIntSunColorButton";
            this.bresenhamIntSunColorButton.Size = new System.Drawing.Size(30, 23);
            this.bresenhamIntSunColorButton.TabIndex = 53;
            this.bresenhamIntSunColorButton.UseVisualStyleBackColor = false;
            this.bresenhamIntSunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartColorSunAct
            // 
            this.standartColorSunAct.Location = new System.Drawing.Point(202, 236);
            this.standartColorSunAct.Name = "standartColorSunAct";
            this.standartColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.standartColorSunAct.TabIndex = 65;
            this.standartColorSunAct.Text = "Цвет";
            this.standartColorSunAct.UseVisualStyleBackColor = true;
            this.standartColorSunAct.Click += new System.EventHandler(this.standartColorSunAct_Click);
            // 
            // bresenhamFlatSunColorButton
            // 
            this.bresenhamFlatSunColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamFlatSunColorButton.Location = new System.Drawing.Point(157, 176);
            this.bresenhamFlatSunColorButton.Name = "bresenhamFlatSunColorButton";
            this.bresenhamFlatSunColorButton.Size = new System.Drawing.Size(30, 23);
            this.bresenhamFlatSunColorButton.TabIndex = 54;
            this.bresenhamFlatSunColorButton.UseVisualStyleBackColor = false;
            this.bresenhamFlatSunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // vuBackSunAct
            // 
            this.vuBackSunAct.Location = new System.Drawing.Point(261, 206);
            this.vuBackSunAct.Name = "vuBackSunAct";
            this.vuBackSunAct.Size = new System.Drawing.Size(53, 23);
            this.vuBackSunAct.TabIndex = 64;
            this.vuBackSunAct.Text = "Фон";
            this.vuBackSunAct.UseVisualStyleBackColor = true;
            this.vuBackSunAct.Click += new System.EventHandler(this.vuBackSunAct_Click);
            // 
            // vuSunColorButton
            // 
            this.vuSunColorButton.BackColor = System.Drawing.Color.Red;
            this.vuSunColorButton.Location = new System.Drawing.Point(157, 206);
            this.vuSunColorButton.Name = "vuSunColorButton";
            this.vuSunColorButton.Size = new System.Drawing.Size(30, 23);
            this.vuSunColorButton.TabIndex = 55;
            this.vuSunColorButton.UseVisualStyleBackColor = false;
            this.vuSunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // vuColorSunAct
            // 
            this.vuColorSunAct.Location = new System.Drawing.Point(202, 206);
            this.vuColorSunAct.Name = "vuColorSunAct";
            this.vuColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.vuColorSunAct.TabIndex = 63;
            this.vuColorSunAct.Text = "Цвет";
            this.vuColorSunAct.UseVisualStyleBackColor = true;
            this.vuColorSunAct.Click += new System.EventHandler(this.vuColorSunAct_Click);
            // 
            // standartSunColorButton
            // 
            this.standartSunColorButton.BackColor = System.Drawing.Color.Red;
            this.standartSunColorButton.Location = new System.Drawing.Point(157, 236);
            this.standartSunColorButton.Name = "standartSunColorButton";
            this.standartSunColorButton.Size = new System.Drawing.Size(30, 23);
            this.standartSunColorButton.TabIndex = 56;
            this.standartSunColorButton.UseVisualStyleBackColor = false;
            this.standartSunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // bresenhamFlatBackSunAct
            // 
            this.bresenhamFlatBackSunAct.Location = new System.Drawing.Point(261, 176);
            this.bresenhamFlatBackSunAct.Name = "bresenhamFlatBackSunAct";
            this.bresenhamFlatBackSunAct.Size = new System.Drawing.Size(53, 23);
            this.bresenhamFlatBackSunAct.TabIndex = 62;
            this.bresenhamFlatBackSunAct.Text = "Фон";
            this.bresenhamFlatBackSunAct.UseVisualStyleBackColor = true;
            this.bresenhamFlatBackSunAct.Click += new System.EventHandler(this.bresenhamFlatBackSunAct_Click);
            // 
            // bresenhamColorSunAct
            // 
            this.bresenhamColorSunAct.Location = new System.Drawing.Point(202, 116);
            this.bresenhamColorSunAct.Name = "bresenhamColorSunAct";
            this.bresenhamColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.bresenhamColorSunAct.TabIndex = 57;
            this.bresenhamColorSunAct.Text = "Цвет";
            this.bresenhamColorSunAct.UseVisualStyleBackColor = true;
            this.bresenhamColorSunAct.Click += new System.EventHandler(this.bresenhamColorSunAct_Click);
            // 
            // bresenhamFlatColorSunAct
            // 
            this.bresenhamFlatColorSunAct.Location = new System.Drawing.Point(202, 176);
            this.bresenhamFlatColorSunAct.Name = "bresenhamFlatColorSunAct";
            this.bresenhamFlatColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.bresenhamFlatColorSunAct.TabIndex = 61;
            this.bresenhamFlatColorSunAct.Text = "Цвет";
            this.bresenhamFlatColorSunAct.UseVisualStyleBackColor = true;
            this.bresenhamFlatColorSunAct.Click += new System.EventHandler(this.bresenhamFlatColorSunAct_Click);
            // 
            // bresenhamBackSunAct
            // 
            this.bresenhamBackSunAct.Location = new System.Drawing.Point(261, 117);
            this.bresenhamBackSunAct.Name = "bresenhamBackSunAct";
            this.bresenhamBackSunAct.Size = new System.Drawing.Size(53, 22);
            this.bresenhamBackSunAct.TabIndex = 58;
            this.bresenhamBackSunAct.Text = "Фон";
            this.bresenhamBackSunAct.UseVisualStyleBackColor = true;
            this.bresenhamBackSunAct.Click += new System.EventHandler(this.bresenhamBackSunAct_Click);
            // 
            // bresenhamIntBackSunAct
            // 
            this.bresenhamIntBackSunAct.Location = new System.Drawing.Point(261, 147);
            this.bresenhamIntBackSunAct.Name = "bresenhamIntBackSunAct";
            this.bresenhamIntBackSunAct.Size = new System.Drawing.Size(53, 23);
            this.bresenhamIntBackSunAct.TabIndex = 60;
            this.bresenhamIntBackSunAct.Text = "Фон";
            this.bresenhamIntBackSunAct.UseVisualStyleBackColor = true;
            this.bresenhamIntBackSunAct.Click += new System.EventHandler(this.bresenhamIntBackSunAct_Click);
            // 
            // bresenhamIntColorSunAct
            // 
            this.bresenhamIntColorSunAct.Location = new System.Drawing.Point(202, 147);
            this.bresenhamIntColorSunAct.Name = "bresenhamIntColorSunAct";
            this.bresenhamIntColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.bresenhamIntColorSunAct.TabIndex = 59;
            this.bresenhamIntColorSunAct.Text = "Цвет";
            this.bresenhamIntColorSunAct.UseVisualStyleBackColor = true;
            this.bresenhamIntColorSunAct.Click += new System.EventHandler(this.bresenhamIntColorSunAct_Click);
            // 
            // clearButtno
            // 
            this.clearButtno.Location = new System.Drawing.Point(252, 17);
            this.clearButtno.Name = "clearButtno";
            this.clearButtno.Size = new System.Drawing.Size(62, 37);
            this.clearButtno.TabIndex = 46;
            this.clearButtno.Text = "Очистить";
            this.clearButtno.UseVisualStyleBackColor = true;
            this.clearButtno.Click += new System.EventHandler(this.clearButtno_Click);
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
            this.Text = "Лабораторная работа 3. Хетагуров Павел";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupSimpleDraw.ResumeLayout(false);
            this.groupSimpleDraw.PerformLayout();
            this.groupSun.ResumeLayout(false);
            this.groupSun.PerformLayout();
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
        private System.Windows.Forms.Button bresenhamFlatBackSimpleButton;
        private System.Windows.Forms.Button bresenhamFlatColorSimpleButton;
        private System.Windows.Forms.Button bresenhamIntBackSimpleButton;
        private System.Windows.Forms.Button bresenhamIntColorSimpleButton;
        private System.Windows.Forms.Button bresenhamBackSimpleButton;
        private System.Windows.Forms.Button bresenhamColorSimpleButton;
        private System.Windows.Forms.Button standartColorButton;
        private System.Windows.Forms.Button vuColorButton;
        private System.Windows.Forms.Button bresenhamFlatColorButton;
        private System.Windows.Forms.Button bresenhamIntColorButton;
        private System.Windows.Forms.Button bresenhamColorButton;
        private System.Windows.Forms.Label standartLabel;
        private System.Windows.Forms.Label vuLabel;
        private System.Windows.Forms.Label bresenhamFlatLabel;
        private System.Windows.Forms.Label bresenhamIntLabel;
        private System.Windows.Forms.Label bresenhamSimpleLabel;
        private System.Windows.Forms.Label labelDigitAnalyzator;
        private System.Windows.Forms.Label labelYFirst;
        private System.Windows.Forms.Label labelXSecond;
        private System.Windows.Forms.Label labelYSecond;
        private System.Windows.Forms.Label labelXFirst;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DDABackSunAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DDAColorSunAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DDASunColorButton;
        private System.Windows.Forms.Button bresenhamSunColorButton;
        private System.Windows.Forms.Button standartBackSunAct;
        private System.Windows.Forms.Button bresenhamIntSunColorButton;
        private System.Windows.Forms.Button standartColorSunAct;
        private System.Windows.Forms.Button bresenhamFlatSunColorButton;
        private System.Windows.Forms.Button vuBackSunAct;
        private System.Windows.Forms.Button vuSunColorButton;
        private System.Windows.Forms.Button vuColorSunAct;
        private System.Windows.Forms.Button standartSunColorButton;
        private System.Windows.Forms.Button bresenhamFlatBackSunAct;
        private System.Windows.Forms.Button bresenhamColorSunAct;
        private System.Windows.Forms.Button bresenhamFlatColorSunAct;
        private System.Windows.Forms.Button bresenhamBackSunAct;
        private System.Windows.Forms.Button bresenhamIntBackSunAct;
        private System.Windows.Forms.Button bresenhamIntColorSunAct;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clearButtno;
    }
}

