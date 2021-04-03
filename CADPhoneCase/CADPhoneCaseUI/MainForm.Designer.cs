
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
            this.components = new System.ComponentModel.Container();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBodelButton
            // 
            this.CreateBodelButton.Location = new System.Drawing.Point(533, 270);
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
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина чехла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина чехла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высота чехла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ширина отверстия для камеры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Длина отверстия для камеры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Зазор между отверстием для \r\nкамеры и правой стенкой чехла";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Зазор между отверстием для \r\nкамеры и верхней стенкой чехла";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ширина отверстия для зарядки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Высота отверстия для зарядки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Диаметр отверстия для наушников";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Зазор между отверстием \r\nдля наушников и левой стенкой чехла";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Высота отверстия для боковых кнопок";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ширина отверстия для боковых кнопок";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 26);
            this.label14.TabIndex = 14;
            this.label14.Text = "Зазор между отверстием для \r\nбоковых кнопок и верхним правым углом";
            // 
            // CaseLengthTextBox
            // 
            this.CaseLengthTextBox.Location = new System.Drawing.Point(232, 17);
            this.CaseLengthTextBox.Name = "CaseLengthTextBox";
            this.CaseLengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CaseLengthTextBox.TabIndex = 1;
            this.CaseLengthTextBox.Text = "200";
            this.CaseLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CaseLengthTextBox.Leave += new System.EventHandler(this.CaseLengthTextBox_Leave);
            // 
            // CaseWidthTextBox
            // 
            this.CaseWidthTextBox.Location = new System.Drawing.Point(232, 43);
            this.CaseWidthTextBox.Name = "CaseWidthTextBox";
            this.CaseWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CaseWidthTextBox.TabIndex = 2;
            this.CaseWidthTextBox.Text = "100";
            this.CaseWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CaseWidthTextBox.Leave += new System.EventHandler(this.CaseWidthTextBox_Leave);
            // 
            // CaseHeightTextBox
            // 
            this.CaseHeightTextBox.Location = new System.Drawing.Point(232, 69);
            this.CaseHeightTextBox.Name = "CaseHeightTextBox";
            this.CaseHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.CaseHeightTextBox.TabIndex = 3;
            this.CaseHeightTextBox.Text = "15";
            this.CaseHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CaseHeightTextBox.Leave += new System.EventHandler(this.CaseHeightTextBox_Leave);
            // 
            // CameraHoleWidthTextBox
            // 
            this.CameraHoleWidthTextBox.Location = new System.Drawing.Point(232, 19);
            this.CameraHoleWidthTextBox.Name = "CameraHoleWidthTextBox";
            this.CameraHoleWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraHoleWidthTextBox.TabIndex = 11;
            this.CameraHoleWidthTextBox.Text = "20";
            this.CameraHoleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CameraHoleWidthTextBox.Leave += new System.EventHandler(this.CameraHoleWidthTextBox_Leave);
            // 
            // CameraHoleLengthTextBox
            // 
            this.CameraHoleLengthTextBox.Location = new System.Drawing.Point(232, 45);
            this.CameraHoleLengthTextBox.Name = "CameraHoleLengthTextBox";
            this.CameraHoleLengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraHoleLengthTextBox.TabIndex = 12;
            this.CameraHoleLengthTextBox.Text = "30";
            this.CameraHoleLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CameraHoleLengthTextBox.Leave += new System.EventHandler(this.CameraHoleLengthTextBox_Leave);
            // 
            // CameraRightGapTextBox
            // 
            this.CameraRightGapTextBox.Location = new System.Drawing.Point(232, 71);
            this.CameraRightGapTextBox.Name = "CameraRightGapTextBox";
            this.CameraRightGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraRightGapTextBox.TabIndex = 13;
            this.CameraRightGapTextBox.Text = "20";
            this.CameraRightGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CameraRightGapTextBox.Leave += new System.EventHandler(this.CameraRightGapTextBox_Leave);
            // 
            // CameraTopGapTextBox
            // 
            this.CameraTopGapTextBox.Location = new System.Drawing.Point(232, 97);
            this.CameraTopGapTextBox.Name = "CameraTopGapTextBox";
            this.CameraTopGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.CameraTopGapTextBox.TabIndex = 14;
            this.CameraTopGapTextBox.Text = "20";
            this.CameraTopGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CameraTopGapTextBox.Leave += new System.EventHandler(this.CameraTopGapTextBox_Leave);
            // 
            // ChargerHoleWidthTextBox
            // 
            this.ChargerHoleWidthTextBox.Location = new System.Drawing.Point(232, 13);
            this.ChargerHoleWidthTextBox.Name = "ChargerHoleWidthTextBox";
            this.ChargerHoleWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.ChargerHoleWidthTextBox.TabIndex = 4;
            this.ChargerHoleWidthTextBox.Text = "15";
            this.ChargerHoleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.ChargerHoleWidthTextBox.Leave += new System.EventHandler(this.ChargerHoleWidthTextBox_Leave);
            // 
            // ChargerHoleHeightTextBox
            // 
            this.ChargerHoleHeightTextBox.Location = new System.Drawing.Point(232, 39);
            this.ChargerHoleHeightTextBox.Name = "ChargerHoleHeightTextBox";
            this.ChargerHoleHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.ChargerHoleHeightTextBox.TabIndex = 5;
            this.ChargerHoleHeightTextBox.Text = "5";
            this.ChargerHoleHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.ChargerHoleHeightTextBox.Leave += new System.EventHandler(this.ChargerHoleHeightTextBox_Leave);
            // 
            // MiniJackDiameterTextBox
            // 
            this.MiniJackDiameterTextBox.Location = new System.Drawing.Point(232, 19);
            this.MiniJackDiameterTextBox.Name = "MiniJackDiameterTextBox";
            this.MiniJackDiameterTextBox.Size = new System.Drawing.Size(70, 20);
            this.MiniJackDiameterTextBox.TabIndex = 6;
            this.MiniJackDiameterTextBox.Text = "3,5";
            this.MiniJackDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.MiniJackDiameterTextBox.Leave += new System.EventHandler(this.MiniJackDiameterTextBox_Leave);
            // 
            // MiniJackGapTextBox
            // 
            this.MiniJackGapTextBox.Location = new System.Drawing.Point(232, 45);
            this.MiniJackGapTextBox.Name = "MiniJackGapTextBox";
            this.MiniJackGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.MiniJackGapTextBox.TabIndex = 7;
            this.MiniJackGapTextBox.Text = "20";
            this.MiniJackGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.MiniJackGapTextBox.Leave += new System.EventHandler(this.MiniJackGapTextBox_Leave);
            // 
            // SideButtonsHoleHeightTextBox
            // 
            this.SideButtonsHoleHeightTextBox.Location = new System.Drawing.Point(232, 19);
            this.SideButtonsHoleHeightTextBox.Name = "SideButtonsHoleHeightTextBox";
            this.SideButtonsHoleHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.SideButtonsHoleHeightTextBox.TabIndex = 8;
            this.SideButtonsHoleHeightTextBox.Text = "4";
            this.SideButtonsHoleHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.SideButtonsHoleHeightTextBox.Leave += new System.EventHandler(this.SideButtonsHoleHeightTextBox_Leave);
            // 
            // SideButtonsHoleWidthTextBox
            // 
            this.SideButtonsHoleWidthTextBox.Location = new System.Drawing.Point(232, 45);
            this.SideButtonsHoleWidthTextBox.Name = "SideButtonsHoleWidthTextBox";
            this.SideButtonsHoleWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.SideButtonsHoleWidthTextBox.TabIndex = 9;
            this.SideButtonsHoleWidthTextBox.Text = "30";
            this.SideButtonsHoleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.SideButtonsHoleWidthTextBox.Leave += new System.EventHandler(this.SideButtonsHoleWidthTextBox_Leave);
            // 
            // SideButtonsGapTextBox
            // 
            this.SideButtonsGapTextBox.Location = new System.Drawing.Point(232, 71);
            this.SideButtonsGapTextBox.Name = "SideButtonsGapTextBox";
            this.SideButtonsGapTextBox.Size = new System.Drawing.Size(70, 20);
            this.SideButtonsGapTextBox.TabIndex = 10;
            this.SideButtonsGapTextBox.Text = "20";
            this.SideButtonsGapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.SideButtonsGapTextBox.Leave += new System.EventHandler(this.SideButtonsGapTextBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CaseLengthTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CaseWidthTextBox);
            this.groupBox1.Controls.Add(this.CaseHeightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные размеры чехла";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CameraHoleLengthTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CameraRightGapTextBox);
            this.groupBox2.Controls.Add(this.CameraTopGapTextBox);
            this.groupBox2.Controls.Add(this.CameraHoleWidthTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(325, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры отверстия для камеры";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ChargerHoleWidthTextBox);
            this.groupBox3.Controls.Add(this.ChargerHoleHeightTextBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Размеры отверстия для зарядки";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.MiniJackDiameterTextBox);
            this.groupBox4.Controls.Add(this.MiniJackGapTextBox);
            this.groupBox4.Location = new System.Drawing.Point(8, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 81);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Размеры отверстия для наушников";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SideButtonsHoleWidthTextBox);
            this.groupBox5.Controls.Add(this.SideButtonsGapTextBox);
            this.groupBox5.Controls.Add(this.SideButtonsHoleHeightTextBox);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(325, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 111);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Размеры отверстия для боковых кнопок";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 299);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateBodelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 278);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADPhoneCase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

