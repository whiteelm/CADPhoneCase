using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CADPhoneCase;

namespace CADPhoneCaseUI
{
    public partial class MainForm : Form
    {
        private readonly KompasInteractor _kompas;

        public MainForm()
        {
            InitializeComponent();
            _kompas = new KompasInteractor();
        }

        private void CreateModelButton_Click(object sender, EventArgs e)
        {
            CreatePhoneCase();
        }

        /// <summary>
        /// Создание модели чехла.
        /// </summary>
        public void CreatePhoneCase()
        {
            try
            {
                var parameters = new PhoneCaseParameters(double.Parse(CaseLengthTextBox.Text),
                    double.Parse(CaseWidthTextBox.Text),
                    double.Parse(CaseHeightTextBox.Text),
                    double.Parse(CameraHoleWidthTextBox.Text),
                    double.Parse(CameraHoleLengthTextBox.Text),
                    double.Parse(CameraRightGapTextBox.Text),
                    double.Parse(CameraTopGapTextBox.Text),
                    double.Parse(ChargerHoleWidthTextBox.Text),
                    double.Parse(ChargerHoleHeightTextBox.Text),
                    double.Parse(MiniJackDiameterTextBox.Text),
                    double.Parse(MiniJackGapTextBox.Text),
                    double.Parse(SideButtonsHoleHeightTextBox.Text),
                    double.Parse(SideButtonsHoleWidthTextBox.Text),
                    double.Parse(SideButtonsGapTextBox.Text)
                );
                _kompas.OpenKompas();
                var model = new PhoneCaseModeler(_kompas.Kompas);
                model.CreateModel(parameters);
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

        /// <summary>
        /// Валидатор на ввод double.
        /// </summary>
        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b,]");
        }
    }
}
