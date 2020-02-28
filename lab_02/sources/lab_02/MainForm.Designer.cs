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
            this.scaleGroup = new System.Windows.Forms.GroupBox();
            this.rotateGroup = new System.Windows.Forms.GroupBox();
            this.movingBox = new System.Windows.Forms.GroupBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.lastStepButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCanvas
            // 
            this.MainCanvas.BackColor = System.Drawing.SystemColors.Info;
            this.MainCanvas.Location = new System.Drawing.Point(6, 7);
            this.MainCanvas.Name = "MainCanvas";
            this.MainCanvas.Size = new System.Drawing.Size(820, 660);
            this.MainCanvas.TabIndex = 0;
            this.MainCanvas.TabStop = false;
            // 
            // imageGroup
            // 
            this.imageGroup.Location = new System.Drawing.Point(836, 14);
            this.imageGroup.Name = "imageGroup";
            this.imageGroup.Size = new System.Drawing.Size(215, 217);
            this.imageGroup.TabIndex = 1;
            this.imageGroup.TabStop = false;
            this.imageGroup.Text = "Задание изображения";
            // 
            // scaleGroup
            // 
            this.scaleGroup.Location = new System.Drawing.Point(836, 245);
            this.scaleGroup.Name = "scaleGroup";
            this.scaleGroup.Size = new System.Drawing.Size(214, 120);
            this.scaleGroup.TabIndex = 2;
            this.scaleGroup.TabStop = false;
            this.scaleGroup.Text = "Масштабировать";
            // 
            // rotateGroup
            // 
            this.rotateGroup.Location = new System.Drawing.Point(836, 380);
            this.rotateGroup.Name = "rotateGroup";
            this.rotateGroup.Size = new System.Drawing.Size(213, 120);
            this.rotateGroup.TabIndex = 3;
            this.rotateGroup.TabStop = false;
            this.rotateGroup.Text = "Повернуть";
            // 
            // movingBox
            // 
            this.movingBox.Location = new System.Drawing.Point(836, 507);
            this.movingBox.Name = "movingBox";
            this.movingBox.Size = new System.Drawing.Size(212, 120);
            this.movingBox.TabIndex = 4;
            this.movingBox.TabStop = false;
            this.movingBox.Text = "Переместить";
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(847, 633);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(192, 64);
            this.restoreButton.TabIndex = 5;
            this.restoreButton.Text = "Восстановить исходное изображение";
            this.restoreButton.UseVisualStyleBackColor = true;
            // 
            // lastStepButton
            // 
            this.lastStepButton.Location = new System.Drawing.Point(362, 674);
            this.lastStepButton.Name = "lastStepButton";
            this.lastStepButton.Size = new System.Drawing.Size(118, 23);
            this.lastStepButton.TabIndex = 6;
            this.lastStepButton.Text = "На шаг назад";
            this.lastStepButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 705);
            this.Controls.Add(this.lastStepButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.movingBox);
            this.Controls.Add(this.rotateGroup);
            this.Controls.Add(this.scaleGroup);
            this.Controls.Add(this.imageGroup);
            this.Controls.Add(this.MainCanvas);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 2";
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainCanvas;
        private System.Windows.Forms.GroupBox imageGroup;
        private System.Windows.Forms.GroupBox scaleGroup;
        private System.Windows.Forms.GroupBox rotateGroup;
        private System.Windows.Forms.GroupBox movingBox;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button lastStepButton;
    }
}

