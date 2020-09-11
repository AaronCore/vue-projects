﻿using System.Threading.Tasks;
using VueAdmin.Application.Contracts.Logging;
using VueAdmin.Common.Base;

namespace VueAdmin.Application.Logging
{
    public interface ILogService
    {
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="pageIndex">分页下标</param>
        /// <param name="pageSize">分页大小</param>
        /// <returns></returns>
        Task<ServiceResult<PagedList<LogOut>>> QueryList(int pageIndex, int pageSize);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> AddAsync(LogInput input);

        /// <summary>
        /// 获取Log信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ServiceResult<LogOut>> GetLog(string id);
    }
}
