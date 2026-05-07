using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROJETO_Daniel.Context;
using PROJETO_Daniel.Models;

namespace PROJETO_Daniel.Pages
{
    public class CADASTRARModel : PageModel
    {


        private readonly AppDbContext _context;
    


        public CADASTRARModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
            public Produto Produto { get; set; }


        public void OnGet()
        {
        }

        public void OnPost()
        {

            _context.Produtos.Add(Produto);
            _context.SaveChanges();

        }

        



    }

}
