using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; // Nécessaire pour PostgreSQL

namespace GestionHotel
{
    public partial class Form1 : Form
    {
        // =========================================================
        // 1. CONFIGURATION CONNEXION
        // =========================================================
        // Assure-toi que la Database est bien 'bd_hotel' comme tu l'as dit
        string strConn = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=bd_hotel";
        NpgsqlConnection cn;

        public Form1()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(strConn);
        }

        // =========================================================
        // LOAD : Chargement initial
        // =========================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Ordre important : 
                // 1. Remplir les listes déroulantes (Etat + Categorie)
                // 2. Ensuite afficher la grille
                RemplirComboEtat();
                RemplirComboCategorie();
                ActualiserGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au démarrage : " + ex.Message);
            }
        }

        // =========================================================
        // 2. REMPLIR COMBO CATEGORIE (Table 'categories')
        // =========================================================
        public void RemplirComboCategorie()
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();

            // NOM DE TABLE : categories (Pluriel)
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM categories", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            cbCategorie.DataSource = dt;
            cbCategorie.DisplayMember = "nom";
            cbCategorie.ValueMember = "id_categorie";

            cn.Close();
        }

        // =========================================================
        // REMPLIR COMBO ETAT (Manuel)
        // =========================================================
        public void RemplirComboEtat()
        {
            cbEtat.Items.Clear();
            cbEtat.Items.Add("Disponible");
            cbEtat.Items.Add("Occupée");
            cbEtat.Items.Add("Hors service");
        }

        // =========================================================
        // 3. REMPLIR GRID (Table 'chambres')
        // =========================================================
        public void ActualiserGrid()
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();

            // NOM DE TABLE : chambres (Pluriel)
            string sql = "SELECT * FROM chambres";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvChambres.DataSource = dt;

            // Masquer l'ID catégorie si nécessaire
            if (dgvChambres.Columns.Contains("id_categorie"))
            {
                dgvChambres.Columns["id_categorie"].Visible = false;
            }

            cn.Close();

            // Mettre à jour le compteur
            AfficherNombreChambres();
        }

        // =========================================================
        // 4. BOUTON AJOUTER
        // =========================================================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();

                // Concaténation + Table 'chambres'
                // Attention au prix : Replace ',' par '.'
                string sql = "INSERT INTO chambres (numero, prix, etat, id_categorie) VALUES ('"
                                + txtNumero.Text + "', "
                                + txtPrix.Text.Replace(",", ".") + ", '"
                                + cbEtat.Text + "', "
                                + cbCategorie.SelectedValue + ")";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Chambre ajoutée avec succès !");
                ActualiserGrid();
                ViderChamps();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Erreur Ajout : " + ex.Message);
            }
        }

        // =========================================================
        // 5. BOUTON RECHERCHER
        // =========================================================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();

                string sql = "SELECT * FROM chambres WHERE numero = '" + txtNumero.Text + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtPrix.Text = dr["prix"].ToString();
                    cbEtat.Text = dr["etat"].ToString();
                    cbCategorie.SelectedValue = dr["id_categorie"];
                }
                else
                {
                    MessageBox.Show("Aucune chambre trouvée avec ce numéro.");
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================================
        // 6. BOUTON MODIFIER
        // =========================================================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();

                string sql = "UPDATE chambres SET " +
                             "prix = " + txtPrix.Text.Replace(",", ".") + ", " +
                             "etat = '" + cbEtat.Text + "', " +
                             "id_categorie = " + cbCategorie.SelectedValue + " " +
                             "WHERE numero = '" + txtNumero.Text + "'";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                int res = cmd.ExecuteNonQuery();
                cn.Close();

                if (res > 0)
                {
                    MessageBox.Show("Modification effectuée.");
                    ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Chambre introuvable (Vérifiez le numéro).");
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Erreur Modif : " + ex.Message);
            }
        }

        // =========================================================
        // 7. BOUTON SUPPRIMER
        // =========================================================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // On récupère le numéro soit de la grille, soit du textbox
                string num = txtNumero.Text;
                if (dgvChambres.CurrentRow != null && dgvChambres.CurrentRow.Selected)
                {
                    num = dgvChambres.CurrentRow.Cells["numero"].Value.ToString();
                }

                if (string.IsNullOrEmpty(num))
                {
                    MessageBox.Show("Veuillez sélectionner une chambre.");
                    return;
                }

                if (MessageBox.Show("Voulez-vous supprimer la chambre " + num + " ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                    cn.Open();

                    string sql = "DELETE FROM chambres WHERE numero = '" + num + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    ActualiserGrid();
                    ViderChamps();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Erreur Suppression : " + ex.Message);
            }
        }

        // =========================================================
        // 8. BOUTON VIDER
        // =========================================================
        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void ViderChamps()
        {
            txtNumero.Clear();
            txtPrix.Clear();
            cbEtat.SelectedIndex = -1;
            cbCategorie.SelectedIndex = -1;
            txtNumero.Focus();
        }

        // =========================================================
        // 9. COMPTEUR (Label)
        // =========================================================
        private void AfficherNombreChambres()
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM chambres", cn);
            int nombre = Convert.ToInt32(cmd.ExecuteScalar());

            lblTotal.Text = nombre.ToString();

            cn.Close();
        }

    }
}