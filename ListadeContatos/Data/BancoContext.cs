using ListadeContatos.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ListadeContatos.Data
{
    public class BancoContext : DbContext
    { 
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        { 
        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
