using Microsoft.AspNetCore.Mvc;
using ProyectoWebScrub.Models;
using ProyectoWebScrub.Data;
using Microsoft.EntityFrameworkCore;

namespace ProyectoWebScrub.Controllers
{
    public class ClienteController : Controller
    {
        private readonly TiendaContext _context;

        public ClienteController(TiendaContext context)
        {
            _context = context;
        }

        // 🔹 LISTAR
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // 🔹 CREAR (GET)
        public IActionResult Create()
        {
            return View();
        }

        // 🔹 CREAR (POST)
        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // 🔹 EDITAR (GET)
        public async Task<IActionResult> Edit(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // 🔹 EDITAR (POST)
        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // 🔹 ELIMINAR
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}