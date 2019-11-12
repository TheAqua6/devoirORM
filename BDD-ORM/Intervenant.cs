using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_ORM
{
    /// <summary>
    /// Classe Intervenant dans la base de données
    /// </summary>
    public class Intervenant
    {
        public Intervenant()
        {
            Interventions = new List<Intervention>();
        }
        /// <summary>
        /// Le matricule est un numéro personnel et non identique entre les employées, 
        /// on peut donc l'utiliser comme clé primaire
        /// </summary>
        [Key]
        public int Matricule { get; set; }

        [StringLength(50)]
        public string? Nom { get; set; }

        [StringLength(50)]
        public string? Prenom { get; set; }

        public ICollection<Intervention> Interventions { get; set; }
    }
}
