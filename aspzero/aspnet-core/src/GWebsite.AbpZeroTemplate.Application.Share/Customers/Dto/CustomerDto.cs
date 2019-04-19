using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Customers.Dto
{
    /// <summary>
    /// <model cref="Customer"></model>
    /// </summary>
    public class CustomerDto : Entity<int>
    {
        public string IDNumber { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Value { get; set; }
    }
}
