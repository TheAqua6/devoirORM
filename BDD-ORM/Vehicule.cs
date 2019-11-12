using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_ORM
{
   public class Vehicule
    {
        public Vehicule()
        {
            Interventions = new List<Intervention>();
        }
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Immatriculation { get; set; }

        [StringLength(30)]
        public string Marque { get; set; }

        [StringLength(30)]
        public string Modele { get; set; }

        public float VolumeUtile { get; set; }

        public ICollection<Intervention> Interventions { get; set; }
    }
}
