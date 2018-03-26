using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers
{
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            MeusClientes.Add(cliente);
        }
      
    }
}
