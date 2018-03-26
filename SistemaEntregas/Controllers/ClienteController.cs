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
        public List<Cliente> MeusClientes { get; set; }

        public ClienteController()
        {
            MeusClientes = new List<Cliente>();
        }


        public void SalvarCliente(Cliente cliente)
        {
            MeusClientes.Add(cliente);
        }
      
    }
}
