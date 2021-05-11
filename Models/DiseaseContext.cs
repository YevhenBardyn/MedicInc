using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedicInc.Models
{
    public class DiseaseContext : DbContext
    {
        public DiseaseContext() : base("MainContext")
        { }
        public DbSet<Disease> Disease { get; set; }
    }
}