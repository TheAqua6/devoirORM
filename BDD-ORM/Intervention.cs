using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_ORM
{
   public class Intervention
    {

        [Key]
        public int Id { get; set; }

        public string Mission { get; set; }

        public DateTime Ouverture { get; set; }

        public DateTime Cloture { get; set; }

        public virtual Materiel Materiels { get; set; }

        public virtual Vehicule Vehicules { get; set; }

        public virtual Intervenant Intervenants { get; set; }
    }
}
