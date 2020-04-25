namespace lab_06
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
            this.radioButtonWayQuick = new System.Windows.Forms.RadioButton();
            this.radioButtonWayStep = new System.Windows.Forms.RadioButton();
            this.groupBoxWay = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonHorizontal = new System.Windows.Forms.Button();
            this.buttonVertical = new System.Windows.Forms.Button();
            this.groupBoxSpecific = new System.Windows.Forms.GroupBox();
            this.buttonLastDelete = new System.Windows.Forms.Button();
            this.resultMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonEnterPeak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonColorFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.groupColor.SuspendLayout();
            this.groupBoxWay.SuspendLayout();
            this.groupBoxSpecific.SuspendLayout();
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
            this.groupColor.Controls.Add(this.buttonColorFill);
            this.groupColor.Controls.Add(this.label3);
            this.groupColor.Controls.Add(this.label6);
            this.groupColor.Controls.Add(this.colorButton);
            this.groupColor.Location = new System.Drawing.Point(631, 70);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(185, 82);
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
            // radioButtonWayQuick
            // 
            this.radioButtonWayQuick.AutoSize = true;
            this.radioButtonWayQuick.Checked = true;
            this.radioButtonWayQuick.Location = new System.Drawing.Point(10, 19);
            this.radioButtonWayQuick.Name = "radioButtonWayQuick";
            this.radioButtonWayQuick.Size = new System.Drawing.Size(97, 17);
            this.radioButtonWayQuick.TabIndex = 54;
            this.radioButtonWayQuick.TabStop = true;
            this.radioButtonWayQuick.Text = "Без задержки";
            this.radioButtonWayQuick.UseVisualStyleBackColor = true;
            // 
            // radioButtonWayStep
            // 
            this.radioButtonWayStep.AutoSize = true;
            this.radioButtonWayStep.Location = new System.Drawing.Point(10, 42);
            this.radioButtonWayStep.Name = "radioButtonWayStep";
            this.radioButtonWayStep.Size = new System.Drawing.Size(91, 17);
            this.radioButtonWayStep.TabIndex = 55;
            this.radioButtonWayStep.Text = "С задержкой";
            this.radioButtonWayStep.UseVisualStyleBackColor = true;
            // 
            // groupBoxWay
            // 
            this.groupBoxWay.Controls.Add(this.radioButtonWayQuick);
            this.groupBoxWay.Controls.Add(this.radioButtonWayStep);
            this.groupBoxWay.Location = new System.Drawing.Point(631, 158);
            this.groupBoxWay.Name = "groupBoxWay";
            this.groupBoxWay.Size = new System.Drawing.Size(185, 66);
            this.groupBoxWay.TabIndex = 56;
            this.groupBoxWay.TabStop = false;
            this.groupBoxWay.Text = "Способ вывода";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(631, 39);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 21);
            this.buttonCancel.TabIndex = 58;
            this.buttonCancel.Text = "Отменить заполнение";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
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
            this.groupBoxSpecific.Location = new System.Drawing.Point(631, 230);
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
            // resultMessage
            // 
            this.resultMessage.AutoSize = true;
            this.resultMessage.Location = new System.Drawing.Point(634, 442);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(75, 13);
            this.resultMessage.TabIndex = 62;
            this.resultMessage.Text = "resultMessage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Y";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(662, 345);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(47, 20);
            this.textBoxX.TabIndex = 65;
            this.textBoxX.Text = "100";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(757, 345);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(47, 20);
            this.textBoxY.TabIndex = 66;
            this.textBoxY.Text = "100";
            // 
            // buttonEnterPeak
            // 
            this.buttonEnterPeak.Location = new System.Drawing.Point(641, 371);
            this.buttonEnterPeak.Name = "buttonEnterPeak";
            this.buttonEnterPeak.Size = new System.Drawing.Size(163, 35);
            this.buttonEnterPeak.TabIndex = 67;
            this.buttonEnterPeak.Text = "Ввести вершину";
            this.buttonEnterPeak.UseVisualStyleBackColor = true;
            this.buttonEnterPeak.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Цвет заполнения";
            // 
            // buttonColorFill
            // 
            this.buttonColorFill.BackColor = System.Drawing.Color.Black;
            this.buttonColorFill.Location = new System.Drawing.Point(111, 49);
            this.buttonColorFill.Name = "buttonColorFill";
            this.buttonColorFill.Size = new System.Drawing.Size(63, 27);
            this.buttonColorFill.TabIndex = 38;
            this.buttonColorFill.UseVisualStyleBackColor = false;
            this.buttonColorFill.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 641);
            this.Controls.Add(this.buttonEnterPeak);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.groupBoxSpecific);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxWay);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.mainCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 6. Хетагуров Павел";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.groupBoxWay.ResumeLayout(false);
            this.groupBoxWay.PerformLayout();
            this.groupBoxSpecific.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton radioButtonWayQuick;
        private System.Windows.Forms.RadioButton radioButtonWayStep;
        private System.Windows.Forms.GroupBox groupBoxWay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonHorizontal;
        private System.Windows.Forms.Button buttonVertical;
        private System.Windows.Forms.GroupBox groupBoxSpecific;
        private System.Windows.Forms.Button buttonLastDelete;
        private System.Windows.Forms.Label resultMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonEnterPeak;
        private System.Windows.Forms.Button buttonColorFill;
        private System.Windows.Forms.Label label3;
    }
}

