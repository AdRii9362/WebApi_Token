using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIToken.BLL.Interfaces;
using WebAPIToken.BLL.Mappers;
using WebAPIToken.BLL.Models;
using WebAPIToken.DAL.Data;
using WebAPIToken.DAL.Interfaces;

namespace WebAPIToken.BLL.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public UtilisateurService(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        public UtilisateurModel LoginUtilisateur(string email, string password)
        {
            return _utilisateurRepository.LoginUtilisateur(email, password)?.DalToBll();
        }

        public void RegisterUtilisateur(UtilisateurModel model)
        {
            _utilisateurRepository.RegisterUtilisateur(model.BllToDal());
        }
    }
}
