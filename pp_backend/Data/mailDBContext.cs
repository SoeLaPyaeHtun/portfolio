using System;
using Microsoft.EntityFrameworkCore;
using pp_backend.models;

namespace pp_backend.Data;

public class mailDBContext : DbContext{

    public mailDBContext(DbContextOptions<mailDBContext> options) : base(options) { }

    public DbSet<HireMe> HireMe { get; set; }
    public DbSet<VistiMe> VisitMe { get; set; }
}