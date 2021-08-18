using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Abp.Domain.Entities.Auditing;
using RevisionControl.Elevators;

namespace RevisionControl.Reporty
{
    public class Report : FullAuditedEntity
    {
        public int VytahId { get; set; }
        public Vytah Vytah { get; set; }
        [StringLength(NadpisMaxLength)]
        public string Nadpis { get; set; }
        [StringLength(ObsahMaxLength)]
        public string Obsah { get; set; }
        public List<ReportVytahDil> Dily { get; set; }

        public const int NadpisMaxLength = 255;
        public const int ObsahMaxLength = Int32.MaxValue;

        public Report()
        {
            Dily = new List<ReportVytahDil>();
        }
    }
}