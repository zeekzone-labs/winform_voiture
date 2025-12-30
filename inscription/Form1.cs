using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Inscription
{
    public partial class Form1 : Form
    {


        private readonly NpgsqlConnection cn;
        private readonly string chaineCn = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=inscription";
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;



        public Form1()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(chaineCn);
        }

        // 1) Fonction de Connexion
        public bool Connexion()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
                return false;
            }
        }


        // 2) Procedure pour charger les equipes dans le ComboBox
        private void Charger_Equipes()
        {
            if (Connexion() == false) return;

            // On recupere l'ID (numeq) et le NOM (nomeq)
            string sql = "SELECT numeq, nomeq FROM equipe";

            cmd = new NpgsqlCommand(sql, cn);

            try
            {
                dr = cmd.ExecuteReader();

                // Remplissage via DataTable pour lier ValueMember et DisplayMember
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbEquipe.DataSource = dt;
                cmbEquipe.DisplayMember = "nomeq"; // Ce que l'utilisateur voit
                cmbEquipe.ValueMember = "numeq";   // La valeur cachee (ID)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des equipes : " + ex.Message);
            }
            finally
            {
                // Fermeture manuelle de la connexion
                if (dr != null && !dr.IsClosed) dr.Close();
                cn.Close();
            }
        }

        // 3) Procedure pour afficher les etudiants dans le DataGridView
        private void Affiche_Etudiants()
        {
            if (Connexion() == false) return;

            // Syntaxe PostgreSQL : '||' pour la concatenation et guillemets doubles "" pour les alias
            string sql = @"SELECT e.code, (e.nom || ' ' || e.prenom) as ""Nom Complet"", 
                                  e.dateNais, e.numMassar, eq.nomeq as Equipe 
                           FROM etudiant e 
                           INNER JOIN equipe eq ON e.numEq = eq.numeq";

            cmd = new NpgsqlCommand(sql, cn);

            try
            {
                dr = cmd.ExecuteReader();

                // Chargement des donnees dans une DataTable
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Liaison des donnees e la grille
                DGVListe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'affichage : " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                cn.Close();
            }
        }

        // 4) Fonction pour generer un nouveau code (Max + 1)
        private int Generer_code()
        {
            int nouveauCode = 1; // Valeur par defaut
            if (Connexion() == false) return 0;

            string sql = "SELECT MAX(code) FROM etudiant";
            cmd = new NpgsqlCommand(sql, cn);

            try
            {
                object resultat = cmd.ExecuteScalar();

                // Verifier si le resultat n'est pas NULL (cas de la table vide)
                if (resultat != DBNull.Value && resultat != null)
                {
                    nouveauCode = Convert.ToInt32(resultat) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return nouveauCode;
        }


        // evenement Clic sur le bouton "Generer"
        private void CmdGenerer_Click(object sender, EventArgs e)
        {
            int code = Generer_code();
            string code_text = code.ToString();
            txtCode.Text = code_text;

        }

        // 5) evenement Clic sur le bouton "Enregistrer"
        private void CmdEnregistrer_Click(object sender, EventArgs e)
        {
            // Validation : Verifier si une equipe est selectionnee
            if (cmbEquipe.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner une equipe valide.");
                return;
            }

            if (Connexion() == false) return;

            try
            {
                // Recuperation directe de l'ID grece au ValueMember
                int idEquipe = Convert.ToInt32(cmbEquipe.SelectedValue);

                string sql = @"INSERT INTO etudiant (code, nom, prenom, dateNais, numMassar, numEq) 
                               VALUES (@code, @nom, @prenom, @date, @massar, @teamID)";

                cmd = new NpgsqlCommand(sql, cn);

                // Ajout des parametres
                cmd.Parameters.AddWithValue("code", int.Parse(txtCode.Text));
                cmd.Parameters.AddWithValue("nom", txtNom.Text);
                cmd.Parameters.AddWithValue("prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("date", dtpDateNais.Value);
                cmd.Parameters.AddWithValue("massar", txtMassar.Text);
                cmd.Parameters.AddWithValue("teamID", idEquipe);

                int lignesAffectees = cmd.ExecuteNonQuery();

                if (lignesAffectees > 0)
                {
                    MessageBox.Show("etudiant ajoute avec succes !");

                    // Rafraechir la liste
                    Affiche_Etudiants();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        // Chargement du formulaire (Load)
        private void Form1_Load(object sender, EventArgs e)
        {

            Charger_Equipes();
            Affiche_Etudiants();
        }

    }
}
