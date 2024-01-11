using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;
using WebAPIToken.DAL.Data;
using WebAPIToken.DAL.Interfaces;
using WebAPIToken.DAL.Mapper;

namespace WebAPIToken.DAL.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly Connection _connection;

        public UtilisateurRepository(Connection connection)
        {
            _connection = connection;
        }
        public UtilisateurData LoginUtilisateur(string email, string password)
        {
            Command command = new Command("SPUtilisateurLogin", true);

            command.AddParameter("Email", email);
            command.AddParameter("Password", password);

            return _connection.ExecuteReader(command, er => er.DbToDAL()).SingleOrDefault();
        }

        public void RegisterUtilisateur(UtilisateurData data)
        {
            Command command = new Command("SPUtilisateurRegister", true);

            command.AddParameter("Nom", data.Nom);
            command.AddParameter("Prenom", data.Prenom);
            command.AddParameter("Email", data.Email);
            command.AddParameter("DateNaissance", data.DateNaissance);
            command.AddParameter("Password", data.Password);

            _connection.ExecuteNonQuery(command);
        }
    }
}
