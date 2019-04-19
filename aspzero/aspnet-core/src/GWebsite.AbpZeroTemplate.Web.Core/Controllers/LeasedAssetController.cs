using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets;
using GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class LeasedAssetController : GWebsiteControllerBase
    {
        private readonly ILeasedAssetAppService leasedAssetAppService;

        public LeasedAssetController(ILeasedAssetAppService leasedAssetAppService)
        {
            this.leasedAssetAppService = leasedAssetAppService;
        }

        [HttpGet]
        public PagedResultDto<LeasedAssetDto> GetLeasedAssetsByFilter(LeasedAssetFilter leasedAssetFilter)
        {
            return leasedAssetAppService.GetLeasedAssets(leasedAssetFilter);
        }

        [HttpGet]
        public LeasedAssetInput GetLeasedAssetForEdit(int id)
        {
            return leasedAssetAppService.GetLeasedAssetForEdit(id);
        }

        [HttpPost]
        public void CreateOrEditLeasedAsset([FromBody] LeasedAssetInput input)
        {
            leasedAssetAppService.CreateOrEditLeasedAsset(input);
        }

        [HttpDelete("{id}")]
        public void DeleteLeasedAsset(int id)
        {
            leasedAssetAppService.DeleteLeasedAsset(id);
        }

        [HttpGet]
        public LeasedAssetForViewDto GetLeasedAssetForView(int id)
        {
            return leasedAssetAppService.GetLeasedAssetForView(id);
        }
    }
}
