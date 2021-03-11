using System;
using System.Windows.Forms;
using CADPhoneCase;
using Kompas6API5;
using Kompas6Constants3D;

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
            _kompas.OpenKompas();
            var _model = new PhoneCaseModeling(_kompas.Kompas);
            _model.CreateModel();
        }
    }
}
