using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databaze_osob
{
    /// <summary>
    /// Rormulář na editaci Osoby
    /// </summary>
    public partial class editForm : Form
    {

        public Osoba osoba;
        public editForm(Osoba osoba)
        {
            InitializeComponent();

            this.osoba = osoba;

        }

        //tlačítko na uložení editované osoby
        private void ulozOsobuButton_Click(object sender, EventArgs e)
        {
            try 
            { 

            osoba.DatumNarozeni = datumTimePicker.Value;
            osoba.Jmeno = jmenoTextBox.Text;
            osoba.Prijmeni = prijmeniTextBox.Text;
            osoba.Poznamka = poznamkaTextBox.Text;
            osoba.Pohlavi = muzRadioButton.Checked;

            if (fotoPictureBox.Image != null)
            {
                using (var stream = new MemoryStream())
                {
                    fotoPictureBox.Image.Save(stream, fotoPictureBox.Image.RawFormat);
                    osoba.FotoByte = stream.ToArray();
                }
            }

            this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při uložení editované osoby. Chyba: {ex.Message}");
            }
        }

        //nahrání hodnot po loadu editForm
        private void editForm_Load(object sender, EventArgs e)
        {
            datumTimePicker.Value = osoba.DatumNarozeni;
            jmenoTextBox.Text = osoba.Jmeno;
            prijmeniTextBox.Text = osoba.Prijmeni;
            poznamkaTextBox.Text = osoba.Poznamka;
            
            if (osoba.Pohlavi) muzRadioButton.Checked = true;
            else zenaRadioButton.Checked = true;

            fotoPictureBox.Image = osoba.Foto;
        }

        //nahraje nové foto Osoby
        private void nahratFotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {

                    ofd.Filter = "obrazky |*.bmp;*.jpg;*.jpeg;*.png";


                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        var fs = ofd.OpenFile();
                        fotoPictureBox.Image = Image.FromStream(fs);


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při nahrání fotky osoby. Chyba: {ex.Message}");
            }
        }
    }
}
