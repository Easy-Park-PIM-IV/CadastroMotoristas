using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2.Models
{
    public class VeiculoEntity
    {
        public int id_carro {  get; set; }
        public int id_motorista { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string cor {  get; set; }

    }
}
