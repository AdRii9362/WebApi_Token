using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIToken.BLL.Models;
using WebAPIToken.DAL.Data;
using WebAPIToken.DAL.Interfaces;

namespace WebAPIToken.BLL.Interfaces
{
    public interface IUtilisateurService
    {
        void RegisterUtilisateur(UtilisateurModel utilisateur);

        UtilisateurModel LoginUtilisateur(string email, string password);
    }
}
