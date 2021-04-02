
namespace CADPhoneCaseUI
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
            this.CreateBodelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CaseLengthTextBox = new System.Windows.Forms.TextBox();
            this.CaseWidthTextBox = new System.Windows.Forms.TextBox();
            this.CaseHeightTextBox = new System.Windows.Forms.TextBox();
            this.CameraHoleWidthTextBox = new System.Windows.Forms.TextBox();
            this.CameraHoleLengthTextBox = new System.Windows.Forms.TextBox();
            this.CameraRightGapTextBox = new System.Windows.Forms.TextBox();
            this.CameraTopGapTextBox = new System.Windows.Forms.TextBox();
            this.ChargerHoleWidthTextBox = new System.Windows.Forms.TextBox();
            this.ChargerHoleHeightTextBox = new System.Windows.Forms.TextBox();
            this.MiniJackDiameterTextBox = new System.Windows.Forms.TextBox();
            this.MiniJackGapTextBox = new System.Windows.Forms.TextBox();
            this.SideButtonsHoleHeightTextBox = new System.Windows.Forms.TextBox();
            this.SideButtonsHoleWidthTextBox = new System.Windows.Forms.TextBox();
            this.SideButtonsGapTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateBodelButton
            // 
            this.CreateBodelButton.Location = new System.Drawing.Point(252, 212);
            this.CreateBodelButton.Name = "CreateBodelButton";
            this.CreateBodelButton.Size = new System.Drawing.Size(100, 23);
            this.CreateBodelButton.TabIndex = 15;
            this.CreateBodelButton.Text = "Построить";
            this.CreateBodelButton.UseVisualStyleBackColor = true;
            this.CreateBodelButton.Click += new System.EventHandler(this.CreateModelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина чехла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина чехла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высота чехла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ширина отверстия для камеры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Длина отверстия для камеры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Зазор между отверстием для \r\nкамеры и правой стенкой чехла";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Зазор между отверстием для \r\nкамеры и верхней стенкой чехла";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ширина отверстия для зарядки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Высота отверстия для зарядки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Диаметр отверстия для наушников";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Зазор между отверстием \r\nдля наушников и левой стенкой чехла";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Высота отверстия для боковых кнопок";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ширина отверстия для боковых кнопок";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 26);
            this.label14.TabIndex = 14;
            this.label14.Text = "Зазор между отверстием для \r\nбоковых кнопок и верхним правым углом";
            // 
            // CaseLengthTextBox
            // 
            this.CaseLengthTextBox.Location = new System.Drawing.Point(188, 12);
            this.CaseLengthTextBox.Name = "CaseLengthTextBox";
            this.CaseLengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CaseLengthTextBox.TabIndex = 1;
            this.CaseLengthTextBox.Text = "200";
            this.CaseLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // CaseWidthTextBox
            // 
            this.CaseWidthTextBox.Location = new System.Drawing.Point(188, 38);
            this.CaseWidthTextBox.Name = "CaseWidthTextBox";
            this.CaseWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CaseWidthTextBox.TabIndex = 2;
            this.CaseWidthTextBox.Text = "100";
            this.CaseWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // CaseHeightTextBox
            // 
            this.CaseHeightTextBox.Location = new System.Drawing.Point(188, 64);
            this.CaseHeightTextBox.Name = "CaseHeightTextBox";
            this.CaseHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.CaseHeightTextBox.TabIndex = 3;
            this.CaseHeightTextBox.Text = "15";
            this.CaseHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // CameraHoleWidthTextBox
            // 
            this.CameraHoleWidthTextBox.Location = new System.Drawing.Point(188, 90);
            this.CameraHoleWidthTextBox.Name = "CameraHoleWidthTextBox";
            this.CameraHoleWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraHoleWidthTextBox.TabIndex = 4;
            this.CameraHoleWidthTextBox.Text = "20";
            this.CameraHoleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // CameraHoleLengthTextBox
            // 
            this.CameraHoleLengthTextBox.Location = new System.Drawing.Point(188, 116);
            this.CameraHoleLengthTextBox.Name = "CameraHoleLengthTextBox";
            this.CameraHoleLengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraHoleLengthTextBox.TabIndex = 5;
            this.CameraHoleLengthTextBox.Text = "30";
            this.CameraHoleLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // CameraRightGapTextBox
            // 
            this.CameraRightGapTextBox.Location = new System.Drawing.Point(188, 142);
            this.CameraRightGapTextBox.Name = "CameraRightGapTextBox";
            this.CameraRightGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraRightGapTextBox.TabIndex = 6;
            this.CameraRightGapTextBox.Text = "20";
            this.CameraRightGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // CameraTopGapTextBox
            // 
            this.CameraTopGapTextBox.Location = new System.Drawing.Point(188, 172);
            this.CameraTopGapTextBox.Name = "CameraTopGapTextBox";
            this.CameraTopGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraTopGapTextBox.TabIndex = 7;
            this.CameraTopGapTextBox.Text = "20";
            this.CameraTopGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // ChargerHoleWidthTextBox
            // 
            this.ChargerHoleWidthTextBox.Location = new System.Drawing.Point(512, 12);
            this.ChargerHoleWidthTextBox.Name = "ChargerHoleWidthTextBox";
            this.ChargerHoleWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.ChargerHoleWidthTextBox.TabIndex = 8;
            this.ChargerHoleWidthTextBox.Text = "15";
            this.ChargerHoleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // ChargerHoleHeightTextBox
            // 
            this.ChargerHoleHeightTextBox.Location = new System.Drawing.Point(512, 38);
            this.ChargerHoleHeightTextBox.Name = "ChargerHoleHeightTextBox";
            this.ChargerHoleHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.ChargerHoleHeightTextBox.TabIndex = 9;
            this.ChargerHoleHeightTextBox.Text = "5";
            this.ChargerHoleHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // MiniJackDiameterTextBox
            // 
            this.MiniJackDiameterTextBox.Location = new System.Drawing.Point(512, 146);
            this.MiniJackDiameterTextBox.Name = "MiniJackDiameterTextBox";
            this.MiniJackDiameterTextBox.Size = new System.Drawing.Size(70, 20);
            this.MiniJackDiameterTextBox.TabIndex = 13;
            this.MiniJackDiameterTextBox.Text = "3,5";
            this.MiniJackDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // MiniJackGapTextBox
            // 
            this.MiniJackGapTextBox.Location = new System.Drawing.Point(512, 172);
            this.MiniJackGapTextBox.Name = "MiniJackGapTextBox";
            this.MiniJackGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.MiniJackGapTextBox.TabIndex = 14;
            this.MiniJackGapTextBox.Text = "20";
            this.MiniJackGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // SideButtonsHoleHeightTextBox
            // 
            this.SideButtonsHoleHeightTextBox.Location = new System.Drawing.Point(512, 64);
            this.SideButtonsHoleHeightTextBox.Name = "SideButtonsHoleHeightTextBox";
            this.SideButtonsHoleHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.SideButtonsHoleHeightTextBox.TabIndex = 10;
            this.SideButtonsHoleHeightTextBox.Text = "4";
            this.SideButtonsHoleHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // SideButtonsHoleWidthTextBox
            // 
            this.SideButtonsHoleWidthTextBox.Location = new System.Drawing.Point(512, 90);
            this.SideButtonsHoleWidthTextBox.Name = "SideButtonsHoleWidthTextBox";
            this.SideButtonsHoleWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.SideButtonsHoleWidthTextBox.TabIndex = 11;
            this.SideButtonsHoleWidthTextBox.Text = "30";
            this.SideButtonsHoleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // SideButtonsGapTextBox
            // 
            this.SideButtonsGapTextBox.Location = new System.Drawing.Point(512, 116);
            this.SideButtonsGapTextBox.Name = "SideButtonsGapTextBox";
            this.SideButtonsGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.SideButtonsGapTextBox.TabIndex = 12;
            this.SideButtonsGapTextBox.Text = "20";
            this.SideButtonsGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 263);
            this.Controls.Add(this.SideButtonsGapTextBox);
            this.Controls.Add(this.SideButtonsHoleWidthTextBox);
            this.Controls.Add(this.SideButtonsHoleHeightTextBox);
            this.Controls.Add(this.MiniJackGapTextBox);
            this.Controls.Add(this.MiniJackDiameterTextBox);
            this.Controls.Add(this.ChargerHoleHeightTextBox);
            this.Controls.Add(this.ChargerHoleWidthTextBox);
            this.Controls.Add(this.CameraTopGapTextBox);
            this.Controls.Add(this.CameraRightGapTextBox);
            this.Controls.Add(this.CameraHoleLengthTextBox);
            this.Controls.Add(this.CameraHoleWidthTextBox);
            this.Controls.Add(this.CaseHeightTextBox);
            this.Controls.Add(this.CaseWidthTextBox);
            this.Controls.Add(this.CaseLengthTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateBodelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 298);
            this.MinimumSize = new System.Drawing.Size(650, 298);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADPhoneCase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBodelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CaseLengthTextBox;
        private System.Windows.Forms.TextBox CaseWidthTextBox;
        private System.Windows.Forms.TextBox CaseHeightTextBox;
        private System.Windows.Forms.TextBox CameraHoleWidthTextBox;
        private System.Windows.Forms.TextBox CameraHoleLengthTextBox;
        private System.Windows.Forms.TextBox CameraRightGapTextBox;
        private System.Windows.Forms.TextBox CameraTopGapTextBox;
        private System.Windows.Forms.TextBox ChargerHoleWidthTextBox;
        private System.Windows.Forms.TextBox ChargerHoleHeightTextBox;
        private System.Windows.Forms.TextBox MiniJackDiameterTextBox;
        private System.Windows.Forms.TextBox MiniJackGapTextBox;
        private System.Windows.Forms.TextBox SideButtonsHoleHeightTextBox;
        private System.Windows.Forms.TextBox SideButtonsHoleWidthTextBox;
        private System.Windows.Forms.TextBox SideButtonsGapTextBox;
    }
}

