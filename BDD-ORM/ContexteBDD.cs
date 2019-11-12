﻿using BDD_ORM;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("rendre_projet")
        {

        }
        public virtual DbSet<Intervenant> Intervenants { get; set; }
        public virtual DbSet<Intervention> Interventions { get; set; }
        public virtual DbSet<Materiel> Materiels { get; set; }
        public virtual DbSet<Vehicule> Vehicules { get; set; }


    }
}