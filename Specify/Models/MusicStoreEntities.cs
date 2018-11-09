using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Specify.Models
{
    public class MusicStoreEntities:DbContext
    {
        public MusicStoreEntities():base("name=MusicStoreEntities")//Dbname or connectionString name
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}