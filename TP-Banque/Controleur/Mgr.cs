using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Banque.Modele;


namespace Banque.Controleur
{
    public class Mgr
    {

        ClientDAO empDAO = new ClientDAO();

        List<Client> maListeEmploye;

        public Mgr()
        {

            maListeEmploye = new List<Client>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Client> chargementEmpBD()
        {

            maListeEmploye = ClientDAO.getEmployes();

            return (maListeEmploye);
        }


        // Mise à jour d'un employé  dans la DAL
        /*   public void updateEmploye(Client e)
           {

               ClientDAO.updateEmploye(e);

           }


           // Suppression d'un Employe
           public void deleteEmploye(Client e)
           {

               ClientDAO.deleteEmploye(e);

           }

           public void insertEmploye(Client e)
           {

               ClientDAO.insertEmploye(e);

           }
        */
    }
}
