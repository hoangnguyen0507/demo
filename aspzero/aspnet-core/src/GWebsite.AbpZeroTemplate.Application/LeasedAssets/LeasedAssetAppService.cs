using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets;
using GWebsite.AbpZeroTemplate.Application.Share.LeasedAssets.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace GWebsite.AbpZeroTemplate.Web.Core.LeasedAssets
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient)]
    public class LeasedAssetAppService : GWebsiteAppServiceBase, ILeasedAssetAppService
    {
        private readonly IRepository<LeasedAsset> leasedAssetRepository;

        public LeasedAssetAppService(IRepository<LeasedAsset> leasedAssetRepository)
        {
            this.leasedAssetRepository = leasedAssetRepository;
        }

        #region Public Method

        public void CreateOrEditLeasedAsset(LeasedAssetInput leasedAssetInput)
        {
            if (leasedAssetInput.Id == 0)
            {
                Create(leasedAssetInput);
            }
            else
            {
                Update(leasedAssetInput);
            }
        }

        public void DeleteLeasedAsset(int id)
        {
            var leasedAssetEntity = leasedAssetRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (leasedAssetEntity != null)
            {
                leasedAssetEntity.IsDelete = true;
                leasedAssetRepository.Update(leasedAssetEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public LeasedAssetInput GetLeasedAssetForEdit(int id)
        {
            var leasedAssetEntity = leasedAssetRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (leasedAssetEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<LeasedAssetInput>(leasedAssetEntity);
        }

        public LeasedAssetForViewDto GetLeasedAssetForView(int id)
        {
            var leasedAssetEntity = leasedAssetRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (leasedAssetEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<LeasedAssetForViewDto>(leasedAssetEntity);
        }

        public PagedResultDto<LeasedAssetDto> GetLeasedAssets(LeasedAssetFilter input)
        {
            var query = leasedAssetRepository.GetAll().Where(x => !x.IsDelete);

            // filter by value
            if (input.Name != null)
            {
                query = query.Where(x => x.Name.ToLower().Equals(input.Name));
            }

            if (input.IDNumber != null)
            {
                query = query.Where(x => x.IDNumber.ToLower().Equals(input.IDNumber));
            }

            var totalCount = query.Count();

            // sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }

            // paging
            var items = query.PageBy(input).ToList();

            // result
            return new PagedResultDto<LeasedAssetDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<LeasedAssetDto>(item)).ToList());
        }

        #endregion

        #region Private Method

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Create)]
        private void Create(LeasedAssetInput leasedAssetInput)
        {
            var leasedAssetEntity = ObjectMapper.Map<LeasedAsset>(leasedAssetInput);
            SetAuditInsert(leasedAssetEntity);
            leasedAssetRepository.Insert(leasedAssetEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Edit)]
        private void Update(LeasedAssetInput leasedAssetInput)
        {
            var leasedAssetEntity = leasedAssetRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == leasedAssetInput.Id);
            if (leasedAssetEntity == null)
            {
            }
            ObjectMapper.Map(leasedAssetInput, leasedAssetEntity);
            SetAuditEdit(leasedAssetEntity);
            leasedAssetRepository.Update(leasedAssetEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        #endregion
    }
}