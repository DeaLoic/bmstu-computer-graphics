namespace lab_04
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
            this.textBoxSimpleRadius = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.backColorSimpleLabel = new System.Windows.Forms.Label();
            this.choosedDrawSimpleLabel = new System.Windows.Forms.Label();
            this.choosedColorSimpleLabel = new System.Windows.Forms.Label();
            this.methodNameSimple = new System.Windows.Forms.Label();
            this.canonBackSimpleBtn = new System.Windows.Forms.Button();
            this.canonColorSimpleBtn = new System.Windows.Forms.Button();
            this.canonColorButton = new System.Windows.Forms.Button();
            this.standartBackSimpleButton = new System.Windows.Forms.Button();
            this.standartColorSimpleButton = new System.Windows.Forms.Button();
            this.middleBackSimpleButton = new System.Windows.Forms.Button();
            this.middleColorSimpleButton = new System.Windows.Forms.Button();
            this.paramBackSimpleButton = new System.Windows.Forms.Button();
            this.paramColorSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamBackSimpleButton = new System.Windows.Forms.Button();
            this.bresenhamColorSimpleButton = new System.Windows.Forms.Button();
            this.standartColorButton = new System.Windows.Forms.Button();
            this.middleColorButton = new System.Windows.Forms.Button();
            this.paramColorButton = new System.Windows.Forms.Button();
            this.bresenhamColorButton = new System.Windows.Forms.Button();
            this.standartLabel = new System.Windows.Forms.Label();
            this.middleDotSimpleLabel = new System.Windows.Forms.Label();
            this.bresenhamSimpleLabel = new System.Windows.Forms.Label();
            this.simpleLabelParam = new System.Windows.Forms.Label();
            this.simpleLabelCanonic = new System.Windows.Forms.Label();
            this.labelYFirst = new System.Windows.Forms.Label();
            this.labelSimpleRadius = new System.Windows.Forms.Label();
            this.labelXFirst = new System.Windows.Forms.Label();
            this.clearButtno = new System.Windows.Forms.Button();
            this.groupCompare = new System.Windows.Forms.GroupBox();
            this.panelCompareDraw = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.canonBackSunAct = new System.Windows.Forms.Button();
            this.bresenhamColorCompareAct = new System.Windows.Forms.Button();
            this.bresenhamBackCompareAct = new System.Windows.Forms.Button();
            this.bresenhamCompareColorButton = new System.Windows.Forms.Button();
            this.canonColorSunAct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.canonCompareColorButton = new System.Windows.Forms.Button();
            this.standartBackCompAct = new System.Windows.Forms.Button();
            this.paramColorCompareButton = new System.Windows.Forms.Button();
            this.standartColorCompAct = new System.Windows.Forms.Button();
            this.middleSunColorButton = new System.Windows.Forms.Button();
            this.standartCompColorButton = new System.Windows.Forms.Button();
            this.middleBackSunAct = new System.Windows.Forms.Button();
            this.middleColorSunAct = new System.Windows.Forms.Button();
            this.paramBackCompareAct = new System.Windows.Forms.Button();
            this.paramColorCompareAct = new System.Windows.Forms.Button();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.textBoxEndRadius = new System.Windows.Forms.TextBox();
            this.labelEndRadius = new System.Windows.Forms.Label();
            this.labelCircleCount = new System.Windows.Forms.Label();
            this.textBoxCircleCount = new System.Windows.Forms.TextBox();
            this.textBoxStartRadius = new System.Windows.Forms.TextBox();
            this.labelRadiusStep = new System.Windows.Forms.Label();
            this.textBoxRadiusStep = new System.Windows.Forms.TextBox();
            this.labelRadiusStart = new System.Windows.Forms.Label();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.checkBoxEllipse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupSimpleDraw.SuspendLayout();
            this.groupCompare.SuspendLayout();
            this.panelCompareDraw.SuspendLayout();
            this.panelCircle.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.Cornsilk;
            this.mainCanvas.Location = new System.Drawing.Point(11, 6);
            this.mainCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(615, 615);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
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
            // groupSimpleDraw
            // 
            this.groupSimpleDraw.Controls.Add(this.textBoxSimpleRadius);
            this.groupSimpleDraw.Controls.Add(this.textBoxY0);
            this.groupSimpleDraw.Controls.Add(this.textBoxX0);
            this.groupSimpleDraw.Controls.Add(this.backColorSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.choosedDrawSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.choosedColorSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.methodNameSimple);
            this.groupSimpleDraw.Controls.Add(this.canonBackSimpleBtn);
            this.groupSimpleDraw.Controls.Add(this.canonColorSimpleBtn);
            this.groupSimpleDraw.Controls.Add(this.canonColorButton);
            this.groupSimpleDraw.Controls.Add(this.standartBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.standartColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.middleBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.middleColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.paramBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.paramColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamBackSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamColorSimpleButton);
            this.groupSimpleDraw.Controls.Add(this.standartColorButton);
            this.groupSimpleDraw.Controls.Add(this.middleColorButton);
            this.groupSimpleDraw.Controls.Add(this.paramColorButton);
            this.groupSimpleDraw.Controls.Add(this.bresenhamColorButton);
            this.groupSimpleDraw.Controls.Add(this.standartLabel);
            this.groupSimpleDraw.Controls.Add(this.middleDotSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.bresenhamSimpleLabel);
            this.groupSimpleDraw.Controls.Add(this.simpleLabelParam);
            this.groupSimpleDraw.Controls.Add(this.simpleLabelCanonic);
            this.groupSimpleDraw.Controls.Add(this.labelYFirst);
            this.groupSimpleDraw.Controls.Add(this.labelSimpleRadius);
            this.groupSimpleDraw.Controls.Add(this.labelXFirst);
            this.groupSimpleDraw.Location = new System.Drawing.Point(635, 45);
            this.groupSimpleDraw.Name = "groupSimpleDraw";
            this.groupSimpleDraw.Size = new System.Drawing.Size(332, 238);
            this.groupSimpleDraw.TabIndex = 8;
            this.groupSimpleDraw.TabStop = false;
            this.groupSimpleDraw.Text = "Одиночный";
            // 
            // textBoxSimpleRadius
            // 
            this.textBoxSimpleRadius.Location = new System.Drawing.Point(166, 26);
            this.textBoxSimpleRadius.Name = "textBoxSimpleRadius";
            this.textBoxSimpleRadius.Size = new System.Drawing.Size(74, 20);
            this.textBoxSimpleRadius.TabIndex = 44;
            this.textBoxSimpleRadius.Text = "200";
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
            // canonBackSimpleBtn
            // 
            this.canonBackSimpleBtn.Location = new System.Drawing.Point(261, 85);
            this.canonBackSimpleBtn.Name = "canonBackSimpleBtn";
            this.canonBackSimpleBtn.Size = new System.Drawing.Size(53, 22);
            this.canonBackSimpleBtn.TabIndex = 37;
            this.canonBackSimpleBtn.Text = "Фон";
            this.canonBackSimpleBtn.UseVisualStyleBackColor = true;
            this.canonBackSimpleBtn.Click += new System.EventHandler(this.CanonBackSimpleBtn_Click);
            // 
            // canonColorSimpleBtn
            // 
            this.canonColorSimpleBtn.Location = new System.Drawing.Point(203, 84);
            this.canonColorSimpleBtn.Name = "canonColorSimpleBtn";
            this.canonColorSimpleBtn.Size = new System.Drawing.Size(53, 23);
            this.canonColorSimpleBtn.TabIndex = 36;
            this.canonColorSimpleBtn.Text = "Цвет";
            this.canonColorSimpleBtn.UseVisualStyleBackColor = true;
            this.canonColorSimpleBtn.Click += new System.EventHandler(this.CanonColorSimpleBtn_Click);
            // 
            // canonColorButton
            // 
            this.canonColorButton.BackColor = System.Drawing.Color.Red;
            this.canonColorButton.Location = new System.Drawing.Point(159, 84);
            this.canonColorButton.Name = "canonColorButton";
            this.canonColorButton.Size = new System.Drawing.Size(30, 22);
            this.canonColorButton.TabIndex = 35;
            this.canonColorButton.UseVisualStyleBackColor = false;
            this.canonColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartBackSimpleButton
            // 
            this.standartBackSimpleButton.Location = new System.Drawing.Point(261, 206);
            this.standartBackSimpleButton.Name = "standartBackSimpleButton";
            this.standartBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.standartBackSimpleButton.TabIndex = 34;
            this.standartBackSimpleButton.Text = "Фон";
            this.standartBackSimpleButton.UseVisualStyleBackColor = true;
            this.standartBackSimpleButton.Click += new System.EventHandler(this.StandartBackSimpleButton_Click);
            // 
            // standartColorSimpleButton
            // 
            this.standartColorSimpleButton.Location = new System.Drawing.Point(202, 206);
            this.standartColorSimpleButton.Name = "standartColorSimpleButton";
            this.standartColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.standartColorSimpleButton.TabIndex = 33;
            this.standartColorSimpleButton.Text = "Цвет";
            this.standartColorSimpleButton.UseVisualStyleBackColor = true;
            this.standartColorSimpleButton.Click += new System.EventHandler(this.StandartColorSimpleButton_Click);
            // 
            // middleBackSimpleButton
            // 
            this.middleBackSimpleButton.Location = new System.Drawing.Point(261, 175);
            this.middleBackSimpleButton.Name = "middleBackSimpleButton";
            this.middleBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.middleBackSimpleButton.TabIndex = 30;
            this.middleBackSimpleButton.Text = "Фон";
            this.middleBackSimpleButton.UseVisualStyleBackColor = true;
            this.middleBackSimpleButton.Click += new System.EventHandler(this.MiddleBackSimpleButton_Click);
            // 
            // middleColorSimpleButton
            // 
            this.middleColorSimpleButton.Location = new System.Drawing.Point(202, 175);
            this.middleColorSimpleButton.Name = "middleColorSimpleButton";
            this.middleColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.middleColorSimpleButton.TabIndex = 29;
            this.middleColorSimpleButton.Text = "Цвет";
            this.middleColorSimpleButton.UseVisualStyleBackColor = true;
            this.middleColorSimpleButton.Click += new System.EventHandler(this.MiddleColorSimpleButton_Click);
            // 
            // paramBackSimpleButton
            // 
            this.paramBackSimpleButton.Location = new System.Drawing.Point(260, 141);
            this.paramBackSimpleButton.Name = "paramBackSimpleButton";
            this.paramBackSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.paramBackSimpleButton.TabIndex = 28;
            this.paramBackSimpleButton.Text = "Фон";
            this.paramBackSimpleButton.UseVisualStyleBackColor = true;
            this.paramBackSimpleButton.Click += new System.EventHandler(this.BresenhamBackSimpleButton_Click);
            // 
            // paramColorSimpleButton
            // 
            this.paramColorSimpleButton.Location = new System.Drawing.Point(201, 141);
            this.paramColorSimpleButton.Name = "paramColorSimpleButton";
            this.paramColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.paramColorSimpleButton.TabIndex = 27;
            this.paramColorSimpleButton.Text = "Цвет";
            this.paramColorSimpleButton.UseVisualStyleBackColor = true;
            this.paramColorSimpleButton.Click += new System.EventHandler(this.BresenhamColorSimpleButton_Click);
            // 
            // bresenhamBackSimpleButton
            // 
            this.bresenhamBackSimpleButton.Location = new System.Drawing.Point(259, 111);
            this.bresenhamBackSimpleButton.Name = "bresenhamBackSimpleButton";
            this.bresenhamBackSimpleButton.Size = new System.Drawing.Size(53, 22);
            this.bresenhamBackSimpleButton.TabIndex = 26;
            this.bresenhamBackSimpleButton.Text = "Фон";
            this.bresenhamBackSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamBackSimpleButton.Click += new System.EventHandler(this.ParamBackSimpleButton_Click);
            // 
            // bresenhamColorSimpleButton
            // 
            this.bresenhamColorSimpleButton.Location = new System.Drawing.Point(201, 111);
            this.bresenhamColorSimpleButton.Name = "bresenhamColorSimpleButton";
            this.bresenhamColorSimpleButton.Size = new System.Drawing.Size(53, 23);
            this.bresenhamColorSimpleButton.TabIndex = 25;
            this.bresenhamColorSimpleButton.Text = "Цвет";
            this.bresenhamColorSimpleButton.UseVisualStyleBackColor = true;
            this.bresenhamColorSimpleButton.Click += new System.EventHandler(this.ParamColorSimpleButton_Click);
            // 
            // standartColorButton
            // 
            this.standartColorButton.BackColor = System.Drawing.Color.Red;
            this.standartColorButton.Location = new System.Drawing.Point(159, 206);
            this.standartColorButton.Name = "standartColorButton";
            this.standartColorButton.Size = new System.Drawing.Size(30, 23);
            this.standartColorButton.TabIndex = 24;
            this.standartColorButton.UseVisualStyleBackColor = false;
            this.standartColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // middleColorButton
            // 
            this.middleColorButton.BackColor = System.Drawing.Color.Red;
            this.middleColorButton.Location = new System.Drawing.Point(159, 175);
            this.middleColorButton.Name = "middleColorButton";
            this.middleColorButton.Size = new System.Drawing.Size(30, 23);
            this.middleColorButton.TabIndex = 22;
            this.middleColorButton.UseVisualStyleBackColor = false;
            this.middleColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // paramColorButton
            // 
            this.paramColorButton.BackColor = System.Drawing.Color.Red;
            this.paramColorButton.Location = new System.Drawing.Point(159, 111);
            this.paramColorButton.Name = "paramColorButton";
            this.paramColorButton.Size = new System.Drawing.Size(30, 23);
            this.paramColorButton.TabIndex = 21;
            this.paramColorButton.UseVisualStyleBackColor = false;
            this.paramColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // bresenhamColorButton
            // 
            this.bresenhamColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamColorButton.Location = new System.Drawing.Point(159, 142);
            this.bresenhamColorButton.Name = "bresenhamColorButton";
            this.bresenhamColorButton.Size = new System.Drawing.Size(30, 22);
            this.bresenhamColorButton.TabIndex = 20;
            this.bresenhamColorButton.UseVisualStyleBackColor = false;
            this.bresenhamColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartLabel
            // 
            this.standartLabel.AutoSize = true;
            this.standartLabel.Location = new System.Drawing.Point(9, 207);
            this.standartLabel.Name = "standartLabel";
            this.standartLabel.Size = new System.Drawing.Size(80, 13);
            this.standartLabel.TabIndex = 19;
            this.standartLabel.Text = "Библиотечный";
            // 
            // middleDotSimpleLabel
            // 
            this.middleDotSimpleLabel.AutoSize = true;
            this.middleDotSimpleLabel.Location = new System.Drawing.Point(9, 176);
            this.middleDotSimpleLabel.Name = "middleDotSimpleLabel";
            this.middleDotSimpleLabel.Size = new System.Drawing.Size(132, 13);
            this.middleDotSimpleLabel.TabIndex = 17;
            this.middleDotSimpleLabel.Text = "Алгоритм средней точки";
            // 
            // bresenhamSimpleLabel
            // 
            this.bresenhamSimpleLabel.AutoSize = true;
            this.bresenhamSimpleLabel.Location = new System.Drawing.Point(9, 146);
            this.bresenhamSimpleLabel.Name = "bresenhamSimpleLabel";
            this.bresenhamSimpleLabel.Size = new System.Drawing.Size(121, 13);
            this.bresenhamSimpleLabel.TabIndex = 16;
            this.bresenhamSimpleLabel.Text = "Алгоритм Брезенхема";
            // 
            // simpleLabelParam
            // 
            this.simpleLabelParam.AutoSize = true;
            this.simpleLabelParam.Location = new System.Drawing.Point(9, 116);
            this.simpleLabelParam.Name = "simpleLabelParam";
            this.simpleLabelParam.Size = new System.Drawing.Size(99, 13);
            this.simpleLabelParam.TabIndex = 15;
            this.simpleLabelParam.Text = "Параметрическое";
            // 
            // simpleLabelCanonic
            // 
            this.simpleLabelCanonic.AutoSize = true;
            this.simpleLabelCanonic.Location = new System.Drawing.Point(9, 86);
            this.simpleLabelCanonic.Name = "simpleLabelCanonic";
            this.simpleLabelCanonic.Size = new System.Drawing.Size(135, 13);
            this.simpleLabelCanonic.TabIndex = 14;
            this.simpleLabelCanonic.Text = "Каноническое уравнение";
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
            // labelSimpleRadius
            // 
            this.labelSimpleRadius.AutoSize = true;
            this.labelSimpleRadius.Location = new System.Drawing.Point(117, 29);
            this.labelSimpleRadius.Name = "labelSimpleRadius";
            this.labelSimpleRadius.Size = new System.Drawing.Size(43, 13);
            this.labelSimpleRadius.TabIndex = 12;
            this.labelSimpleRadius.Text = "Радиус";
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
            // clearButtno
            // 
            this.clearButtno.Location = new System.Drawing.Point(887, 18);
            this.clearButtno.Name = "clearButtno";
            this.clearButtno.Size = new System.Drawing.Size(62, 21);
            this.clearButtno.TabIndex = 46;
            this.clearButtno.Text = "Очистить";
            this.clearButtno.UseVisualStyleBackColor = true;
            this.clearButtno.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupCompare
            // 
            this.groupCompare.Controls.Add(this.panelCompareDraw);
            this.groupCompare.Controls.Add(this.panelCircle);
            this.groupCompare.Location = new System.Drawing.Point(635, 289);
            this.groupCompare.Name = "groupCompare";
            this.groupCompare.Size = new System.Drawing.Size(332, 332);
            this.groupCompare.TabIndex = 9;
            this.groupCompare.TabStop = false;
            this.groupCompare.Text = "Cравнение";
            // 
            // panelCompareDraw
            // 
            this.panelCompareDraw.Controls.Add(this.label8);
            this.panelCompareDraw.Controls.Add(this.label10);
            this.panelCompareDraw.Controls.Add(this.label1);
            this.panelCompareDraw.Controls.Add(this.label9);
            this.panelCompareDraw.Controls.Add(this.label2);
            this.panelCompareDraw.Controls.Add(this.label3);
            this.panelCompareDraw.Controls.Add(this.label4);
            this.panelCompareDraw.Controls.Add(this.label7);
            this.panelCompareDraw.Controls.Add(this.canonBackSunAct);
            this.panelCompareDraw.Controls.Add(this.bresenhamColorCompareAct);
            this.panelCompareDraw.Controls.Add(this.bresenhamBackCompareAct);
            this.panelCompareDraw.Controls.Add(this.bresenhamCompareColorButton);
            this.panelCompareDraw.Controls.Add(this.canonColorSunAct);
            this.panelCompareDraw.Controls.Add(this.label5);
            this.panelCompareDraw.Controls.Add(this.canonCompareColorButton);
            this.panelCompareDraw.Controls.Add(this.standartBackCompAct);
            this.panelCompareDraw.Controls.Add(this.paramColorCompareButton);
            this.panelCompareDraw.Controls.Add(this.standartColorCompAct);
            this.panelCompareDraw.Controls.Add(this.middleSunColorButton);
            this.panelCompareDraw.Controls.Add(this.standartCompColorButton);
            this.panelCompareDraw.Controls.Add(this.middleBackSunAct);
            this.panelCompareDraw.Controls.Add(this.middleColorSunAct);
            this.panelCompareDraw.Controls.Add(this.paramBackCompareAct);
            this.panelCompareDraw.Controls.Add(this.paramColorCompareAct);
            this.panelCompareDraw.Location = new System.Drawing.Point(6, 137);
            this.panelCompareDraw.Name = "panelCompareDraw";
            this.panelCompareDraw.Size = new System.Drawing.Size(323, 183);
            this.panelCompareDraw.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Параметрическое";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Каноническое";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(251, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 73;
            this.label1.Text = "Рисовать фоновым";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Брезенхейм";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(199, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 72;
            this.label2.Text = "Рисовать цветом";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Выбранный цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Метод";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Алгоритм средней точки";
            // 
            // canonBackSunAct
            // 
            this.canonBackSunAct.Location = new System.Drawing.Point(253, 35);
            this.canonBackSunAct.Name = "canonBackSunAct";
            this.canonBackSunAct.Size = new System.Drawing.Size(53, 22);
            this.canonBackSunAct.TabIndex = 69;
            this.canonBackSunAct.Text = "Фон";
            this.canonBackSunAct.UseVisualStyleBackColor = true;
            this.canonBackSunAct.Click += new System.EventHandler(this.CanonicalBackSunAct_Click);
            // 
            // bresenhamColorCompareAct
            // 
            this.bresenhamColorCompareAct.Location = new System.Drawing.Point(196, 92);
            this.bresenhamColorCompareAct.Name = "bresenhamColorCompareAct";
            this.bresenhamColorCompareAct.Size = new System.Drawing.Size(52, 23);
            this.bresenhamColorCompareAct.TabIndex = 57;
            this.bresenhamColorCompareAct.Text = "Цвет";
            this.bresenhamColorCompareAct.UseVisualStyleBackColor = true;
            this.bresenhamColorCompareAct.Click += new System.EventHandler(this.BresenhamColorSunAct_Click);
            // 
            // bresenhamBackCompareAct
            // 
            this.bresenhamBackCompareAct.Location = new System.Drawing.Point(253, 92);
            this.bresenhamBackCompareAct.Name = "bresenhamBackCompareAct";
            this.bresenhamBackCompareAct.Size = new System.Drawing.Size(53, 23);
            this.bresenhamBackCompareAct.TabIndex = 58;
            this.bresenhamBackCompareAct.Text = "Фон";
            this.bresenhamBackCompareAct.UseVisualStyleBackColor = true;
            this.bresenhamBackCompareAct.Click += new System.EventHandler(this.BresenhamBackSunAct_Click);
            // 
            // bresenhamCompareColorButton
            // 
            this.bresenhamCompareColorButton.BackColor = System.Drawing.Color.Red;
            this.bresenhamCompareColorButton.Location = new System.Drawing.Point(150, 92);
            this.bresenhamCompareColorButton.Name = "bresenhamCompareColorButton";
            this.bresenhamCompareColorButton.Size = new System.Drawing.Size(30, 22);
            this.bresenhamCompareColorButton.TabIndex = 52;
            this.bresenhamCompareColorButton.UseVisualStyleBackColor = false;
            this.bresenhamCompareColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // canonColorSunAct
            // 
            this.canonColorSunAct.Location = new System.Drawing.Point(196, 35);
            this.canonColorSunAct.Name = "canonColorSunAct";
            this.canonColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.canonColorSunAct.TabIndex = 68;
            this.canonColorSunAct.Text = "Цвет";
            this.canonColorSunAct.UseVisualStyleBackColor = true;
            this.canonColorSunAct.Click += new System.EventHandler(this.CanonicalColorSunAct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Библиотечный";
            // 
            // canonCompareColorButton
            // 
            this.canonCompareColorButton.BackColor = System.Drawing.Color.Red;
            this.canonCompareColorButton.Location = new System.Drawing.Point(150, 35);
            this.canonCompareColorButton.Name = "canonCompareColorButton";
            this.canonCompareColorButton.Size = new System.Drawing.Size(30, 22);
            this.canonCompareColorButton.TabIndex = 67;
            this.canonCompareColorButton.UseVisualStyleBackColor = false;
            this.canonCompareColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartBackCompAct
            // 
            this.standartBackCompAct.Location = new System.Drawing.Point(253, 153);
            this.standartBackCompAct.Name = "standartBackCompAct";
            this.standartBackCompAct.Size = new System.Drawing.Size(53, 23);
            this.standartBackCompAct.TabIndex = 66;
            this.standartBackCompAct.Text = "Фон";
            this.standartBackCompAct.UseVisualStyleBackColor = true;
            this.standartBackCompAct.Click += new System.EventHandler(this.standartBackSunAct_Click);
            // 
            // paramColorCompareButton
            // 
            this.paramColorCompareButton.BackColor = System.Drawing.Color.Red;
            this.paramColorCompareButton.Location = new System.Drawing.Point(150, 63);
            this.paramColorCompareButton.Name = "paramColorCompareButton";
            this.paramColorCompareButton.Size = new System.Drawing.Size(30, 23);
            this.paramColorCompareButton.TabIndex = 53;
            this.paramColorCompareButton.UseVisualStyleBackColor = false;
            this.paramColorCompareButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartColorCompAct
            // 
            this.standartColorCompAct.Location = new System.Drawing.Point(196, 153);
            this.standartColorCompAct.Name = "standartColorCompAct";
            this.standartColorCompAct.Size = new System.Drawing.Size(53, 23);
            this.standartColorCompAct.TabIndex = 65;
            this.standartColorCompAct.Text = "Цвет";
            this.standartColorCompAct.UseVisualStyleBackColor = true;
            this.standartColorCompAct.Click += new System.EventHandler(this.standartColorSunAct_Click);
            // 
            // middleSunColorButton
            // 
            this.middleSunColorButton.BackColor = System.Drawing.Color.Red;
            this.middleSunColorButton.Location = new System.Drawing.Point(150, 121);
            this.middleSunColorButton.Name = "middleSunColorButton";
            this.middleSunColorButton.Size = new System.Drawing.Size(30, 23);
            this.middleSunColorButton.TabIndex = 54;
            this.middleSunColorButton.UseVisualStyleBackColor = false;
            this.middleSunColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // standartCompColorButton
            // 
            this.standartCompColorButton.BackColor = System.Drawing.Color.Red;
            this.standartCompColorButton.Location = new System.Drawing.Point(150, 153);
            this.standartCompColorButton.Name = "standartCompColorButton";
            this.standartCompColorButton.Size = new System.Drawing.Size(30, 23);
            this.standartCompColorButton.TabIndex = 56;
            this.standartCompColorButton.UseVisualStyleBackColor = false;
            this.standartCompColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // middleBackSunAct
            // 
            this.middleBackSunAct.Location = new System.Drawing.Point(254, 121);
            this.middleBackSunAct.Name = "middleBackSunAct";
            this.middleBackSunAct.Size = new System.Drawing.Size(52, 23);
            this.middleBackSunAct.TabIndex = 62;
            this.middleBackSunAct.Text = "Фон";
            this.middleBackSunAct.UseVisualStyleBackColor = true;
            this.middleBackSunAct.Click += new System.EventHandler(this.MiddleBackSunAct_Click);
            // 
            // middleColorSunAct
            // 
            this.middleColorSunAct.Location = new System.Drawing.Point(196, 121);
            this.middleColorSunAct.Name = "middleColorSunAct";
            this.middleColorSunAct.Size = new System.Drawing.Size(53, 23);
            this.middleColorSunAct.TabIndex = 61;
            this.middleColorSunAct.Text = "Цвет";
            this.middleColorSunAct.UseVisualStyleBackColor = true;
            this.middleColorSunAct.Click += new System.EventHandler(this.MiddleColorSunAct_Click);
            // 
            // paramBackCompareAct
            // 
            this.paramBackCompareAct.Location = new System.Drawing.Point(253, 63);
            this.paramBackCompareAct.Name = "paramBackCompareAct";
            this.paramBackCompareAct.Size = new System.Drawing.Size(53, 23);
            this.paramBackCompareAct.TabIndex = 60;
            this.paramBackCompareAct.Text = "Фон";
            this.paramBackCompareAct.UseVisualStyleBackColor = true;
            this.paramBackCompareAct.Click += new System.EventHandler(this.ParamBackSunAct_Click);
            // 
            // paramColorCompareAct
            // 
            this.paramColorCompareAct.Location = new System.Drawing.Point(196, 63);
            this.paramColorCompareAct.Name = "paramColorCompareAct";
            this.paramColorCompareAct.Size = new System.Drawing.Size(53, 23);
            this.paramColorCompareAct.TabIndex = 59;
            this.paramColorCompareAct.Text = "Цвет";
            this.paramColorCompareAct.UseVisualStyleBackColor = true;
            this.paramColorCompareAct.Click += new System.EventHandler(this.ParamColorSunAct_Click);
            // 
            // panelCircle
            // 
            this.panelCircle.Controls.Add(this.checkedListBox);
            this.panelCircle.Controls.Add(this.textBoxEndRadius);
            this.panelCircle.Controls.Add(this.labelEndRadius);
            this.panelCircle.Controls.Add(this.labelCircleCount);
            this.panelCircle.Controls.Add(this.textBoxCircleCount);
            this.panelCircle.Controls.Add(this.textBoxStartRadius);
            this.panelCircle.Controls.Add(this.labelRadiusStep);
            this.panelCircle.Controls.Add(this.textBoxRadiusStep);
            this.panelCircle.Controls.Add(this.labelRadiusStart);
            this.panelCircle.Location = new System.Drawing.Point(9, 19);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(323, 112);
            this.panelCircle.TabIndex = 77;
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Начальный радиус",
            "Конечный радиус",
            "Шаг радиуса",
            "Количество кругов"});
            this.checkedListBox.Location = new System.Drawing.Point(3, 5);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(122, 64);
            this.checkedListBox.TabIndex = 81;
            // 
            // textBoxEndRadius
            // 
            this.textBoxEndRadius.Location = new System.Drawing.Point(252, 28);
            this.textBoxEndRadius.Name = "textBoxEndRadius";
            this.textBoxEndRadius.Size = new System.Drawing.Size(62, 20);
            this.textBoxEndRadius.TabIndex = 80;
            this.textBoxEndRadius.Text = "200";
            // 
            // labelEndRadius
            // 
            this.labelEndRadius.AutoSize = true;
            this.labelEndRadius.Location = new System.Drawing.Point(146, 31);
            this.labelEndRadius.Name = "labelEndRadius";
            this.labelEndRadius.Size = new System.Drawing.Size(95, 13);
            this.labelEndRadius.TabIndex = 79;
            this.labelEndRadius.Text = "Конечный радиус";
            // 
            // labelCircleCount
            // 
            this.labelCircleCount.AutoSize = true;
            this.labelCircleCount.Location = new System.Drawing.Point(147, 83);
            this.labelCircleCount.Name = "labelCircleCount";
            this.labelCircleCount.Size = new System.Drawing.Size(103, 13);
            this.labelCircleCount.TabIndex = 78;
            this.labelCircleCount.Text = "Количество кругов";
            // 
            // textBoxCircleCount
            // 
            this.textBoxCircleCount.Location = new System.Drawing.Point(252, 80);
            this.textBoxCircleCount.Name = "textBoxCircleCount";
            this.textBoxCircleCount.Size = new System.Drawing.Size(62, 20);
            this.textBoxCircleCount.TabIndex = 77;
            this.textBoxCircleCount.Text = "10";
            // 
            // textBoxStartRadius
            // 
            this.textBoxStartRadius.Location = new System.Drawing.Point(252, 2);
            this.textBoxStartRadius.Name = "textBoxStartRadius";
            this.textBoxStartRadius.Size = new System.Drawing.Size(62, 20);
            this.textBoxStartRadius.TabIndex = 76;
            this.textBoxStartRadius.Text = "200";
            // 
            // labelRadiusStep
            // 
            this.labelRadiusStep.AutoSize = true;
            this.labelRadiusStep.Location = new System.Drawing.Point(179, 57);
            this.labelRadiusStep.Name = "labelRadiusStep";
            this.labelRadiusStep.Size = new System.Drawing.Size(71, 13);
            this.labelRadiusStep.TabIndex = 74;
            this.labelRadiusStep.Text = "Шаг радиуса";
            // 
            // textBoxRadiusStep
            // 
            this.textBoxRadiusStep.Location = new System.Drawing.Point(252, 54);
            this.textBoxRadiusStep.Name = "textBoxRadiusStep";
            this.textBoxRadiusStep.Size = new System.Drawing.Size(62, 20);
            this.textBoxRadiusStep.TabIndex = 46;
            this.textBoxRadiusStep.Text = "10";
            // 
            // labelRadiusStart
            // 
            this.labelRadiusStart.AutoSize = true;
            this.labelRadiusStart.Location = new System.Drawing.Point(146, 5);
            this.labelRadiusStart.Name = "labelRadiusStart";
            this.labelRadiusStart.Size = new System.Drawing.Size(102, 13);
            this.labelRadiusStart.TabIndex = 75;
            this.labelRadiusStart.Text = "Начальный радиус";
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.Checked = true;
            this.checkBoxCircle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCircle.Location = new System.Drawing.Point(667, 22);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCircle.TabIndex = 10;
            this.checkBoxCircle.Text = "Круги";
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipse
            // 
            this.checkBoxEllipse.AutoSize = true;
            this.checkBoxEllipse.Location = new System.Drawing.Point(728, 22);
            this.checkBoxEllipse.Name = "checkBoxEllipse";
            this.checkBoxEllipse.Size = new System.Drawing.Size(71, 17);
            this.checkBoxEllipse.TabIndex = 11;
            this.checkBoxEllipse.Text = "Эллипсы";
            this.checkBoxEllipse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 645);
            this.Controls.Add(this.clearButtno);
            this.Controls.Add(this.checkBoxEllipse);
            this.Controls.Add(this.checkBoxCircle);
            this.Controls.Add(this.groupCompare);
            this.Controls.Add(this.groupSimpleDraw);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.mainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 4. Хетагуров Павел";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupSimpleDraw.ResumeLayout(false);
            this.groupSimpleDraw.PerformLayout();
            this.groupCompare.ResumeLayout(false);
            this.panelCompareDraw.ResumeLayout(false);
            this.panelCompareDraw.PerformLayout();
            this.panelCircle.ResumeLayout(false);
            this.panelCircle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.GroupBox groupSimpleDraw;
        private System.Windows.Forms.GroupBox groupCompare;
        private System.Windows.Forms.Label backColorSimpleLabel;
        private System.Windows.Forms.Label choosedDrawSimpleLabel;
        private System.Windows.Forms.Label choosedColorSimpleLabel;
        private System.Windows.Forms.Label methodNameSimple;
        private System.Windows.Forms.Button canonBackSimpleBtn;
        private System.Windows.Forms.Button canonColorSimpleBtn;
        private System.Windows.Forms.Button canonColorButton;
        private System.Windows.Forms.Button standartBackSimpleButton;
        private System.Windows.Forms.Button standartColorSimpleButton;
        private System.Windows.Forms.Button middleBackSimpleButton;
        private System.Windows.Forms.Button middleColorSimpleButton;
        private System.Windows.Forms.Button paramBackSimpleButton;
        private System.Windows.Forms.Button paramColorSimpleButton;
        private System.Windows.Forms.Button bresenhamBackSimpleButton;
        private System.Windows.Forms.Button bresenhamColorSimpleButton;
        private System.Windows.Forms.Button standartColorButton;
        private System.Windows.Forms.Button middleColorButton;
        private System.Windows.Forms.Button paramColorButton;
        private System.Windows.Forms.Button bresenhamColorButton;
        private System.Windows.Forms.Label standartLabel;
        private System.Windows.Forms.Label middleDotSimpleLabel;
        private System.Windows.Forms.Label bresenhamSimpleLabel;
        private System.Windows.Forms.Label simpleLabelParam;
        private System.Windows.Forms.Label simpleLabelCanonic;
        private System.Windows.Forms.Label labelYFirst;
        private System.Windows.Forms.Label labelSimpleRadius;
        private System.Windows.Forms.Label labelXFirst;
        private System.Windows.Forms.TextBox textBoxSimpleRadius;
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
        private System.Windows.Forms.Button canonBackSunAct;
        private System.Windows.Forms.Button canonColorSunAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button canonCompareColorButton;
        private System.Windows.Forms.Button bresenhamCompareColorButton;
        private System.Windows.Forms.Button standartBackCompAct;
        private System.Windows.Forms.Button paramColorCompareButton;
        private System.Windows.Forms.Button standartColorCompAct;
        private System.Windows.Forms.Button middleSunColorButton;
        private System.Windows.Forms.Button standartCompColorButton;
        private System.Windows.Forms.Button middleBackSunAct;
        private System.Windows.Forms.Button bresenhamColorCompareAct;
        private System.Windows.Forms.Button middleColorSunAct;
        private System.Windows.Forms.Button bresenhamBackCompareAct;
        private System.Windows.Forms.Button paramBackCompareAct;
        private System.Windows.Forms.Button paramColorCompareAct;
        private System.Windows.Forms.TextBox textBoxStartRadius;
        private System.Windows.Forms.TextBox textBoxRadiusStep;
        private System.Windows.Forms.Label labelRadiusStart;
        private System.Windows.Forms.Label labelRadiusStep;
        private System.Windows.Forms.Button clearButtno;
        private System.Windows.Forms.CheckBox checkBoxCircle;
        private System.Windows.Forms.CheckBox checkBoxEllipse;
        private System.Windows.Forms.Panel panelCircle;
        private System.Windows.Forms.Panel panelCompareDraw;
        private System.Windows.Forms.TextBox textBoxEndRadius;
        private System.Windows.Forms.Label labelEndRadius;
        private System.Windows.Forms.Label labelCircleCount;
        private System.Windows.Forms.TextBox textBoxCircleCount;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}

