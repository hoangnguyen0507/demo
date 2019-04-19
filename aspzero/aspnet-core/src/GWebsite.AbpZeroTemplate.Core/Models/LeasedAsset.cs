using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class LeasedAsset : FullAuditModel
    {
        public string IDNumber { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Value { get; set; }
    }
}
