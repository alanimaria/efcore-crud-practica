using Microsoft.AspNetCore.Mvc;
using ProyectoWebScrub.Models;

namespace ProyectoWebScrub.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente
            {
                Id = 1,
                Nombre = "Juan Pérez",
                Email = "juan@email.com",
                Telefono = "8091234567",
                FechaNacimiento = new DateOnly(1995,5,10)
            }
        };

        public IActionResult Index()
        {
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1;

            clientes.Add(cliente);

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == cliente.Id);

            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Email = cliente.Email;
            clienteExistente.Telefono = cliente.Telefono;
            clienteExistente.FechaNacimiento = cliente.FechaNacimiento;

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            clientes.Remove(cliente);

            return RedirectToAction("Index");
        }
    }

}