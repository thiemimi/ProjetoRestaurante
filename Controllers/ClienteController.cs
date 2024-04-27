using Microsoft.AspNetCore.Mvc;
using rm551478.Models;

namespace rm551478.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        { 
            Endereco endereco = new (1, "Bela Vista", 160, "apto 90");
            Cliente cliente = new ("Renata", "senha123", "99848294", endereco);

            return View(cliente);
        }

        public IActionResult ListaClientes()
        {

            List<Cliente> listaCliente = new List<Cliente>();

            Endereco endereco = new(1, "Bela Vista", 160, "apto 90");
            Endereco endereco2 = new(2, "Paulista", 97, "");
            Endereco endereco3 = new(3, "Jaguare", 245, "apto 32");

            Cliente cliente = new("Renata", "Senha1234", "99342546", endereco);
            Cliente cliente2 = new("Mauricio", "senha123","990323245", endereco2);
            Cliente cliente3 = new("Ronaldo", "senha1223", "36985934", endereco3);

            listaCliente.Add(cliente);
            listaCliente.Add(cliente2);
            listaCliente.Add(cliente3);

            return View(listaCliente);
        }
    }
}
