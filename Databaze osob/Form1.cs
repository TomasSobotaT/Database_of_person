using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// použité free ikony - https://www.iconfinder.com/
// fotky neexistujících osob - https://thispersondoesnotexist.com/
// texty - http://www.lorem-ipsum.cz/

namespace Databaze_osob
{
    public partial class FormHlavni : Form
    {
        Databaze databaze = new Databaze();
        pridatForm pridatF;     // formuláø Pøidání Osoby
        editForm editF;         // formuláø Editace Osoby
        public FormHlavni()
        {
            InitializeComponent();
            //nastaví na zaèátku foto
            fotoPictureBox.Image = Bitmap.FromFile(@"images\person_null.png");

            //a pøipojí listbox k databazi
            osobyListBox.DataSource = databaze.Data;

            // nastaví zobrazované hodnoty na zakladní
            ResetHodnot();
        }


        //tlaèítko pøidat novou osobu
        private void pridatButton_Click(object sender, EventArgs e)
        {
            try
            {
                pridatF = new pridatForm(databaze);
                pridatF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi pøidání osoby do databáze. Chyba: {ex.Message}");
            }


            RefreshData();
        }


        //vybrání položky z listboxu a zobrazení hodnot
        private void osobyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {

                jmenoLabel.Text = ((Osoba)osobyListBox.SelectedItem).Jmeno;
                prijmeniLabel.Text = ((Osoba)osobyListBox.SelectedItem).Prijmeni;
                pohlaviLabel.Text = ((Osoba)osobyListBox.SelectedItem).Pohlavi ? "Muž" : "Žena";
                poznamkalabel.Text = ((Osoba)osobyListBox.SelectedItem).Poznamka;
                datumNarozeniLabel.Text = ((Osoba)osobyListBox.SelectedItem).DatumNarozeni.ToString("dd.MM.yyyy");

                vekLabel.Text = ((Osoba)osobyListBox.SelectedItem).Vek.ToString();

                if (((Osoba)osobyListBox.SelectedItem).Foto != null)
                    fotoPictureBox.Image = ((Osoba)osobyListBox.SelectedItem).Foto;
                else
                    fotoPictureBox.Image = Bitmap.FromFile(@"images\person_null.png");
            }
        }


        //vymaže osobu z databáze
        private void odebratButton_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.OdeberZaznam((Osoba)osobyListBox.SelectedItem);
                ResetHodnot();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi odebrání osoby z databáze. Chyba: {ex.Message}");
            }

            

        }



        //editace vybrané Osoby
        private void upravitButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (osobyListBox.SelectedItem != null)
                {
                    editF = new editForm((Osoba)osobyListBox.SelectedItem);
                    editF.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi editaci osoby v databázi. Chyba: {ex.Message}");
            }


            RefreshData();

        }

   

        //serializace a uložení databaze do xml po zavøení hlavního formuláøe
        private void FormHlavni_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                databaze.Uloz();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi ukládání dat do souboru. Chyba: {ex.Message}");
            }
        }

        //deserializace a nahrání databáze z xml po zapnutí programu
        private void FormHlavni_Load(object sender, EventArgs e)
        {

            try
            {
                databaze.Nahraj();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi nahrávání dat ze souboru. Chyba: {ex.Message}");
            }


        }

    
        // resetuje vypsané hodnoty o Osobì na "-" a na "";
        public void ResetHodnot()
        {
            jmenoLabel.Text = "-";
            prijmeniLabel.Text = "-";
            pohlaviLabel.Text = "-";
            poznamkalabel.Text = "-";
            datumNarozeniLabel.Text = "-";
            vekLabel.Text = "";
            fotoPictureBox.Image = Bitmap.FromFile(@"images\person_null.png");
        }

        //odpovjí a pøipojí data k listu aby se listbox obnovil
        public void RefreshData()
        {
            osobyListBox.DataSource = null;
            osobyListBox.DataSource = databaze.Data;
        }

        //info
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Design and code by Tomas Sobota");
        }

        //konec programu
        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //seøadí list podle toho co se klikne
        private void podleJménaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int podleCeho = 0;
            if ((sender as ToolStripMenuItem).Text == "Podle jména")
                podleCeho = 1;
            if ((sender as ToolStripMenuItem).Text == "Podle pøíjmení")
                podleCeho = 2;
            if ((sender as ToolStripMenuItem).Text == "Podle vìku")
                podleCeho = 3;


            try 
            {
            databaze.Serad(podleCeho);
            RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi øazení dat. Chyba: {ex.Message}");
            }
        }


        //  zapne/vypne nabidku filtru
        private void filterButton_Click(object sender, EventArgs e)
        {

            filterPanel.Visible = filterPanel.Visible ? false : true;
            filterComboBox.SelectedItem = filterComboBox.Items[0];
        }

        //potvrdí filtr
        private void filterOK_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
            filterButton.Visible = false;
            filterNoButton.Visible = true;

            try
            { 
            databaze.Filtruj(filterTextBox.Text.Trim(), Convert.ToInt32(filterNumericUpDown.Value), filterComboBox.Text);
            osobyListBox.DataSource = databaze.FiltrovanaData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pøi filtrování dat. Chyba: {ex.Message}");
            }
        }

        // když je zapnutý filtr tak ho zruší
        private void filterNoButton_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
            filterButton.Visible = true;
            filterNoButton.Visible = false;
            filterTextBox.Text = "";
            filterNumericUpDown.Value = 0;
            databaze.ResetFiltru();
            RefreshData();

            

        }
    }

}
