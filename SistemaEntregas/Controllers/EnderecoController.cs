using System.Collections.Generic;
using System.Linq;
using Modelos;

namespace Controllers
{
    public class EnderecoController
    { 
        static List<Endereco> ListEndereco = new List<Endereco>();
        static int ultimoID = 0;

        public void SalvarEndereco(Endereco end)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            end.EnderecoID = id;
            ListEndereco.Add(end);

        }

        public Endereco PesquisarPorId(int id)
        {
            var e = from x in ListEndereco
                    where x.EnderecoID.Equals(id)
                    select x;
            if (e != null)
            {
                return e.FirstOrDefault();
            }
            else
                return null;

        }

        public List<Endereco> listarEnderecos()
        {
            return ListEndereco;
        }
    }
}
