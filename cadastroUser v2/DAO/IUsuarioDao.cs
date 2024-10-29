using cadastroUser_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2.DAO
{
    public interface IUsuarioDAO
    {
        UsuarioEntity BuscarUsuario(string usuario, string senha);
    }
}
