using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebAPIToken.DAL.Data;

namespace WebAPIToken.DAL.Mapper
{
    public static class Mapper
    {
        internal static UtilisateurData DbToDAL(this IDataRecord record)
        {
            return new UtilisateurData()
            {
                Id = (int)record["Id"],
                Nom = (string)record["Nom"],
                Prenom = (string)record["Prenom"],
                Email = (string)record["Email"],
                DateNaissance = (DateTime)record["DateNaissance"]
            };
        }
    }
}
