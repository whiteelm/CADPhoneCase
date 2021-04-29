using System;
using System.Collections.Generic;
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
        private readonly PhoneCaseParameters _parameters;

        /// <summary>
        /// Экземпляр класса соединения с компасом.
        /// </summary>
        private readonly KompasConnector _kompas;

        /// <summary>
        /// Словарь хранящий в себе имена параметров.
        /// Ключами являются соответствующие текстбоксы.
        /// </summary>
        private Dictionary<object, ParameterName> _dictionary =
            new Dictionary<object, ParameterName>();

        /// <summary>
        /// Инициализация данных.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _dictionary.Add(CaseLengthTextBox, ParameterName.CaseLength);
            _dictionary.Add(CaseHeightTextBox, ParameterName.CaseHeight);
            _dictionary.Add(CaseWidthTextBox, ParameterName.CaseWidth);
            _dictionary.Add(CameraHoleWidthTextBox, 
                ParameterName.CameraHoleWidth);
            _dictionary.Add(CameraHoleLengthTextBox, 
                ParameterName.CameraHoleLength);
            _dictionary.Add(CameraRightGapTextBox, 
                ParameterName.CameraRightGap);
            _dictionary.Add(CameraTopGapTextBox, 
                ParameterName.CameraTopGap);
            _dictionary.Add(ChargerHoleHeightTextBox, 
                ParameterName.ChargerHoleHeight);
            _dictionary.Add(ChargerHoleWidthTextBox, 
                ParameterName.ChargerHoleWidth);
            _dictionary.Add(MiniJackDiameterTextBox, 
                ParameterName.MiniJackDiameter);
            _dictionary.Add(MiniJackGapTextBox, ParameterName.MiniJackGap);
            _dictionary.Add(SideButtonsGapTextBox, 
                ParameterName.SideButtonsGap);
            _dictionary.Add(SideButtonsHoleHeightTextBox, 
                ParameterName.SideButtonsHoleHeight);
            _dictionary.Add(SideButtonsHoleWidthTextBox, 
                ParameterName.SideButtonsHoleWidth);
            _kompas = new KompasConnector();
            _parameters = new PhoneCaseParameters();
        }

        /// <summary>
        /// Создание модели чехла.
        /// </summary>
        private void CreatePhoneCase()
        {
            try
            {
                _parameters[ParameterName.CaseLength] =
                    double.Parse(CaseLengthTextBox.Text);
                _parameters[ParameterName.CaseWidth] =
                    double.Parse(CaseWidthTextBox.Text);
                _parameters[ParameterName.CaseHeight] =
                    double.Parse(CaseHeightTextBox.Text);
                _parameters[ParameterName.CameraHoleWidth] =
                    double.Parse(CameraHoleWidthTextBox.Text);
                _parameters[ParameterName.CameraHoleLength] =
                    double.Parse(CameraHoleLengthTextBox.Text);
                _parameters[ParameterName.CameraRightGap] =
                    double.Parse(CameraRightGapTextBox.Text);
                _parameters[ParameterName.CameraTopGap] =
                    double.Parse(CameraTopGapTextBox.Text);
                _parameters[ParameterName.ChargerHoleWidth] =
                    double.Parse(ChargerHoleWidthTextBox.Text);
                _parameters[ParameterName.ChargerHoleHeight] =
                    double.Parse(ChargerHoleHeightTextBox.Text);
                _parameters[ParameterName.MiniJackDiameter] =
                    double.Parse(MiniJackDiameterTextBox.Text);
                _parameters[ParameterName.MiniJackGap] =
                    double.Parse(MiniJackGapTextBox.Text);
                _parameters[ParameterName.SideButtonsHoleHeight] =
                    double.Parse(SideButtonsHoleHeightTextBox.Text);
                _parameters[ParameterName.SideButtonsHoleWidth] =
                    double.Parse(SideButtonsHoleWidthTextBox.Text);
                _parameters[ParameterName.SideButtonsGap] =
                    double.Parse(SideButtonsGapTextBox.Text);
                _parameters.Inscription = InscriptionTextBox.Text;

                _kompas.OpenKompas();
                var model = new PhoneCaseModeler(_kompas.Kompas);
                model.CreateModel(_parameters);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые", @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Событие проверка значений текстбокса при выходе из него.
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters[_dictionary[sender]] = double.Parse(
                    ((TextBox)sender).Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Данные введены некоректно 
Возможно есть пустые поля или лишние запятые",
                    @"Предупреждение", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                ((TextBox)sender).Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Focus();
            }
        }

        /// <summary>
        /// Событие нажатия кнопки.
        /// </summary>
        private void CreateModelButton_Click(object sender, EventArgs e)
        {
            CreatePhoneCase();
        }

        /// <summary>
        /// Событие ввода с клавиатуры в текстбокс.
        /// </summary>
        private void ValidateDoubleTextBoxs_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(),
                @"[\d\b,]");
        }

        /// <summary>
        /// Событие проверка при выходе из InscriptionTextBox. 
        /// </summary>
        private void InscriptionTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _parameters.Inscription = InscriptionTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, @"Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Focus();
            }
        }
    }
}
