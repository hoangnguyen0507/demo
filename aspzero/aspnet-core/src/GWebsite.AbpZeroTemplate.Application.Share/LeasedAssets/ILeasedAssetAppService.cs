using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets
{
    public interface ILeasedAssetAppService
    {
        void CreateOrEditLeasedAsset(LeasedAssetInput leasedAssetInput);

        LeasedAssetInput GetLeasedAssetForEdit(int id);

        void DeleteLeasedAsset(int id);

        PagedResultDto<LeasedAssetDto> GetLeasedAssets(LeasedAssetFilter input);

        LeasedAssetForViewDto GetLeasedAssetForView(int id);
    }
}
