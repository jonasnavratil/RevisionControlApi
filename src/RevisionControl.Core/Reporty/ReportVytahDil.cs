using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using RevisionControl.Elevators;

namespace RevisionControl.Reporty
{
    public class ReportVytahDil
    {
        public int ReportId { get; set; }
        public Report Report { get; set; }
        public int? VytahDilId { get; set; }
        public VytahDil VytahDil { get; set; }
        public string VytahDilNazev { get; set; }
        public bool Zavada { get; set; }
    }
}