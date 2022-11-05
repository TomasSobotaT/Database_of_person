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
    /// formulář na přidání osoby
    /// </summary>
    public partial class pridatForm : Form
    {

        Databaze databaze;
        Osoba novaOsoba;
        public pridatForm(Databaze databaze)
        {
            InitializeComponent();
            this.databaze = databaze;
        }


        // tlačítko uložit novou osobu, obrazek převede na pole bytu
        private void ulozOsobuButton_Click(object sender, EventArgs e)
        {

            try
            {
                //vytvoří Osobu ze zadaných udajů
                Osoba novaOsoba = new Osoba(
                datumTimePicker.Value,
                jmenoTextBox.Text,
                prijmeniTextBox.Text,
                muzRadioButton.Checked,
                poznamkaTextBox.Text
             );

                //pokud je obrázek nahraný, zapíše se jako pole bytu
                if (fotoPictureBox.Image != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        fotoPictureBox.Image.Save(stream, fotoPictureBox.Image.RawFormat);
                        novaOsoba.FotoByte = stream.ToArray();
                    }
                }

                //prida Osobu do databaze
                databaze.PridejZaznam(novaOsoba);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při uložení osoby. Chyba: {ex.Message}");
            }

        }


        //nahraje foto, zatím jen do pictureboxu, Osobě se přidá až pak jako pole bytu
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
