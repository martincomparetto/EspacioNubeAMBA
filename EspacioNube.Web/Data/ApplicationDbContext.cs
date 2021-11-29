using EspacioNube.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioNube.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Profesional> Profesionales { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Profesional>()
            .HasMany(p => p.Pacientes)
            .WithMany(p => p.Profesionales)
            .UsingEntity(j => j.ToTable("ProfesionalesPacientes"));

            builder.Entity<ApplicationUser>(entity => entity.ToTable(name: "Users"));
            builder.Entity<IdentityRole>(entiy => entiy.ToTable(name: "Roles"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UsersRoles"));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UsersClaims"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UsersLogins"));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RolesClaims"));
            builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UsersTokens"));
        }
    }
}
