using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets.Dto
{
    /// <summary>
    /// <model cref="LeasedAsset"></model>
    /// </summary>
    public class LeasedAssetDto : Entity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Info { get; set; }
    }
}
