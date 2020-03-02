namespace lab_02
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
            this.MainCanvas = new System.Windows.Forms.PictureBox();
            this.imageGroup = new System.Windows.Forms.GroupBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.imageBuildButton = new System.Windows.Forms.Button();
            this.dWelcome = new System.Windows.Forms.Label();
            this.cWelcome = new System.Windows.Forms.Label();
            this.parabolaEquation = new System.Windows.Forms.Label();
            this.rWelcome = new System.Windows.Forms.Label();
            this.bWelcome = new System.Windows.Forms.Label();
            this.aWelcome = new System.Windows.Forms.Label();
            this.circleEquation = new System.Windows.Forms.Label();
            this.scaleGroup = new System.Windows.Forms.GroupBox();
            this.scaleKYtextBox = new System.Windows.Forms.TextBox();
            this.scaleYtextBox = new System.Windows.Forms.TextBox();
            this.scaleKXtextBox = new System.Windows.Forms.TextBox();
            this.scaleXtextBox = new System.Windows.Forms.TextBox();
            this.scaleWelcomeKY = new System.Windows.Forms.Label();
            this.scaleWelcomeKX = new System.Windows.Forms.Label();
            this.scaleButton = new System.Windows.Forms.Button();
            this.ScaleWelcomeY = new System.Windows.Forms.Label();
            this.ScaleWelcomeX = new System.Windows.Forms.Label();
            this.rotateGroup = new System.Windows.Forms.GroupBox();
            this.rotateAngleTextBox = new System.Windows.Forms.TextBox();
            this.rotateYTextBox = new System.Windows.Forms.TextBox();
            this.rotateXTextBox = new System.Windows.Forms.TextBox();
            this.angleWelcome = new System.Windows.Forms.Label();
            this.rotateWelcomeY = new System.Windows.Forms.Label();
            this.rotateButton = new System.Windows.Forms.Button();
            this.rotateWelcomeX = new System.Windows.Forms.Label();
            this.movingBox = new System.Windows.Forms.GroupBox();
            this.moveDYTextBox = new System.Windows.Forms.TextBox();
            this.moveDXTextBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.moveWelcomeDY = new System.Windows.Forms.Label();
            this.moveWelcomeDX = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.Button();
            this.lastStepButton = new System.Windows.Forms.Button();
            this.coordsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).BeginInit();
            this.imageGroup.SuspendLayout();
            this.scaleGroup.SuspendLayout();
            this.rotateGroup.SuspendLayout();
            this.movingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCanvas
            // 
            this.MainCanvas.BackColor = System.Drawing.Color.Cornsilk;
            this.MainCanvas.Location = new System.Drawing.Point(4, 6);
            this.MainCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainCanvas.Name = "MainCanvas";
            this.MainCanvas.Size = new System.Drawing.Size(615, 536);
            this.MainCanvas.TabIndex = 0;
            this.MainCanvas.TabStop = false;
            this.MainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCanvas_MouseMove);
            // 
            // imageGroup
            // 
            this.imageGroup.Controls.Add(this.dTextBox);
            this.imageGroup.Controls.Add(this.cTextBox);
            this.imageGroup.Controls.Add(this.rTextBox);
            this.imageGroup.Controls.Add(this.bTextBox);
            this.imageGroup.Controls.Add(this.aTextBox);
            this.imageGroup.Controls.Add(this.imageBuildButton);
            this.imageGroup.Controls.Add(this.dWelcome);
            this.imageGroup.Controls.Add(this.cWelcome);
            this.imageGroup.Controls.Add(this.parabolaEquation);
            this.imageGroup.Controls.Add(this.rWelcome);
            this.imageGroup.Controls.Add(this.bWelcome);
            this.imageGroup.Controls.Add(this.aWelcome);
            this.imageGroup.Controls.Add(this.circleEquation);
            this.imageGroup.Location = new System.Drawing.Point(627, 11);
            this.imageGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageGroup.Name = "imageGroup";
            this.imageGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageGroup.Size = new System.Drawing.Size(161, 176);
            this.imageGroup.TabIndex = 1;
            this.imageGroup.TabStop = false;
            this.imageGroup.Text = "Задание изображения";
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(75, 103);
            this.dTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(38, 20);
            this.dTextBox.TabIndex = 15;
            this.dTextBox.Text = "0";
            this.dTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(23, 103);
            this.cTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(36, 20);
            this.cTextBox.TabIndex = 14;
            this.cTextBox.Text = "0";
            this.cTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(122, 46);
            this.rTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(36, 20);
            this.rTextBox.TabIndex = 13;
            this.rTextBox.Text = "0";
            this.rTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(75, 46);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(38, 20);
            this.bTextBox.TabIndex = 9;
            this.bTextBox.Text = "0";
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(23, 46);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(36, 20);
            this.aTextBox.TabIndex = 8;
            this.aTextBox.Text = "0";
            this.aTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageBuildButton
            // 
            this.imageBuildButton.Location = new System.Drawing.Point(23, 143);
            this.imageBuildButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageBuildButton.Name = "imageBuildButton";
            this.imageBuildButton.Size = new System.Drawing.Size(111, 24);
            this.imageBuildButton.TabIndex = 7;
            this.imageBuildButton.Text = "Построить";
            this.imageBuildButton.UseVisualStyleBackColor = true;
            this.imageBuildButton.Click += new System.EventHandler(this.ImageBuildButton_Click);
            // 
            // dWelcome
            // 
            this.dWelcome.AutoSize = true;
            this.dWelcome.Location = new System.Drawing.Point(63, 106);
            this.dWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dWelcome.Name = "dWelcome";
            this.dWelcome.Size = new System.Drawing.Size(13, 13);
            this.dWelcome.TabIndex = 6;
            this.dWelcome.Text = "d";
            // 
            // cWelcome
            // 
            this.cWelcome.AutoSize = true;
            this.cWelcome.Location = new System.Drawing.Point(10, 106);
            this.cWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cWelcome.Name = "cWelcome";
            this.cWelcome.Size = new System.Drawing.Size(13, 13);
            this.cWelcome.TabIndex = 5;
            this.cWelcome.Text = "c";
            // 
            // parabolaEquation
            // 
            this.parabolaEquation.AutoSize = true;
            this.parabolaEquation.Location = new System.Drawing.Point(9, 79);
            this.parabolaEquation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.parabolaEquation.Name = "parabolaEquation";
            this.parabolaEquation.Size = new System.Drawing.Size(80, 13);
            this.parabolaEquation.TabIndex = 4;
            this.parabolaEquation.Text = "x = c + (y - d)^2";
            // 
            // rWelcome
            // 
            this.rWelcome.AutoSize = true;
            this.rWelcome.Location = new System.Drawing.Point(112, 49);
            this.rWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rWelcome.Name = "rWelcome";
            this.rWelcome.Size = new System.Drawing.Size(10, 13);
            this.rWelcome.TabIndex = 3;
            this.rWelcome.Text = "r";
            // 
            // bWelcome
            // 
            this.bWelcome.AutoSize = true;
            this.bWelcome.Location = new System.Drawing.Point(63, 49);
            this.bWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bWelcome.Name = "bWelcome";
            this.bWelcome.Size = new System.Drawing.Size(13, 13);
            this.bWelcome.TabIndex = 2;
            this.bWelcome.Text = "b";
            // 
            // aWelcome
            // 
            this.aWelcome.AutoSize = true;
            this.aWelcome.Location = new System.Drawing.Point(9, 49);
            this.aWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aWelcome.Name = "aWelcome";
            this.aWelcome.Size = new System.Drawing.Size(13, 13);
            this.aWelcome.TabIndex = 1;
            this.aWelcome.Text = "a";
            // 
            // circleEquation
            // 
            this.circleEquation.AutoSize = true;
            this.circleEquation.Location = new System.Drawing.Point(9, 23);
            this.circleEquation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.circleEquation.Name = "circleEquation";
            this.circleEquation.Size = new System.Drawing.Size(122, 13);
            this.circleEquation.TabIndex = 0;
            this.circleEquation.Text = "(x - a)^2 + (y - b)^2 = r^2";
            // 
            // scaleGroup
            // 
            this.scaleGroup.Controls.Add(this.scaleKYtextBox);
            this.scaleGroup.Controls.Add(this.scaleYtextBox);
            this.scaleGroup.Controls.Add(this.scaleKXtextBox);
            this.scaleGroup.Controls.Add(this.scaleXtextBox);
            this.scaleGroup.Controls.Add(this.scaleWelcomeKY);
            this.scaleGroup.Controls.Add(this.scaleWelcomeKX);
            this.scaleGroup.Controls.Add(this.scaleButton);
            this.scaleGroup.Controls.Add(this.ScaleWelcomeY);
            this.scaleGroup.Controls.Add(this.ScaleWelcomeX);
            this.scaleGroup.Location = new System.Drawing.Point(627, 199);
            this.scaleGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleGroup.Name = "scaleGroup";
            this.scaleGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleGroup.Size = new System.Drawing.Size(160, 98);
            this.scaleGroup.TabIndex = 2;
            this.scaleGroup.TabStop = false;
            this.scaleGroup.Text = "Масштабировать";
            // 
            // scaleKYtextBox
            // 
            this.scaleKYtextBox.Location = new System.Drawing.Point(100, 46);
            this.scaleKYtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleKYtextBox.Name = "scaleKYtextBox";
            this.scaleKYtextBox.Size = new System.Drawing.Size(32, 20);
            this.scaleKYtextBox.TabIndex = 16;
            this.scaleKYtextBox.Text = "1";
            this.scaleKYtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scaleYtextBox
            // 
            this.scaleYtextBox.Location = new System.Drawing.Point(30, 45);
            this.scaleYtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleYtextBox.Name = "scaleYtextBox";
            this.scaleYtextBox.Size = new System.Drawing.Size(32, 20);
            this.scaleYtextBox.TabIndex = 15;
            this.scaleYtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scaleKXtextBox
            // 
            this.scaleKXtextBox.Location = new System.Drawing.Point(100, 20);
            this.scaleKXtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleKXtextBox.Name = "scaleKXtextBox";
            this.scaleKXtextBox.Size = new System.Drawing.Size(32, 20);
            this.scaleKXtextBox.TabIndex = 14;
            this.scaleKXtextBox.Text = "1";
            this.scaleKXtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scaleXtextBox
            // 
            this.scaleXtextBox.Location = new System.Drawing.Point(30, 20);
            this.scaleXtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleXtextBox.Name = "scaleXtextBox";
            this.scaleXtextBox.Size = new System.Drawing.Size(32, 20);
            this.scaleXtextBox.TabIndex = 13;
            this.scaleXtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scaleWelcomeKY
            // 
            this.scaleWelcomeKY.AutoSize = true;
            this.scaleWelcomeKY.Location = new System.Drawing.Point(78, 49);
            this.scaleWelcomeKY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scaleWelcomeKY.Name = "scaleWelcomeKY";
            this.scaleWelcomeKY.Size = new System.Drawing.Size(20, 13);
            this.scaleWelcomeKY.TabIndex = 4;
            this.scaleWelcomeKY.Text = "kY";
            // 
            // scaleWelcomeKX
            // 
            this.scaleWelcomeKX.AutoSize = true;
            this.scaleWelcomeKX.Location = new System.Drawing.Point(78, 24);
            this.scaleWelcomeKX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scaleWelcomeKX.Name = "scaleWelcomeKX";
            this.scaleWelcomeKX.Size = new System.Drawing.Size(20, 13);
            this.scaleWelcomeKX.TabIndex = 3;
            this.scaleWelcomeKX.Text = "kX";
            // 
            // scaleButton
            // 
            this.scaleButton.Location = new System.Drawing.Point(23, 65);
            this.scaleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(111, 28);
            this.scaleButton.TabIndex = 2;
            this.scaleButton.Text = "Масштабирование";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.ScaleButton_Click);
            // 
            // ScaleWelcomeY
            // 
            this.ScaleWelcomeY.AutoSize = true;
            this.ScaleWelcomeY.Location = new System.Drawing.Point(13, 49);
            this.ScaleWelcomeY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScaleWelcomeY.Name = "ScaleWelcomeY";
            this.ScaleWelcomeY.Size = new System.Drawing.Size(14, 13);
            this.ScaleWelcomeY.TabIndex = 1;
            this.ScaleWelcomeY.Text = "Y";
            // 
            // ScaleWelcomeX
            // 
            this.ScaleWelcomeX.AutoSize = true;
            this.ScaleWelcomeX.Location = new System.Drawing.Point(13, 24);
            this.ScaleWelcomeX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScaleWelcomeX.Name = "ScaleWelcomeX";
            this.ScaleWelcomeX.Size = new System.Drawing.Size(14, 13);
            this.ScaleWelcomeX.TabIndex = 0;
            this.ScaleWelcomeX.Text = "X";
            // 
            // rotateGroup
            // 
            this.rotateGroup.Controls.Add(this.rotateAngleTextBox);
            this.rotateGroup.Controls.Add(this.rotateYTextBox);
            this.rotateGroup.Controls.Add(this.rotateXTextBox);
            this.rotateGroup.Controls.Add(this.angleWelcome);
            this.rotateGroup.Controls.Add(this.rotateWelcomeY);
            this.rotateGroup.Controls.Add(this.rotateButton);
            this.rotateGroup.Controls.Add(this.rotateWelcomeX);
            this.rotateGroup.Location = new System.Drawing.Point(627, 309);
            this.rotateGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotateGroup.Name = "rotateGroup";
            this.rotateGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotateGroup.Size = new System.Drawing.Size(160, 98);
            this.rotateGroup.TabIndex = 3;
            this.rotateGroup.TabStop = false;
            this.rotateGroup.Text = "Повернуть";
            // 
            // rotateAngleTextBox
            // 
            this.rotateAngleTextBox.Location = new System.Drawing.Point(100, 42);
            this.rotateAngleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotateAngleTextBox.Name = "rotateAngleTextBox";
            this.rotateAngleTextBox.Size = new System.Drawing.Size(32, 20);
            this.rotateAngleTextBox.TabIndex = 19;
            this.rotateAngleTextBox.Text = "0";
            this.rotateAngleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rotateYTextBox
            // 
            this.rotateYTextBox.Location = new System.Drawing.Point(100, 21);
            this.rotateYTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotateYTextBox.Name = "rotateYTextBox";
            this.rotateYTextBox.Size = new System.Drawing.Size(32, 20);
            this.rotateYTextBox.TabIndex = 18;
            this.rotateYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rotateXTextBox
            // 
            this.rotateXTextBox.Location = new System.Drawing.Point(30, 21);
            this.rotateXTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotateXTextBox.Name = "rotateXTextBox";
            this.rotateXTextBox.Size = new System.Drawing.Size(32, 20);
            this.rotateXTextBox.TabIndex = 17;
            this.rotateXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angleWelcome
            // 
            this.angleWelcome.AutoSize = true;
            this.angleWelcome.Location = new System.Drawing.Point(13, 45);
            this.angleWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angleWelcome.Name = "angleWelcome";
            this.angleWelcome.Size = new System.Drawing.Size(95, 13);
            this.angleWelcome.TabIndex = 7;
            this.angleWelcome.Text = "Угол (в градусах)";
            // 
            // rotateWelcomeY
            // 
            this.rotateWelcomeY.AutoSize = true;
            this.rotateWelcomeY.Location = new System.Drawing.Point(83, 24);
            this.rotateWelcomeY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rotateWelcomeY.Name = "rotateWelcomeY";
            this.rotateWelcomeY.Size = new System.Drawing.Size(14, 13);
            this.rotateWelcomeY.TabIndex = 6;
            this.rotateWelcomeY.Text = "Y";
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(23, 69);
            this.rotateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(111, 24);
            this.rotateButton.TabIndex = 0;
            this.rotateButton.Text = "Поворот";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // rotateWelcomeX
            // 
            this.rotateWelcomeX.AutoSize = true;
            this.rotateWelcomeX.Location = new System.Drawing.Point(13, 24);
            this.rotateWelcomeX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rotateWelcomeX.Name = "rotateWelcomeX";
            this.rotateWelcomeX.Size = new System.Drawing.Size(14, 13);
            this.rotateWelcomeX.TabIndex = 5;
            this.rotateWelcomeX.Text = "X";
            // 
            // movingBox
            // 
            this.movingBox.Controls.Add(this.moveDYTextBox);
            this.movingBox.Controls.Add(this.moveDXTextBox);
            this.movingBox.Controls.Add(this.moveButton);
            this.movingBox.Controls.Add(this.moveWelcomeDY);
            this.movingBox.Controls.Add(this.moveWelcomeDX);
            this.movingBox.Location = new System.Drawing.Point(627, 412);
            this.movingBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movingBox.Name = "movingBox";
            this.movingBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movingBox.Size = new System.Drawing.Size(159, 98);
            this.movingBox.TabIndex = 4;
            this.movingBox.TabStop = false;
            this.movingBox.Text = "Переместить";
            // 
            // moveDYTextBox
            // 
            this.moveDYTextBox.Location = new System.Drawing.Point(44, 45);
            this.moveDYTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveDYTextBox.Name = "moveDYTextBox";
            this.moveDYTextBox.Size = new System.Drawing.Size(60, 20);
            this.moveDYTextBox.TabIndex = 21;
            this.moveDYTextBox.Text = "0";
            this.moveDYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moveDXTextBox
            // 
            this.moveDXTextBox.Location = new System.Drawing.Point(44, 22);
            this.moveDXTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveDXTextBox.Name = "moveDXTextBox";
            this.moveDXTextBox.Size = new System.Drawing.Size(60, 20);
            this.moveDXTextBox.TabIndex = 20;
            this.moveDXTextBox.Text = "0";
            this.moveDXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(23, 64);
            this.moveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(111, 28);
            this.moveButton.TabIndex = 2;
            this.moveButton.Text = "Перемещение";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // moveWelcomeDY
            // 
            this.moveWelcomeDY.AutoSize = true;
            this.moveWelcomeDY.Location = new System.Drawing.Point(14, 47);
            this.moveWelcomeDY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moveWelcomeDY.Name = "moveWelcomeDY";
            this.moveWelcomeDY.Size = new System.Drawing.Size(20, 13);
            this.moveWelcomeDY.TabIndex = 1;
            this.moveWelcomeDY.Text = "dY";
            // 
            // moveWelcomeDX
            // 
            this.moveWelcomeDX.AutoSize = true;
            this.moveWelcomeDX.Location = new System.Drawing.Point(14, 26);
            this.moveWelcomeDX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moveWelcomeDX.Name = "moveWelcomeDX";
            this.moveWelcomeDX.Size = new System.Drawing.Size(20, 13);
            this.moveWelcomeDX.TabIndex = 0;
            this.moveWelcomeDX.Text = "dX";
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(627, 514);
            this.restoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(161, 52);
            this.restoreButton.TabIndex = 5;
            this.restoreButton.Text = "Восстановить исходное изображение";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // lastStepButton
            // 
            this.lastStepButton.Location = new System.Drawing.Point(272, 548);
            this.lastStepButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastStepButton.Name = "lastStepButton";
            this.lastStepButton.Size = new System.Drawing.Size(88, 19);
            this.lastStepButton.TabIndex = 6;
            this.lastStepButton.Text = "На шаг назад";
            this.lastStepButton.UseVisualStyleBackColor = true;
            this.lastStepButton.Click += new System.EventHandler(this.LastStepButton_Click);
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Location = new System.Drawing.Point(25, 550);
            this.coordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(31, 13);
            this.coordsLabel.TabIndex = 7;
            this.coordsLabel.Text = "(0, 0)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 573);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.lastStepButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.movingBox);
            this.Controls.Add(this.rotateGroup);
            this.Controls.Add(this.scaleGroup);
            this.Controls.Add(this.imageGroup);
            this.Controls.Add(this.MainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 2";
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).EndInit();
            this.imageGroup.ResumeLayout(false);
            this.imageGroup.PerformLayout();
            this.scaleGroup.ResumeLayout(false);
            this.scaleGroup.PerformLayout();
            this.rotateGroup.ResumeLayout(false);
            this.rotateGroup.PerformLayout();
            this.movingBox.ResumeLayout(false);
            this.movingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainCanvas;
        private System.Windows.Forms.GroupBox imageGroup;
        private System.Windows.Forms.GroupBox scaleGroup;
        private System.Windows.Forms.GroupBox rotateGroup;
        private System.Windows.Forms.GroupBox movingBox;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button lastStepButton;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Button imageBuildButton;
        private System.Windows.Forms.Label dWelcome;
        private System.Windows.Forms.Label cWelcome;
        private System.Windows.Forms.Label parabolaEquation;
        private System.Windows.Forms.Label rWelcome;
        private System.Windows.Forms.Label bWelcome;
        private System.Windows.Forms.Label aWelcome;
        private System.Windows.Forms.Label circleEquation;
        private System.Windows.Forms.TextBox scaleKYtextBox;
        private System.Windows.Forms.TextBox scaleYtextBox;
        private System.Windows.Forms.TextBox scaleKXtextBox;
        private System.Windows.Forms.TextBox scaleXtextBox;
        private System.Windows.Forms.Label scaleWelcomeKY;
        private System.Windows.Forms.Label scaleWelcomeKX;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.Label ScaleWelcomeY;
        private System.Windows.Forms.Label ScaleWelcomeX;
        private System.Windows.Forms.TextBox rotateAngleTextBox;
        private System.Windows.Forms.TextBox rotateYTextBox;
        private System.Windows.Forms.TextBox rotateXTextBox;
        private System.Windows.Forms.Label angleWelcome;
        private System.Windows.Forms.Label rotateWelcomeY;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Label rotateWelcomeX;
        private System.Windows.Forms.TextBox moveDYTextBox;
        private System.Windows.Forms.TextBox moveDXTextBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label moveWelcomeDY;
        private System.Windows.Forms.Label moveWelcomeDX;
        private System.Windows.Forms.Label coordsLabel;
    }
}

