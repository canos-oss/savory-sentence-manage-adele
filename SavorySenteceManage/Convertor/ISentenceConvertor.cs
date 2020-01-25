using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Savory.SentenceManage.Contract.Request;
using Savory.SentenceManage.Contract.Vo;
using Savory.SentenceManage.Repository.Entity;
using Savory.SentenceManage.Repository.Request;

namespace Savory.SentenceManage.Convertor
{
    public interface ISentenceConvertor
    {

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        SentenceEntity ToEntity(SentenceCreateRequest request);

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        SentenceEntity ToEntity(SentenceUpdateRequest request, SentenceEntity oldEntity);

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        SentenceBasicVo ToBasicVo(SentenceEntity entity);

        /// <summary>
        /// entityList 转换为 voList
        /// </summary>
        List<SentenceBasicVo> ToBasicVoList(List<SentenceEntity> entityList);

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        SentenceExtendedVo ToExtendedVo(SentenceEntity entity);

        /// <summary>
        /// entityList 转换为 voList
        /// </summary>
        List<SentenceExtendedVo> ToExtendedVoList(List<SentenceEntity> entityList);

        /// <summary>
        /// 转换为数据库请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        SentenceGetEntityByPrimaryPropertyRequest ToGetEntityByPrimaryProperty(SentenceItemRequest request);

        /// <summary>
        /// 转换为数据库请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        SentenceGetEntityByPrimaryPropertyRequest ToGetEntityByPrimaryProperty(SentenceBasicRequest request);

        /// <summary>
        /// 转换为数据库请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        SentenceGetEntityByPrimaryPropertyRequest ToGetEntityByPrimaryProperty(SentenceUpdateRequest request);
    }
}
