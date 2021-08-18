using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace RevisionControl.Reporty
{
    public class Sablona : FullAuditedEntity
    {
        [StringLength(NazevMaxLength)]
        public string Nazev { get; set; }
        [StringLength(ObsahMaxLength)]
        public string Obsah { get; set; }

        public const int NazevMaxLength = 255;
        public const int ObsahMaxLength = Int32.MaxValue;
        
        public Sablona()
        {
        }
        
        public string Build(Dictionary<string, string> parameters)
        {
            var result = new string(Obsah);
            foreach (var keyValuePair in parameters)
            {
                result = result.Replace($"{{#{keyValuePair.Key}#}}", keyValuePair.Value);
            }
            return result;
        }
    }
}