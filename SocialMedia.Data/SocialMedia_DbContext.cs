using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class SocialMedia_DbContext : DbContext
{
    public SocialMedia_DbContext(DbContextOptions<SocialMedia_DbContext> options) : base(options)
    { }

    public DbSet<UserEntity> Users { get; set; }
}