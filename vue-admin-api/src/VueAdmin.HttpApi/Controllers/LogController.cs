﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using VueAdmin.Application.Contracts.System.Logging;
using VueAdmin.Application.System.Logging;
using VueAdmin.Common.Base;
using VueAdmin.Domain.Shared;

namespace VueAdmin.HttpApi.Controllers
{
    /// <summary>
    /// Log接口
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = VueAdminConsts.Grouping.GroupName_v1)]
    public class LogController : AbpController
    {
        private readonly ILogService _logService;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="pageIndex">分页下标</param>
        /// <param name="pageSize">分页大小</param>
        /// <returns></returns>
        [HttpGet]
        [Route("query")]
        public async Task<ServiceResult> QueryListAsync(int pageIndex, int pageSize)
        {
            var result = await _logService.QueryList(pageIndex, pageSize);
            return result;
        }

        /// <summary>
        /// 获取Log
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("getLog")]
        public async Task<ServiceResult> GetLogAsync(string id)
        {
            var result = await _logService.GetLog(id);
            return result;
        }
    }
}