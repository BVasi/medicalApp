using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP_lab4
{
    public partial class addRadiographyForm : Form
    {
        public string CNP { get; set; }
        public string Picture { get; set; }
        public DateTime Date { get; set; }
        public string Diagnostic { get; set; }
        public string Comments { get; set; }

        public addRadiographyForm()
        {
            InitializeComponent();
        }

        private void addRadiographyForm_Load(object sender, EventArgs e)
        {
            cnpTextBox.Text = CNP;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void pictureSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "*.jpg|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureTextBox.Text = dlg.FileName;
                Picture = dlg.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Value;
            Diagnostic = diagnosticTextBox.Text;
            Comments = commentTextBox.Text;
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
