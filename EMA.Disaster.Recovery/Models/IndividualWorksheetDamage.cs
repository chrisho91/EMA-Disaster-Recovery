
using System.ComponentModel.DataAnnotations;

namespace EMA.Disaster.Recovery.Models
{
    public class IndividualWorksheetDamage
    {
        public int ID { get; set; }
        public string PropertyType { get; set; }
        public string DamageCategory { get; set; }
        public bool Damaged { get; set; }
        public int EstReplacementCost { get; set; }
        public int EstStructuralDamage { get; set; }
        public int EstDamageToContents { get; set; }
        public int EstTotalDamage { get; set; }

        [Required]
        public virtual IndividualWorksheet IndividualWorksheet { get; set; }
    }
}