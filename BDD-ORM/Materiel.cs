using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_ORM
{
    public class Materiel
    {
        public Materiel()
        {
            Interventions = new List<Intervention>();
        }

         [Key]
        public int NumeroDeSerie { get; set; }

        public string Designation { get; set; }

        public string Description { get; set; }

        public DateTime Achat { get; set; }

        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
