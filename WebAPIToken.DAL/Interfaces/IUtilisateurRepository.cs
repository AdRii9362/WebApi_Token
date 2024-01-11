using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIToken.DAL.Data;

namespace WebAPIToken.DAL.Interfaces
{
    public interface IUtilisateurRepository
    {
        void RegisterUtilisateur(UtilisateurData data);

        UtilisateurData LoginUtilisateur(string email, string password);
    }
}


