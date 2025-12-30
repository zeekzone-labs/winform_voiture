using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationDescommandes
{
    public partial class Form1 : Form
    {

        // 1. La chaîne de connexion (À adapter selon votre PC)
        private readonly string chaineCn = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=commandes";

        // 2. L'objet de connexion Npgsql
        private readonly NpgsqlConnection cn;

        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(chaineCn);
        }

        // Chargement du formulaire (Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            Remplir_Clients(cbClient);
            ListeCmd();
        }


        // établit une connexion avec le serveur de base de données et
        // affiche un message d’erreur en cas d’échec.
        private void Connecter()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
            }
        }

        // prend en argument un contrôle ComboBox et le remplit par
        // les noms des clients de la table « Client »
        private void Remplir_Clients(ComboBox cb)
        {
            try
            {
                // 1. Connexion à la base de données
                Connecter();

                // 2. Exécution de la requête
                // 2.a. Préparation de la requête
                string requete = "SELECT num, nom FROM client ORDER BY nom";

                // 2.b. Exécution de la requête
                cmd = new NpgsqlCommand(requete, cn);
                dr = cmd.ExecuteReader();

                // 3. Remplissage du ComboBox
                // 3.a. Création d'un DataTable pour stocker les résultats
                DataTable dt = new DataTable();
                // 3.b. Chargement des données du DataReader dans le DataTable
                dt.Load(dr);
                // 3.c. Liaison du DataTable au ComboBox
                cb.DataSource = dt;

                // 3.d. Définition des propriétés DisplayMember et ValueMember
                cb.DisplayMember = "nom"; // Colonne à afficher
                cb.ValueMember = "num"; // Colonne de la valeur associée

                // 4. Fermeture
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du remplissage des clients : " + ex.Message);
            }
        }

        // affiche les articles d’une commande.La liste
        // doit être affichée dans l’objet DataGridView nommé « DGV_Liste » 
        private void Lister_ArticlesForCmd(string numCmd)
        {
            try
            {
                // 1. Connexion à la base de données
                Connecter();
                // 2. Exécution de la requête
                // 2.a. Préparation de la requête
                string requete = @"
                                    SELECT 
                                        a.code AS ""Code"", 
                                        a.libelle AS ""Libelle"", 
                                        a.prix AS ""Prix"", 
                                        lc.Qte AS ""Quantité""
                                    FROM ligneCmd lc
                                    INNER JOIN article a ON lc.code = a.code
                                    WHERE lc.numCmd = @numCmd";

                // 2.b. Exécution de la requête
                cmd = new NpgsqlCommand(requete, cn);

                // 2.c. Ajout des paramètres
                cmd.Parameters.AddWithValue("numCmd", numCmd);
                dr = cmd.ExecuteReader();

                // 3. Remplissage du DataGridView
                // 3.a. Création d'un DataTable pour stocker les résultats
                DataTable dt = new DataTable();

                // 3.b. Chargement des données du DataReader dans le DataTable
                dt.Load(dr);

                // 3.c. Liaison du DataTable au DataGridView
                DGVArticlesCmd.DataSource = dt;

                // 4. Fermeture
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la liste des articles pour la commande : " + ex.Message);
            }
        }

        // La methode list des commandes (DGVCmd)
        private void ListeCmd()
        {
            try
            {
                // Connexion 
                Connecter();

                string requete = "SELECT * FROM commande ORDER BY numcmd ASC";

                // 2.b. Exécution de la requête
                cmd = new NpgsqlCommand(requete, cn);
                dr = cmd.ExecuteReader();

                // 3. Remplissage du DataGridView
                // 3.a. Création d'un DataTable pour stocker les résultats
                DataTable dt = new DataTable();

                // 3.b. Chargement des données du DataReader dans le DataTable
                dt.Load(dr);

                // 3.c. Liaison du DataTable au DataGridView
                DGVCmd.DataSource = dt;

                // 4. Fermeture
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la liste des commandes : " + ex.Message);
            }
        }



        // prend en argument le numéro d’une commande
        // et retourne :
        //  - « true » s’il existe une ligne de commande correspondant à ce numéro;
        //  - « false » dans le cas contraire.
        private bool Existe_Commande(string numCmd)
        {
            try
            {
                // 1. Connexion à la base de données
                Connecter();
                // 2. Exécution de la requête
                // 2.a. Préparation de la requête
                string requete = "SELECT COUNT(*) FROM ligneCmd WHERE numCmd = @numCmd";
                // 2.b. Exécution de la requête
                cmd = new NpgsqlCommand(requete, cn);
                // 2.c. Ajout des paramètres
                cmd.Parameters.AddWithValue("numCmd", numCmd);
                // 2.d. Exécution de la commande et récupération du résultat
                object resultat = cmd.ExecuteScalar();
                int count = Convert.ToInt32(resultat);
                // 3. Fermeture
                cn.Close();
                // 4. Retourne true si count > 0, sinon false
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification de l'existence de la commande : " + ex.Message);
                return false;
            }
        }

        // prend en argument le numéro d’une commande et
        // qui modifie son état avec la valeur « Validée »
        // et sa date de validation avec la date système de
        // l’application.
        private void ValidateCmd(string numCmd)
        {
            // Requête SQL de mise à jour
            string requete = "UPDATE commande SET etat = 'Validée', dateValidation = @dateVal WHERE numCmd = @numCmd";

            // Connexion à la base de données
            Connecter();

            cmd = new NpgsqlCommand(requete, cn);
            // Ajout des paramètres
            cmd.Parameters.AddWithValue("dateVal", DateTime.Now);
            cmd.Parameters.AddWithValue("numCmd", numCmd);
            // Exécution de la commande
            cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            cn.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            // Récupération du numéro de commande depuis le TextBox
            string numCmd = txtNumCmd.Text.Trim();
            // Vérification de l'existence de la ligne de la commande 
            if (Existe_Commande(numCmd))
            {
                // Validation de la commande
                ValidateCmd(numCmd);
                MessageBox.Show("Commande validée avec succès.");
            }
            else
            {
                MessageBox.Show("La commande n'a pas de ligne de commande associée.");
            }
        }

        private void BtnCmd_Click(object sender, EventArgs e)
        {
            ListeCmd();
        }

        private void BtnArticlesCmd_Click(object sender, EventArgs e)
        {
            // Récupération du numéro de commande depuis le TextBox
            string numCmd = txtNumCmd.Text.Trim();
            Lister_ArticlesForCmd(numCmd);
        }
    }
}
