using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using PROJETO_Daniel.Models;

namespace PROJETO_Daniel.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    { 
    
    
    }

    public DbSet<Produto> Produtos { get; set; }



    }
