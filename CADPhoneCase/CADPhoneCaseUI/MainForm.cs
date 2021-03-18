using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CADPhoneCase;

namespace CADPhoneCaseUI
{
    public partial class MainForm : Form
    {
        public KompasInteractor _kompas;

        public MainForm()
        {
            InitializeComponent();
            _kompas = new KompasInteractor();
        }

        private void CreateModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                var parameters = new PhoneCaseParameters(double.Parse(ATextBox.Text),
                    double.Parse(BTextBox.Text),
                    double.Parse(HTextBox.Text),
                    double.Parse(A1TextBox.Text),
                    double.Parse(B1TextBox.Text),
                    double.Parse(S0TextBox.Text),
                    double.Parse(S1TextBox.Text),
                    double.Parse(A2TextBox.Text),
                    double.Parse(B2TextBox.Text),
                    double.Parse(DTextBox.Text),
                    double.Parse(S2TextBox.Text),
                    double.Parse(A3TextBox.Text),
                    double.Parse(B3TextBox.Text),
                    double.Parse(S3TextBox.Text)
                );
                _kompas.OpenKompas();
                var model = new PhoneCaseModeling(_kompas.Kompas);
                model.CreateModel(parameters);
            }
            catch (FormatException)
            {
                MessageBox.Show("Данные введены некоректно \nВозможно есть пустые поля или лишние запятые",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
