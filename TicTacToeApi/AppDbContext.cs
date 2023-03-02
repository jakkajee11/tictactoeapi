using System;
using Microsoft.EntityFrameworkCore;

namespace TicTacToeApi
{
    public class AppDbContext : DbContext
    {        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}

