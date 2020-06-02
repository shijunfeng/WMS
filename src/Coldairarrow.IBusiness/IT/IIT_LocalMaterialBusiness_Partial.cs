﻿using Coldairarrow.Entity.IT;
using Coldairarrow.Entity.PB;
using Coldairarrow.Entity.TD;
using Coldairarrow.IBusiness.DTO;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coldairarrow.Business.IT
{
    public partial interface IIT_LocalMaterialBusiness
    {
        Task<List<IT_LocalMaterial>> LoadCheckDataByAreaIdAsync(string id);

        Task<List<IT_LocalMaterial>> LoadCheckDataByMaterialAsync(string storId, List<string> ids);

        Task<List<PB_Material>> LoadMaterialByRandomAsync(string storId, int per);

        Task AddDataAsync(List<IT_LocalMaterial> list);
        Task UpdateDataAsync(List<IT_LocalMaterial> list);

        Task<PageResult<IT_LocalMaterial>> GetDataListAsync(IT_LocalMaterialPageInput input);

        Task<List<IT_LocalMaterial>> GetQueryData(SelectQueryDTO search, string storId);
    }
    public class IT_LocalMaterialQM
    {
        public string LocalName { get; set; }
        public string TrayName { get; set; }
        public string MaterialName { get; set; }
        public string Code { get; set; }
    }
    public class IT_LocalMaterialPageInput:PageInput<IT_LocalMaterialQM>
    {
        public string StorId { get; set; }
    }
}