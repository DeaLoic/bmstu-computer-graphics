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
            this.textBoxSimpleRadius = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.labelYFirst = new System.Windows.Forms.Label();
            this.labelSimpleRadius = new System.Windows.Forms.Label();
            this.labelXFirst = new System.Windows.Forms.Label();
            this.clearButtno = new System.Windows.Forms.Button();
            this.textBoxEndRadius = new System.Windows.Forms.TextBox();
            this.labelEndRadius = new System.Windows.Forms.Label();
            this.labelCircleCount = new System.Windows.Forms.Label();
            this.textBoxCircleCount = new System.Windows.Forms.TextBox();
            this.textBoxStartRadius = new System.Windows.Forms.TextBox();
            this.labelRadiusStep = new System.Windows.Forms.Label();
            this.textBoxRadiusStep = new System.Windows.Forms.TextBox();
            this.labelRadiusStart = new System.Windows.Forms.Label();
            this.canonicalRadioButton = new System.Windows.Forms.RadioButton();
            this.parametricRadioButton = new System.Windows.Forms.RadioButton();
            this.bresenhamRadioButton = new System.Windows.Forms.RadioButton();
            this.middleRadioButton = new System.Windows.Forms.RadioButton();
            this.standartRadioButton = new System.Windows.Forms.RadioButton();
            this.groupMethod = new System.Windows.Forms.GroupBox();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.simplePage = new System.Windows.Forms.TabPage();
            this.ellipseDataSimple = new System.Windows.Forms.GroupBox();
            this.textBoxSimpleRadiusY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSimpleRadiusX = new System.Windows.Forms.TextBox();
            this.textBoxXEllipse = new System.Windows.Forms.TextBox();
            this.textBoxYEllipse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drawSimpleBackButton = new System.Windows.Forms.Button();
            this.drawSimpleColorButton = new System.Windows.Forms.Button();
            this.circleDataSimple = new System.Windows.Forms.GroupBox();
            this.comparePage = new System.Windows.Forms.TabPage();
            this.ellipseDataCompare = new System.Windows.Forms.GroupBox();
            this.textBoxStepY = new System.Windows.Forms.TextBox();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.textBoxEllipseCount = new System.Windows.Forms.TextBox();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.drawCompareBackButton = new System.Windows.Forms.Button();
            this.drawCompareColorButton = new System.Windows.Forms.Button();
            this.circleDataCompare = new System.Windows.Forms.GroupBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBoxPrimitive = new System.Windows.Forms.GroupBox();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupMethod.SuspendLayout();
            this.groupColor.SuspendLayout();
            this.tabControlData.SuspendLayout();
            this.simplePage.SuspendLayout();
            this.ellipseDataSimple.SuspendLayout();
            this.circleDataSimple.SuspendLayout();
            this.comparePage.SuspendLayout();
            this.ellipseDataCompare.SuspendLayout();
            this.circleDataCompare.SuspendLayout();
            this.groupBoxPrimitive.SuspendLayout();
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
            // textBoxSimpleRadius
            // 
            this.textBoxSimpleRadius.Location = new System.Drawing.Point(181, 30);
            this.textBoxSimpleRadius.Name = "textBoxSimpleRadius";
            this.textBoxSimpleRadius.Size = new System.Drawing.Size(74, 20);
            this.textBoxSimpleRadius.TabIndex = 44;
            this.textBoxSimpleRadius.Text = "100";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(38, 39);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(74, 20);
            this.textBoxY0.TabIndex = 43;
            this.textBoxY0.Text = "307";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(38, 17);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(74, 20);
            this.textBoxX0.TabIndex = 42;
            this.textBoxX0.Text = "307";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.Location = new System.Drawing.Point(109, 19);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(76, 27);
            this.colorButton.TabIndex = 35;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // labelYFirst
            // 
            this.labelYFirst.AutoSize = true;
            this.labelYFirst.Location = new System.Drawing.Point(12, 42);
            this.labelYFirst.Name = "labelYFirst";
            this.labelYFirst.Size = new System.Drawing.Size(20, 13);
            this.labelYFirst.TabIndex = 13;
            this.labelYFirst.Text = "Y0";
            // 
            // labelSimpleRadius
            // 
            this.labelSimpleRadius.AutoSize = true;
            this.labelSimpleRadius.Location = new System.Drawing.Point(132, 33);
            this.labelSimpleRadius.Name = "labelSimpleRadius";
            this.labelSimpleRadius.Size = new System.Drawing.Size(43, 13);
            this.labelSimpleRadius.TabIndex = 12;
            this.labelSimpleRadius.Text = "Радиус";
            // 
            // labelXFirst
            // 
            this.labelXFirst.AutoSize = true;
            this.labelXFirst.Location = new System.Drawing.Point(12, 20);
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
            // textBoxEndRadius
            // 
            this.textBoxEndRadius.Location = new System.Drawing.Point(116, 44);
            this.textBoxEndRadius.Name = "textBoxEndRadius";
            this.textBoxEndRadius.Size = new System.Drawing.Size(62, 20);
            this.textBoxEndRadius.TabIndex = 80;
            this.textBoxEndRadius.Text = "100";
            // 
            // labelEndRadius
            // 
            this.labelEndRadius.AutoSize = true;
            this.labelEndRadius.Location = new System.Drawing.Point(13, 47);
            this.labelEndRadius.Name = "labelEndRadius";
            this.labelEndRadius.Size = new System.Drawing.Size(95, 13);
            this.labelEndRadius.TabIndex = 79;
            this.labelEndRadius.Text = "Конечный радиус";
            // 
            // labelCircleCount
            // 
            this.labelCircleCount.AutoSize = true;
            this.labelCircleCount.Location = new System.Drawing.Point(7, 99);
            this.labelCircleCount.Name = "labelCircleCount";
            this.labelCircleCount.Size = new System.Drawing.Size(103, 13);
            this.labelCircleCount.TabIndex = 78;
            this.labelCircleCount.Text = "Количество кругов";
            // 
            // textBoxCircleCount
            // 
            this.textBoxCircleCount.Location = new System.Drawing.Point(116, 96);
            this.textBoxCircleCount.Name = "textBoxCircleCount";
            this.textBoxCircleCount.Size = new System.Drawing.Size(62, 20);
            this.textBoxCircleCount.TabIndex = 77;
            this.textBoxCircleCount.Text = "5";
            // 
            // textBoxStartRadius
            // 
            this.textBoxStartRadius.Location = new System.Drawing.Point(116, 18);
            this.textBoxStartRadius.Name = "textBoxStartRadius";
            this.textBoxStartRadius.Size = new System.Drawing.Size(62, 20);
            this.textBoxStartRadius.TabIndex = 76;
            this.textBoxStartRadius.Text = "50";
            // 
            // labelRadiusStep
            // 
            this.labelRadiusStep.AutoSize = true;
            this.labelRadiusStep.Location = new System.Drawing.Point(39, 73);
            this.labelRadiusStep.Name = "labelRadiusStep";
            this.labelRadiusStep.Size = new System.Drawing.Size(71, 13);
            this.labelRadiusStep.TabIndex = 74;
            this.labelRadiusStep.Text = "Шаг радиуса";
            // 
            // textBoxRadiusStep
            // 
            this.textBoxRadiusStep.Location = new System.Drawing.Point(116, 70);
            this.textBoxRadiusStep.Name = "textBoxRadiusStep";
            this.textBoxRadiusStep.Size = new System.Drawing.Size(62, 20);
            this.textBoxRadiusStep.TabIndex = 46;
            this.textBoxRadiusStep.Text = "10";
            // 
            // labelRadiusStart
            // 
            this.labelRadiusStart.AutoSize = true;
            this.labelRadiusStart.Location = new System.Drawing.Point(6, 25);
            this.labelRadiusStart.Name = "labelRadiusStart";
            this.labelRadiusStart.Size = new System.Drawing.Size(102, 13);
            this.labelRadiusStart.TabIndex = 75;
            this.labelRadiusStart.Text = "Начальный радиус";
            // 
            // canonicalRadioButton
            // 
            this.canonicalRadioButton.AutoSize = true;
            this.canonicalRadioButton.Checked = true;
            this.canonicalRadioButton.Location = new System.Drawing.Point(34, 19);
            this.canonicalRadioButton.Name = "canonicalRadioButton";
            this.canonicalRadioButton.Size = new System.Drawing.Size(153, 17);
            this.canonicalRadioButton.TabIndex = 47;
            this.canonicalRadioButton.TabStop = true;
            this.canonicalRadioButton.Text = "Каноническое уравнение";
            this.canonicalRadioButton.UseVisualStyleBackColor = true;
            // 
            // parametricRadioButton
            // 
            this.parametricRadioButton.AutoSize = true;
            this.parametricRadioButton.Location = new System.Drawing.Point(34, 55);
            this.parametricRadioButton.Name = "parametricRadioButton";
            this.parametricRadioButton.Size = new System.Drawing.Size(173, 17);
            this.parametricRadioButton.TabIndex = 48;
            this.parametricRadioButton.Text = "Параметрическое уравнение";
            this.parametricRadioButton.UseVisualStyleBackColor = true;
            // 
            // bresenhamRadioButton
            // 
            this.bresenhamRadioButton.AutoSize = true;
            this.bresenhamRadioButton.Location = new System.Drawing.Point(34, 92);
            this.bresenhamRadioButton.Name = "bresenhamRadioButton";
            this.bresenhamRadioButton.Size = new System.Drawing.Size(139, 17);
            this.bresenhamRadioButton.TabIndex = 49;
            this.bresenhamRadioButton.Text = "Алгоритм Брезенхема";
            this.bresenhamRadioButton.UseVisualStyleBackColor = true;
            // 
            // middleRadioButton
            // 
            this.middleRadioButton.AutoSize = true;
            this.middleRadioButton.Location = new System.Drawing.Point(34, 131);
            this.middleRadioButton.Name = "middleRadioButton";
            this.middleRadioButton.Size = new System.Drawing.Size(150, 17);
            this.middleRadioButton.TabIndex = 50;
            this.middleRadioButton.Text = "Алгоритм средней точки";
            this.middleRadioButton.UseVisualStyleBackColor = true;
            // 
            // standartRadioButton
            // 
            this.standartRadioButton.AutoSize = true;
            this.standartRadioButton.Location = new System.Drawing.Point(34, 174);
            this.standartRadioButton.Name = "standartRadioButton";
            this.standartRadioButton.Size = new System.Drawing.Size(98, 17);
            this.standartRadioButton.TabIndex = 51;
            this.standartRadioButton.Text = "Библиотечный";
            this.standartRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupMethod
            // 
            this.groupMethod.Controls.Add(this.standartRadioButton);
            this.groupMethod.Controls.Add(this.middleRadioButton);
            this.groupMethod.Controls.Add(this.bresenhamRadioButton);
            this.groupMethod.Controls.Add(this.parametricRadioButton);
            this.groupMethod.Controls.Add(this.canonicalRadioButton);
            this.groupMethod.Location = new System.Drawing.Point(638, 90);
            this.groupMethod.Name = "groupMethod";
            this.groupMethod.Size = new System.Drawing.Size(310, 209);
            this.groupMethod.TabIndex = 52;
            this.groupMethod.TabStop = false;
            this.groupMethod.Text = "Выбор метода";
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.label6);
            this.groupColor.Controls.Add(this.colorButton);
            this.groupColor.Location = new System.Drawing.Point(640, 309);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(307, 63);
            this.groupColor.TabIndex = 53;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Выбор цвета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Выбранный цвет: ";
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.simplePage);
            this.tabControlData.Controls.Add(this.comparePage);
            this.tabControlData.Location = new System.Drawing.Point(645, 378);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(303, 234);
            this.tabControlData.TabIndex = 54;
            this.tabControlData.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlData_Selecting);
            // 
            // simplePage
            // 
            this.simplePage.Controls.Add(this.ellipseDataSimple);
            this.simplePage.Controls.Add(this.drawSimpleBackButton);
            this.simplePage.Controls.Add(this.drawSimpleColorButton);
            this.simplePage.Controls.Add(this.circleDataSimple);
            this.simplePage.Location = new System.Drawing.Point(4, 22);
            this.simplePage.Name = "simplePage";
            this.simplePage.Padding = new System.Windows.Forms.Padding(3);
            this.simplePage.Size = new System.Drawing.Size(295, 208);
            this.simplePage.TabIndex = 0;
            this.simplePage.Text = "Одиночное";
            this.simplePage.UseVisualStyleBackColor = true;
            // 
            // ellipseDataSimple
            // 
            this.ellipseDataSimple.Controls.Add(this.textBoxSimpleRadiusY);
            this.ellipseDataSimple.Controls.Add(this.label4);
            this.ellipseDataSimple.Controls.Add(this.textBoxSimpleRadiusX);
            this.ellipseDataSimple.Controls.Add(this.textBoxXEllipse);
            this.ellipseDataSimple.Controls.Add(this.textBoxYEllipse);
            this.ellipseDataSimple.Controls.Add(this.label1);
            this.ellipseDataSimple.Controls.Add(this.label2);
            this.ellipseDataSimple.Controls.Add(this.label3);
            this.ellipseDataSimple.Location = new System.Drawing.Point(9, 8);
            this.ellipseDataSimple.Name = "ellipseDataSimple";
            this.ellipseDataSimple.Size = new System.Drawing.Size(276, 71);
            this.ellipseDataSimple.TabIndex = 45;
            this.ellipseDataSimple.TabStop = false;
            this.ellipseDataSimple.Text = "Данные для одиночного эллипса";
            this.ellipseDataSimple.Visible = false;
            // 
            // textBoxSimpleRadiusY
            // 
            this.textBoxSimpleRadiusY.Location = new System.Drawing.Point(184, 39);
            this.textBoxSimpleRadiusY.Name = "textBoxSimpleRadiusY";
            this.textBoxSimpleRadiusY.Size = new System.Drawing.Size(74, 20);
            this.textBoxSimpleRadiusY.TabIndex = 46;
            this.textBoxSimpleRadiusY.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Радиус Y";
            // 
            // textBoxSimpleRadiusX
            // 
            this.textBoxSimpleRadiusX.Location = new System.Drawing.Point(184, 17);
            this.textBoxSimpleRadiusX.Name = "textBoxSimpleRadiusX";
            this.textBoxSimpleRadiusX.Size = new System.Drawing.Size(74, 20);
            this.textBoxSimpleRadiusX.TabIndex = 44;
            this.textBoxSimpleRadiusX.Text = "100";
            // 
            // textBoxXEllipse
            // 
            this.textBoxXEllipse.Location = new System.Drawing.Point(38, 17);
            this.textBoxXEllipse.Name = "textBoxXEllipse";
            this.textBoxXEllipse.Size = new System.Drawing.Size(74, 20);
            this.textBoxXEllipse.TabIndex = 42;
            this.textBoxXEllipse.Text = "307";
            // 
            // textBoxYEllipse
            // 
            this.textBoxYEllipse.Location = new System.Drawing.Point(38, 39);
            this.textBoxYEllipse.Name = "textBoxYEllipse";
            this.textBoxYEllipse.Size = new System.Drawing.Size(74, 20);
            this.textBoxYEllipse.TabIndex = 43;
            this.textBoxYEllipse.Text = "307";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Радиус Х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y0";
            // 
            // drawSimpleBackButton
            // 
            this.drawSimpleBackButton.Location = new System.Drawing.Point(151, 91);
            this.drawSimpleBackButton.Name = "drawSimpleBackButton";
            this.drawSimpleBackButton.Size = new System.Drawing.Size(134, 33);
            this.drawSimpleBackButton.TabIndex = 2;
            this.drawSimpleBackButton.Text = "Рисовать фоновым";
            this.drawSimpleBackButton.UseVisualStyleBackColor = true;
            this.drawSimpleBackButton.Click += new System.EventHandler(this.DrawSimpleBackButton_Click);
            // 
            // drawSimpleColorButton
            // 
            this.drawSimpleColorButton.Location = new System.Drawing.Point(11, 91);
            this.drawSimpleColorButton.Name = "drawSimpleColorButton";
            this.drawSimpleColorButton.Size = new System.Drawing.Size(134, 33);
            this.drawSimpleColorButton.TabIndex = 1;
            this.drawSimpleColorButton.Text = "Рисовать цветом";
            this.drawSimpleColorButton.UseVisualStyleBackColor = true;
            this.drawSimpleColorButton.Click += new System.EventHandler(this.DrawSimpleColorButton_Click);
            // 
            // circleDataSimple
            // 
            this.circleDataSimple.Controls.Add(this.textBoxSimpleRadius);
            this.circleDataSimple.Controls.Add(this.textBoxX0);
            this.circleDataSimple.Controls.Add(this.textBoxY0);
            this.circleDataSimple.Controls.Add(this.labelXFirst);
            this.circleDataSimple.Controls.Add(this.labelSimpleRadius);
            this.circleDataSimple.Controls.Add(this.labelYFirst);
            this.circleDataSimple.Location = new System.Drawing.Point(9, 8);
            this.circleDataSimple.Name = "circleDataSimple";
            this.circleDataSimple.Size = new System.Drawing.Size(276, 71);
            this.circleDataSimple.TabIndex = 0;
            this.circleDataSimple.TabStop = false;
            this.circleDataSimple.Text = "Данные для одиночного круга";
            // 
            // comparePage
            // 
            this.comparePage.Controls.Add(this.ellipseDataCompare);
            this.comparePage.Controls.Add(this.drawCompareBackButton);
            this.comparePage.Controls.Add(this.drawCompareColorButton);
            this.comparePage.Controls.Add(this.circleDataCompare);
            this.comparePage.Location = new System.Drawing.Point(4, 22);
            this.comparePage.Name = "comparePage";
            this.comparePage.Padding = new System.Windows.Forms.Padding(3);
            this.comparePage.Size = new System.Drawing.Size(295, 208);
            this.comparePage.TabIndex = 1;
            this.comparePage.Text = "Сравнение";
            this.comparePage.UseVisualStyleBackColor = true;
            // 
            // ellipseDataCompare
            // 
            this.ellipseDataCompare.Controls.Add(this.textBoxStepY);
            this.ellipseDataCompare.Controls.Add(this.textBoxStepX);
            this.ellipseDataCompare.Controls.Add(this.label11);
            this.ellipseDataCompare.Controls.Add(this.label10);
            this.ellipseDataCompare.Controls.Add(this.label5);
            this.ellipseDataCompare.Controls.Add(this.label7);
            this.ellipseDataCompare.Controls.Add(this.textBoxStartY);
            this.ellipseDataCompare.Controls.Add(this.textBoxEllipseCount);
            this.ellipseDataCompare.Controls.Add(this.textBoxStartX);
            this.ellipseDataCompare.Controls.Add(this.label9);
            this.ellipseDataCompare.Location = new System.Drawing.Point(7, 8);
            this.ellipseDataCompare.Name = "ellipseDataCompare";
            this.ellipseDataCompare.Size = new System.Drawing.Size(276, 124);
            this.ellipseDataCompare.TabIndex = 82;
            this.ellipseDataCompare.TabStop = false;
            this.ellipseDataCompare.Text = "Данные для сравнения эллипсов";
            this.ellipseDataCompare.Visible = false;
            // 
            // textBoxStepY
            // 
            this.textBoxStepY.Location = new System.Drawing.Point(183, 44);
            this.textBoxStepY.Name = "textBoxStepY";
            this.textBoxStepY.Size = new System.Drawing.Size(62, 20);
            this.textBoxStepY.TabIndex = 84;
            this.textBoxStepY.Text = "50";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(183, 19);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(62, 20);
            this.textBoxStepX.TabIndex = 83;
            this.textBoxStepX.Text = "50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Шаг Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Шаг X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Радиус X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Количество эллипсов";
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Location = new System.Drawing.Point(72, 44);
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(62, 20);
            this.textBoxStartY.TabIndex = 80;
            this.textBoxStartY.Text = "100";
            // 
            // textBoxEllipseCount
            // 
            this.textBoxEllipseCount.Location = new System.Drawing.Point(130, 96);
            this.textBoxEllipseCount.Name = "textBoxEllipseCount";
            this.textBoxEllipseCount.Size = new System.Drawing.Size(62, 20);
            this.textBoxEllipseCount.TabIndex = 77;
            this.textBoxEllipseCount.Text = "5";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(72, 19);
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(62, 20);
            this.textBoxStartX.TabIndex = 76;
            this.textBoxStartX.Text = "50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Радиус Y";
            // 
            // drawCompareBackButton
            // 
            this.drawCompareBackButton.Location = new System.Drawing.Point(149, 163);
            this.drawCompareBackButton.Name = "drawCompareBackButton";
            this.drawCompareBackButton.Size = new System.Drawing.Size(134, 33);
            this.drawCompareBackButton.TabIndex = 47;
            this.drawCompareBackButton.Text = "Рисовать фоновым";
            this.drawCompareBackButton.UseVisualStyleBackColor = true;
            this.drawCompareBackButton.Click += new System.EventHandler(this.DrawCompareBackButton_Click);
            // 
            // drawCompareColorButton
            // 
            this.drawCompareColorButton.Location = new System.Drawing.Point(9, 163);
            this.drawCompareColorButton.Name = "drawCompareColorButton";
            this.drawCompareColorButton.Size = new System.Drawing.Size(134, 33);
            this.drawCompareColorButton.TabIndex = 46;
            this.drawCompareColorButton.Text = "Рисовать цветом";
            this.drawCompareColorButton.UseVisualStyleBackColor = true;
            this.drawCompareColorButton.Click += new System.EventHandler(this.DrawCompareColorButton_Click);
            // 
            // circleDataCompare
            // 
            this.circleDataCompare.Controls.Add(this.checkedListBox);
            this.circleDataCompare.Controls.Add(this.labelRadiusStart);
            this.circleDataCompare.Controls.Add(this.labelCircleCount);
            this.circleDataCompare.Controls.Add(this.textBoxEndRadius);
            this.circleDataCompare.Controls.Add(this.textBoxCircleCount);
            this.circleDataCompare.Controls.Add(this.textBoxStartRadius);
            this.circleDataCompare.Controls.Add(this.labelRadiusStep);
            this.circleDataCompare.Controls.Add(this.textBoxRadiusStep);
            this.circleDataCompare.Controls.Add(this.labelEndRadius);
            this.circleDataCompare.Location = new System.Drawing.Point(9, 8);
            this.circleDataCompare.Name = "circleDataCompare";
            this.circleDataCompare.Size = new System.Drawing.Size(276, 124);
            this.circleDataCompare.TabIndex = 45;
            this.circleDataCompare.TabStop = false;
            this.circleDataCompare.Text = "Данные для сравнения кругов";
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Начальный",
            "Конечный",
            "Шаг",
            "Количество"});
            this.checkedListBox.Location = new System.Drawing.Point(184, 35);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(86, 64);
            this.checkedListBox.TabIndex = 81;
            // 
            // groupBoxPrimitive
            // 
            this.groupBoxPrimitive.Controls.Add(this.radioButtonEllipse);
            this.groupBoxPrimitive.Controls.Add(this.radioButtonCircle);
            this.groupBoxPrimitive.Location = new System.Drawing.Point(645, 18);
            this.groupBoxPrimitive.Name = "groupBoxPrimitive";
            this.groupBoxPrimitive.Size = new System.Drawing.Size(178, 44);
            this.groupBoxPrimitive.TabIndex = 55;
            this.groupBoxPrimitive.TabStop = false;
            this.groupBoxPrimitive.Text = "Примитив";
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(63, 19);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEllipse.TabIndex = 1;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Эллипс";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Checked = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCircle.TabIndex = 0;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Круг";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 645);
            this.Controls.Add(this.groupBoxPrimitive);
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.groupMethod);
            this.Controls.Add(this.clearButtno);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.mainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 4. Хетагуров Павел";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupMethod.ResumeLayout(false);
            this.groupMethod.PerformLayout();
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.tabControlData.ResumeLayout(false);
            this.simplePage.ResumeLayout(false);
            this.ellipseDataSimple.ResumeLayout(false);
            this.ellipseDataSimple.PerformLayout();
            this.circleDataSimple.ResumeLayout(false);
            this.circleDataSimple.PerformLayout();
            this.comparePage.ResumeLayout(false);
            this.ellipseDataCompare.ResumeLayout(false);
            this.ellipseDataCompare.PerformLayout();
            this.circleDataCompare.ResumeLayout(false);
            this.circleDataCompare.PerformLayout();
            this.groupBoxPrimitive.ResumeLayout(false);
            this.groupBoxPrimitive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label labelYFirst;
        private System.Windows.Forms.Label labelSimpleRadius;
        private System.Windows.Forms.Label labelXFirst;
        private System.Windows.Forms.TextBox textBoxSimpleRadius;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxStartRadius;
        private System.Windows.Forms.TextBox textBoxRadiusStep;
        private System.Windows.Forms.Label labelRadiusStart;
        private System.Windows.Forms.Label labelRadiusStep;
        private System.Windows.Forms.Button clearButtno;
        private System.Windows.Forms.TextBox textBoxEndRadius;
        private System.Windows.Forms.Label labelEndRadius;
        private System.Windows.Forms.Label labelCircleCount;
        private System.Windows.Forms.TextBox textBoxCircleCount;
        private System.Windows.Forms.RadioButton canonicalRadioButton;
        private System.Windows.Forms.RadioButton parametricRadioButton;
        private System.Windows.Forms.RadioButton bresenhamRadioButton;
        private System.Windows.Forms.RadioButton middleRadioButton;
        private System.Windows.Forms.RadioButton standartRadioButton;
        private System.Windows.Forms.GroupBox groupMethod;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage simplePage;
        private System.Windows.Forms.Button drawSimpleBackButton;
        private System.Windows.Forms.Button drawSimpleColorButton;
        private System.Windows.Forms.GroupBox circleDataSimple;
        private System.Windows.Forms.TabPage comparePage;
        private System.Windows.Forms.Button drawCompareBackButton;
        private System.Windows.Forms.Button drawCompareColorButton;
        private System.Windows.Forms.GroupBox circleDataCompare;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.GroupBox groupBoxPrimitive;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.GroupBox ellipseDataSimple;
        private System.Windows.Forms.TextBox textBoxSimpleRadiusX;
        private System.Windows.Forms.TextBox textBoxXEllipse;
        private System.Windows.Forms.TextBox textBoxYEllipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSimpleRadiusY;
        private System.Windows.Forms.GroupBox ellipseDataCompare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.TextBox textBoxEllipseCount;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStepY;
        private System.Windows.Forms.TextBox textBoxStepX;
    }
}

