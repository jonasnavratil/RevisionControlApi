using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace RevisionControl.Elevators
{
    [Table("Vytahy")]
    public class Vytah : FullAuditedEntity
    {
        [StringLength(ServisniFirmaMaxLength)]
        public string ServisniFirma { get; set; }
        [StringLength(VyrobceDodavatelMaxLength)]
        public string VyrobceDodavatel { get; set; }
        public int? RokVyroby { get; set; }
        [StringLength(TridaVytahuMaxLength)]
        public string TridaVytahu { get; set; }
        [StringLength(TypVytahuMaxLength)]
        public string TypVytahu { get; set; }
        public decimal? Nosnost { get; set; }
        public decimal? JmenovitaRychlost { get; set; }
        public decimal? Zdvih { get; set; }
        [StringLength(PohonMaxLength)]
        public string Pohon { get; set; }
        public int? PocetStanic { get; set; }
        public int? PocetNast { get; set; }
        [StringLength(RizeniMaxLength)]
        public string Rizeni { get; set; }
        [StringLength(NosneProstredkyMaxLength)]
        public string NosneProstredky { get; set; }
        [StringLength(VyrobniCisloMaxLength)]
        public string VyrobniCislo { get; set; }
        [StringLength(RozvadecMaxLength)]
        public string Rozvadec { get; set; }

        public const int ServisniFirmaMaxLength = 1024;
        public const int VyrobceDodavatelMaxLength = 1024;
        public const int TridaVytahuMaxLength = 100;
        public const int TypVytahuMaxLength = 100;
        public const int PohonMaxLength = 1024;
        public const int RizeniMaxLength = 1024;
        public const int NosneProstredkyMaxLength = 1024;
        public const int VyrobniCisloMaxLength = 100;
        public const int RozvadecMaxLength = 1024;

        public Vytah()
        {
        }
    }
}