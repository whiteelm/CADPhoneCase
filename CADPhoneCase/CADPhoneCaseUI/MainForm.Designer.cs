
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
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.A1TextBox = new System.Windows.Forms.TextBox();
            this.B1TextBox = new System.Windows.Forms.TextBox();
            this.S0TextBox = new System.Windows.Forms.TextBox();
            this.S1TextBox = new System.Windows.Forms.TextBox();
            this.A2TextBox = new System.Windows.Forms.TextBox();
            this.B2TextBox = new System.Windows.Forms.TextBox();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.S2TextBox = new System.Windows.Forms.TextBox();
            this.A3TextBox = new System.Windows.Forms.TextBox();
            this.B3TextBox = new System.Windows.Forms.TextBox();
            this.S3TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateBodelButton
            // 
            this.CreateBodelButton.Location = new System.Drawing.Point(250, 228);
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
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина чехла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина чехла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высота чехла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ширина отверстия для камеры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Длина отверстия для камеры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Зазор между отверстием для \r\nкамеры и правой стенкой чехла";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Зазор между отверстием для \r\nкамеры и верхней стенкой чехла";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ширина отверстия для зарядки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Высота отверстия для зарядки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Диаметр отверстия для наушников";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Зазор между отверстием \r\nдля наушников и левой стенкой чехла";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Высота отверстия для боковых кнопок";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ширина отверстия для боковых кнопок";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 26);
            this.label14.TabIndex = 14;
            this.label14.Text = "Зазор между отверстием для \r\nбоковых кнопок и верхним правым углом";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(12, 19);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(70, 20);
            this.ATextBox.TabIndex = 1;
            this.ATextBox.Text = "200";
            this.ATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(12, 45);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(70, 20);
            this.BTextBox.TabIndex = 2;
            this.BTextBox.Text = "100";
            this.BTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(12, 71);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(70, 20);
            this.HTextBox.TabIndex = 3;
            this.HTextBox.Text = "15";
            this.HTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // A1TextBox
            // 
            this.A1TextBox.Location = new System.Drawing.Point(12, 97);
            this.A1TextBox.Name = "A1TextBox";
            this.A1TextBox.Size = new System.Drawing.Size(70, 20);
            this.A1TextBox.TabIndex = 4;
            this.A1TextBox.Text = "20";
            this.A1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // B1TextBox
            // 
            this.B1TextBox.Location = new System.Drawing.Point(12, 123);
            this.B1TextBox.Name = "B1TextBox";
            this.B1TextBox.Size = new System.Drawing.Size(70, 20);
            this.B1TextBox.TabIndex = 5;
            this.B1TextBox.Text = "30";
            this.B1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // S0TextBox
            // 
            this.S0TextBox.Location = new System.Drawing.Point(12, 149);
            this.S0TextBox.Name = "S0TextBox";
            this.S0TextBox.Size = new System.Drawing.Size(70, 20);
            this.S0TextBox.TabIndex = 6;
            this.S0TextBox.Text = "20";
            this.S0TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // S1TextBox
            // 
            this.S1TextBox.Location = new System.Drawing.Point(12, 179);
            this.S1TextBox.Name = "S1TextBox";
            this.S1TextBox.Size = new System.Drawing.Size(70, 20);
            this.S1TextBox.TabIndex = 7;
            this.S1TextBox.Text = "20";
            this.S1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // A2TextBox
            // 
            this.A2TextBox.Location = new System.Drawing.Point(298, 19);
            this.A2TextBox.Name = "A2TextBox";
            this.A2TextBox.Size = new System.Drawing.Size(70, 20);
            this.A2TextBox.TabIndex = 8;
            this.A2TextBox.Text = "15";
            this.A2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // B2TextBox
            // 
            this.B2TextBox.Location = new System.Drawing.Point(298, 45);
            this.B2TextBox.Name = "B2TextBox";
            this.B2TextBox.Size = new System.Drawing.Size(70, 20);
            this.B2TextBox.TabIndex = 9;
            this.B2TextBox.Text = "5";
            this.B2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // DTextBox
            // 
            this.DTextBox.Location = new System.Drawing.Point(298, 153);
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.Size = new System.Drawing.Size(70, 20);
            this.DTextBox.TabIndex = 13;
            this.DTextBox.Text = "4";
            this.DTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // S2TextBox
            // 
            this.S2TextBox.Location = new System.Drawing.Point(298, 179);
            this.S2TextBox.Name = "S2TextBox";
            this.S2TextBox.Size = new System.Drawing.Size(70, 20);
            this.S2TextBox.TabIndex = 14;
            this.S2TextBox.Text = "5";
            this.S2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // A3TextBox
            // 
            this.A3TextBox.Location = new System.Drawing.Point(298, 71);
            this.A3TextBox.Name = "A3TextBox";
            this.A3TextBox.Size = new System.Drawing.Size(70, 20);
            this.A3TextBox.TabIndex = 10;
            this.A3TextBox.Text = "4";
            this.A3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // B3TextBox
            // 
            this.B3TextBox.Location = new System.Drawing.Point(298, 97);
            this.B3TextBox.Name = "B3TextBox";
            this.B3TextBox.Size = new System.Drawing.Size(70, 20);
            this.B3TextBox.TabIndex = 11;
            this.B3TextBox.Text = "20";
            this.B3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // S3TextBox
            // 
            this.S3TextBox.Location = new System.Drawing.Point(298, 123);
            this.S3TextBox.Name = "S3TextBox";
            this.S3TextBox.Size = new System.Drawing.Size(70, 20);
            this.S3TextBox.TabIndex = 12;
            this.S3TextBox.Text = "20";
            this.S3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 263);
            this.Controls.Add(this.S3TextBox);
            this.Controls.Add(this.B3TextBox);
            this.Controls.Add(this.A3TextBox);
            this.Controls.Add(this.S2TextBox);
            this.Controls.Add(this.DTextBox);
            this.Controls.Add(this.B2TextBox);
            this.Controls.Add(this.A2TextBox);
            this.Controls.Add(this.S1TextBox);
            this.Controls.Add(this.S0TextBox);
            this.Controls.Add(this.B1TextBox);
            this.Controls.Add(this.A1TextBox);
            this.Controls.Add(this.HTextBox);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
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
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.TextBox A1TextBox;
        private System.Windows.Forms.TextBox B1TextBox;
        private System.Windows.Forms.TextBox S0TextBox;
        private System.Windows.Forms.TextBox S1TextBox;
        private System.Windows.Forms.TextBox A2TextBox;
        private System.Windows.Forms.TextBox B2TextBox;
        private System.Windows.Forms.TextBox DTextBox;
        private System.Windows.Forms.TextBox S2TextBox;
        private System.Windows.Forms.TextBox A3TextBox;
        private System.Windows.Forms.TextBox B3TextBox;
        private System.Windows.Forms.TextBox S3TextBox;
    }
}

