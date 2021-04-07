using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CADPhoneCase;
using KompasInteractor;

namespace CADPhoneCaseUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса параметров.
        /// </summary>
        private PhoneCaseParameters _parameters;

        /// <summary>
        /// Экземпляр класса соединения с компасом.
        /// </summary>
        private KompasConnector _kompas;

        public MainForm()
        {
            InitializeComponent();
            _kompas = new KompasConnector();
            _parameters = new PhoneCaseParameters();
        }


        private void CreateModelButton_Click(object sender, EventArgs e)
        {
            CreatePhoneCase();
        }
        
        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b,]");
        }

        /// <summary>
        /// Создание модели чехла.
        /// </summary>
        private void CreatePhoneCase()
        {
            try
            {
                _parameters.CaseLength = double.Parse(CaseLengthTextBox.Text);
                _parameters.CaseWidth = double.Parse(CaseWidthTextBox.Text);
                _parameters.CaseHeight = double.Parse(CaseHeightTextBox.Text);
                _parameters.CameraHoleWidth = double.Parse(CameraHoleWidthTextBox.Text);
                _parameters.CameraHoleLength = double.Parse(CameraHoleLengthTextBox.Text);
                _parameters.CameraRightGap = double.Parse(CameraRightGapTextBox.Text);
                _parameters.CameraTopGap = double.Parse(CameraTopGapTextBox.Text);
                _parameters.ChargerHoleWidth = double.Parse(ChargerHoleWidthTextBox.Text);
                _parameters.ChargerHoleHeight = double.Parse(ChargerHoleHeightTextBox.Text);
                _parameters.MiniJackDiameter = double.Parse(MiniJackDiameterTextBox.Text);
                _parameters.MiniJackGap = double.Parse(MiniJackGapTextBox.Text);
                _parameters.SideButtonsHoleHeight = double.Parse(SideButtonsHoleHeightTextBox.Text);
                _parameters.SideButtonsHoleWidth = double.Parse(SideButtonsHoleWidthTextBox.Text);
                _parameters.SideButtonsGap = double.Parse(SideButtonsGapTextBox.Text);
                
                _kompas.OpenKompas();
                var model = new PhoneCaseModeler(_kompas.Kompas);
                model.CreateModel(_parameters);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void CaseLengthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CaseLength = double.Parse(CaseLengthTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CaseLengthTextBox.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CaseLengthTextBox.Focus();
            }
        }

        private void CaseWidthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CaseWidth = double.Parse(CaseWidthTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CaseHeightTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CaseHeight = double.Parse(CaseHeightTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChargerHoleWidthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.ChargerHoleWidth = double.Parse(ChargerHoleWidthTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChargerHoleHeightTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.ChargerHoleHeight = double.Parse(ChargerHoleHeightTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MiniJackDiameterTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.MiniJackDiameter = double.Parse(MiniJackDiameterTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MiniJackGapTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.MiniJackGap = double.Parse(MiniJackGapTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SideButtonsHoleHeightTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.SideButtonsHoleHeight = double.Parse(SideButtonsHoleHeightTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SideButtonsHoleWidthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.SideButtonsHoleWidth = double.Parse(SideButtonsHoleWidthTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SideButtonsGapTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.SideButtonsGap = double.Parse(SideButtonsGapTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CameraHoleWidthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CameraHoleWidth = double.Parse(CameraHoleWidthTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CameraHoleLengthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CameraHoleLength = double.Parse(CameraHoleLengthTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CameraRightGapTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CameraRightGap = double.Parse(CameraRightGapTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CameraTopGapTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.CameraTopGap = double.Parse(CameraTopGapTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
