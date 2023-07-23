﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PrincipePaz.Diesmos.Model;

namespace PrincipePaz.Diesmo.Data
{
    public class PrincipePazConcepto : DbContext
    {
        public PrincipePazConcepto(DbContextOptions<PrincipePazConcepto> options) : base(options)
        {   
        }
        public DbSet<Zona>? Zona { get; set; }
        public DbSet<Distrito>? Distrito { get; set; }
        public DbSet<RegistroDiesmos>? Diesmos { get; set; }
        public DbSet<Session>? Session { get; set; }
        public DbSet<Pastor>? Pastor { get; set; }
        public DbSet<Iglesia>? Iglesia { get; set; }
        public DbSet<Ingresos>? Ingresos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}