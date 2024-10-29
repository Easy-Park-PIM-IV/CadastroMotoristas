using cadastroUser_v2.DAO;
using cadastroUser_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2.Controllers
{
    public class UsuarioController
    {
        private readonly IUsuarioDAO usuarioDAO;

        public UsuarioController()
        {
            usuarioDAO = new UsuarioDao();
        }

        public UsuarioEntity Login(string usuario, string senha)
        {
            return usuarioDAO.BuscarUsuario(usuario, senha);
        }
    }
}
