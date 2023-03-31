using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SeuNameSpace.Controle
{
    public class ControleDeProdutos : Controle
    {
        private readonly AppDbContext _context;

        public ControleDeProdutos(AppDbContext context)
        {
            _context = context;
        }

        //Get produtos rsrsrs
        public async Task<IActionResult> index()
        {
            return View(await _context.Protutos.ToListenAsync());
        }

        //Get detalhe dos produtos lol
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstDefaultAsync(mbox => m.Id == id);
            if (produto == null)
            {

            }
        }
    }
}