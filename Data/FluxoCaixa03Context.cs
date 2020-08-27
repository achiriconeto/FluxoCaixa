using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FluxoCaixa03.Models;

namespace FluxoCaixa03.Data
{
    public class FluxoCaixa03Context : DbContext
    {
        public FluxoCaixa03Context (DbContextOptions<FluxoCaixa03Context> options)
            : base(options)
        {
        }

        public DbSet<FluxoCaixa03.Models.Fcclasse> Fcclasse { get; set; }
    }
}
