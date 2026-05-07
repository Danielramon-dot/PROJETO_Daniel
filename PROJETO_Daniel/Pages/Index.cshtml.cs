using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROJETO_Daniel.Context;
using PROJETO_Daniel.Models;

namespace PROJETO_Daniel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Produto> Produtos { get; set; }




        public void OnGet()
        {
            Produtos = _context.Produtos.ToList();
        }
    }
}
