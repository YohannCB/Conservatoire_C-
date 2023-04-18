using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte;
using Banque.Modele;

namespace Banque.DAL
{
    public class EmployeDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "comptes";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Mise à jour d'un employé

        public static void updateEmploye(Client e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                //Ocom = maConnexionSql.reqExec("update employe set login= '" + e.Login + "' where id = " + e.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        // Récupération de la liste des employés
        public static List<Client> getEmployes()
        {

            List<Client> lc = new List<Client>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from Employe");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Client e;




                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string login = (string)reader.GetValue(3);
                    double salaire = (double)reader.GetValue(4);

                    //Instanciation d'un Emplye
                   // e = new Compte(numero, nom, prenom, login, salaire);

                    // Ajout de cet employe à la liste 
                    //lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}

