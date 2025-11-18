using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; // PostgreSQL driver (installer Npgsql 5.0.18 via NuGet)

namespace VoituresCRUD
{
    public partial class Form1 : Form
    {
        // --- Connection string (edit to match your PostgreSQL setup) ---
        private readonly string chaineConnexion =
            "Host=localhost;Port=5432;Username=postgres;Password=root;Database=voiture";

        private NpgsqlConnection connexionBD;

        // main1: constructeur d'interface
        public Form1()
        {
            InitializeComponent();
        }

        // main2: comportement initial (de chargement)
        private void Form1_Load(object sender, EventArgs e)
        {
            connexionBD = new NpgsqlConnection(chaineConnexion);

            connexionBD.Open();
            // Remplir la liste deroulante
            string sql = "SELECT libelle FROM marque ORDER BY libelle";

            var cmd = new NpgsqlCommand(sql, connexionBD);
            var listDesMarques = cmd.ExecuteReader();

            // Pour chaque marque
            while (listDesMarques.Read())
            {
                // recuperer la marque
                var marque = listDesMarques.GetString(0);

                // ajouter la marque dans la liste deroulante
                vMarqueCBox.Items.Add(marque);
            }

            connexionBD.Close();

        }

        // ----------------------------------------------------------------
        // Button gestion des evenement (les clics)
        private void buttonAdd_Click(object sender, EventArgs e){
            string libelle = textBox1.Text;

            connexionBD = new NpgsqlConnection(chaineConnexion);

            connexionBD.Open();

            var cmd = new NpgsqlCommand("INSERT INTO marque(libelle) VALUES(@libelle)", connexionBD); // Liaison Objet commande avec la Base de donnees
            cmd.Parameters.AddWithValue("@libelle", libelle); // remplacer '@libelle' par la valeur saisie dans le parametre libelle

            // executer la requete de creation
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("La requete a ete executer avec succes !");
            else
                MessageBox.Show("Erreur!");

            connexionBD.Close(); // fermer la connexion

            // vider le champ de la saisie libelle/marque
            textBox1.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string libelle = textBox1.Text;

            connexionBD = new NpgsqlConnection(chaineConnexion);

            connexionBD.Open();

            var cmd = new NpgsqlCommand("DELETE FROM marque WHERE libelle=@libelle", connexionBD); // Liaison Objet commande avec la Base de donnees
            cmd.Parameters.AddWithValue("@libelle", libelle); // remplacer '@libelle' par la valeur saisie dans le parametre libelle

            // executer la requete de creation
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("La requete a ete executer avec succes !");
            else
                MessageBox.Show("Erreur!");

            textBox1.Clear();
        }

        // ----------------------------------------------------------------

        private void buttonShow_Click(object sender, EventArgs e)
        {
            // Affichage des marques sur la DataGridView

            // 1. Connexion avec la base de donnees Postgres
            connexionBD = new NpgsqlConnection(chaineConnexion);
            connexionBD.Open(); // ouverture

            // 2. Specification de la requte SQL a executer
            var cmd = new NpgsqlCommand(
                        "SELECT * FROM marque ORDER BY id_marque",
                        connexionBD);

            var resultats = cmd.ExecuteReader(); // executer la requete SQL de lecture

            // 3. Preparation des données récuperer pour l'affachage
            DataTable dt = new DataTable(); // creer une table pour l'interface
            dt.Load(resultats); // remplir la table avec les données récupérer dans resultats

            // 4. Afficher la table sur l'interface Form1
            dataGridView1.DataSource = dt;
        
        }

        //  ==========================
        //  ====================== Voitures
        //  ==========================

        private void btnAjouterVoiture_Click(object sender, EventArgs e)
        {
            string marque = vMarqueCBox.Text;
            string matricule = vMatriculeTBox.Text;
            string modele = vModeleTBox.Text;
            string prix = vPrixTBox.Text;

            connexionBD = new NpgsqlConnection(chaineConnexion);
            connexionBD.Open();

            // -----------------------------
            // 1. Récuperer id_marque depuis libelle
            // -----------------------------
            int id_marque = 1;

            var cmdId = new NpgsqlCommand("SELECT id_marque FROM marque WHERE libelle = @lib", connexionBD);
            cmdId.Parameters.AddWithValue("@lib", marque);

            var result = cmdId.ExecuteScalar();

            if (result != null)
                id_marque = Convert.ToInt32(result);
            

            // -----------------------------
            // 2. Insérer la voiture
            // -----------------------------
            var cmd = new NpgsqlCommand(
                "INSERT INTO voiture(id_marque, matricule, modele, prix) " +
                "VALUES(@marq, @mat, @mod, @prix)",
                connexionBD);


            cmd.Parameters.AddWithValue("@marq", id_marque); // remplacer '@libelle' par la valeur saisie dans le parametre libelle
            cmd.Parameters.AddWithValue("@mat", matricule);
            cmd.Parameters.AddWithValue("@mod", modele);
            cmd.Parameters.AddWithValue("@prix", Convert.ToDecimal(prix));


            // executer la requete de creation
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("La requete a ete executer avec succes !");
            else
                MessageBox.Show("Erreur!");

            connexionBD.Close(); // fermer la connexion

            // vider le champ de la saisie libelle/marque
            vPrixTBox.Clear();
            vModeleTBox.Clear();
            vMatriculeTBox.Clear();
        }

        private void btnSupprimerVoiture_Click(object sender, EventArgs e)
        {
            string matricule = vMatriculeTBox.Text;

            connexionBD = new NpgsqlConnection(chaineConnexion);
            connexionBD.Open();

            var cmd = new NpgsqlCommand("DELETE FROM voiture WHERE matricule=@mat", connexionBD);
            cmd.Parameters.AddWithValue("@mat", matricule);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("La voiture a été supprimée avec succès !");
            else
                MessageBox.Show("Aucune voiture trouvée avec ce matricule !");

            connexionBD.Close();

            vMatriculeTBox.Clear();
        }

        private void btnAfficherVoitures_Click(object sender, EventArgs e)
        {
            connexionBD = new NpgsqlConnection(chaineConnexion);
            connexionBD.Open();

            var cmd = new NpgsqlCommand("SELECT * FROM voiture ORDER BY matricule", connexionBD);
            var resultats = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(resultats);

            voitureDataGridView.DataSource = dt; // ← utilise ta DataGridView pour voitures

            connexionBD.Close();
        }

    }
}
