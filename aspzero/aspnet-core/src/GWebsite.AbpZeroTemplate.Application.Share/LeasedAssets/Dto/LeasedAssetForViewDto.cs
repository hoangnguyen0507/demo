using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets.Dto
{
    /// <summary>
    /// <model cref="LeasedAsset"></model>
    /// </summary>
    public class LeasedAssetForViewDto
    {
        public string IDNumber { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Value { get; set; }
    }
}
