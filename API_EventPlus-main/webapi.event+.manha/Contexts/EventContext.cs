﻿using Microsoft.EntityFrameworkCore;
using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TiposEvento> TiposEvento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<ComentariosEvento> ComentariosEvento { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<PresencasEvento> PresencasEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE05-S14; Database=event+_manha; User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}