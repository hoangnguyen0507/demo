using GSoft.AbpZeroTemplate.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets.Dto
{
    /// <summary>
    /// <model cref="LeasedAsset"></model>
    /// </summary>
    public class LeasedAssetFilter : PagedAndSortedInputDto
    {
        public string Name { get; set; }
        public string IDNumber { get; set; }
    }
}
