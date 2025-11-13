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
           // rien
        }

        // ----------------------------------------------------------------
        // Affichage des marques sur la DataGridView
        private void afficherTousLesMarques()
        {

            etablirUneConnexion();

            var cmd = new NpgsqlCommand(
                        "SELECT * FROM marque ORDER BY id_marque",
                        connexionBD);

            var resultats = cmd.ExecuteReader(); // executer la requete de lecture

            DataTable dt = new DataTable(); // creer une table pour l'interface

            dt.Load(resultats); // remplir la table avec les données récupérer dans resultats

            // Afficher la table sur l'interface Form1
            dataGridView1.DataSource = dt;
        }

        private void etablirUneConnexion(){
            connexionBD = new NpgsqlConnection(chaineConnexion);
            connexionBD.Open();
        }

        private void executerRequeteSQL(string sql, string libelle)
        {
            var cmd = new NpgsqlCommand(sql, connexionBD); // Liaison Objet commande avec la Base de donnees
                
            cmd.Parameters.AddWithValue("@libelle", libelle); // remplacer '@libelle' par la valeur saisie dans le parametre libelle

            // executer la requete de creation
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("La requete a ete executer avec succes !");
            else
                MessageBox.Show("Erreur!");

            connexionBD.Close(); // fermer la connexion
        }

        private string recupererLibelle()
        {
            // Recuperer la marque saisie
            string libelle = textBox1.Text.Trim();

            // Verifier si la libelle/marque contient de text
            if (string.IsNullOrWhiteSpace(libelle))
            {
                MessageBox.Show("Veuillez entrer un nom de marque !");
                return null;
            }

            return libelle;
        }

        // ----------------------------------------------------------------
        // Button gestion des evenement (les clics)
        private void buttonAdd_Click(object sender, EventArgs e){
            string libelle = recupererLibelle();

            if (libelle == null) return;

            etablirUneConnexion();
            executerRequeteSQL("INSERT INTO marque(libelle) VALUES(@libelle)", libelle);

            // vider le champ de la saisie libelle/marque
            textBox1.Clear();

            // Mettre à jours le tableau d'affichage
            afficherTousLesMarques();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string libelle = recupererLibelle();

            if (libelle == null) return;

            etablirUneConnexion();
            executerRequeteSQL("DELETE FROM marque WHERE libelle=@libelle", libelle);

            textBox1.Clear();
            afficherTousLesMarques();
          
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            afficherTousLesMarques();
        }

    }
}
