using System;
using CLEAN.CQRS.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace CLEAN.CQRS.INFRASTRUCTURE.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<User> Users => Set<User>();
}
