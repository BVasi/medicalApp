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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radiologie_dbDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.radiologie_dbDataSet.Radiografii);
            // TODO: This line of code loads data into the 'radiologie_dbDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.radiologie_dbDataSet.Pacienti);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void addRadiography_Click(object sender, EventArgs e)
        {
            addRadiographyForm addRadiographyForm_ = new addRadiographyForm();
            string cnp = (string)((DataRowView)pacientiBindingSource.Current)["CNP"];
            addRadiographyForm_.CNP = cnp;
            if (addRadiographyForm_.ShowDialog() == DialogResult.OK)
            {
                radiografiiTableAdapter.Insert(cnp, addRadiographyForm_.Picture, addRadiographyForm_.Date, addRadiographyForm_.Diagnostic, addRadiographyForm_.Comments);
                tableAdapterManager.UpdateAll(radiologie_dbDataSet);
                radiografiiTableAdapter.Fill(radiologie_dbDataSet.Radiografii);
            }
            showMiniPictures();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.radiologie_dbDataSet);
        }

        private void showMiniPictures()
        {
            flowLayoutPanel1.Controls.Clear();
            string primaryCnp = (string)((DataRowView)pacientiBindingSource.Current)["CNP"];
            foreach (DataRowView radiografie in radiografiiBindingSource.List)
            {
                string foreignCnp = (string)radiografie["CNP"];
                string picturePath = (string)radiografie["Imagine"];
                if (primaryCnp == foreignCnp)
                {
                    PictureBox picture = new PictureBox();
                    picture.SetBounds(0, 0, 100, 100);
                    picture.BackColor = Color.Black;
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Image = Bitmap.FromFile((string)radiografie["Imagine"]);
                    picture.Tag = picturePath;
                    flowLayoutPanel1.Controls.Add(picture);
                    picture.Click += Picture_Click;
                }
            }
        }

        private void showDetails(string pictureTag)
        {
            detailsTextBox.Text = "";
            string primaryCnp = (string)((DataRowView)pacientiBindingSource.Current)["CNP"];
            foreach (DataRowView radiografie in radiografiiBindingSource.List)
            {
                string foreignCnp = (string)radiografie["CNP"];
                string picturePath = (string)radiografie["Imagine"];
                if ((primaryCnp == foreignCnp) && (picturePath == pictureTag))
                {
                    detailsTextBox.Text += "Data: " + Convert.ToDateTime(radiografie["Data"]) + Environment.NewLine;
                    detailsTextBox.Text += "Diagnostic: " + (string)radiografie["Diagnostic"] + Environment.NewLine;
                    detailsTextBox.Text += "Comentarii: " + (string)radiografie["Comentarii"] + Environment.NewLine;
                }
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pictureBox1.Image = Bitmap.FromFile((string)picture.Tag);
            showDetails((string)picture.Tag);
        }

        private void pacientiBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (((DataRowView)(pacientiBindingSource.Current))["CNP"] == DBNull.Value)
            {
                return;
            }
            showMiniPictures();
        }
    }
}
