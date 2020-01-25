using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Savory.SentenceManage.Repository.Entity;
using Savory.SentenceManage.Repository.Request;

namespace Savory.SentenceManage.Repository
{
    public interface ISentenceRepository
    {

        /// <summary>
        /// 根据id获取单个实体
        /// </summary>
        /// <param name="id">实体编号</param>
        /// <returns>实体</returns>
        SentenceEntity GetEntityById(int id);

        /// <summary>
        /// 获取所有实体
        /// </summary>
        /// <returns>实体列表</returns>
        List<SentenceEntity> GetEntityList();

        /// <summary>
        /// 分页获取实体列表
        /// </summary>
        /// <param name="pageIndex">页码，从1开始</param>
        /// <param name="pageSize">每页个数</param>
        /// <returns>实体列表</returns>
        List<SentenceEntity> GetPagedEntityList(int pageIndex, int pageSize);

        /// <summary>
        /// 获取实体总个数
        /// </summary>
        int GetTotalCount();

        /// <summary>
        /// 新增实体
        /// </summary>
        void Create(SentenceEntity entity);

        /// <summary>
        /// 根据id更新单个实体
        /// </summary>
        void UpdateById(SentenceEntity entity);

        /// <summary>
        /// 启用实体
        /// </summary>
        void Enable(int id);

        /// <summary>
        /// 禁用实体
        /// </summary>
        void Disable(int id);
    }
}
