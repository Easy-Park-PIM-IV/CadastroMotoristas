using cadastroUser_v2.DAO;
using cadastroUser_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2.Controllers
{
    public class VeiculoController
    {
        public  IVeiculoDao dao;
       
        public VeiculoController(IVeiculoDao dao)
        {
            this.dao = dao;
        }

        public void addVeiculo(int id_motorista, string placa, string modelo, string cor)
        {
            var veiculo = new VeiculoEntity ()
            {
                placa = placa,
                modelo = modelo,    
                cor = cor
            };
            dao.AddVeiculo(veiculo, id_motorista);
        }
    }
}
