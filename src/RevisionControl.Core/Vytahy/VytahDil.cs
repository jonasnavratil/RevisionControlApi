using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Abp.Domain.Entities;

namespace RevisionControl.Elevators
{
    public class VytahDil : Entity
    {
        [StringLength(SkupinaMaxLength)]
        public string Skupina { get; set; }
        [StringLength(NazevMaxLength)]
        public string Nazev { get; set; }

        public const int SkupinaMaxLength = 50;
        public const int NazevMaxLength = 100;

        public VytahDil()
        {
        }
    }
}