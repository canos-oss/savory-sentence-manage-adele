using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Savory.SentenceManage.Contract.Request;
using Savory.SentenceManage.Contract.Vo;
using Savory.SentenceManage.Repository.Entity;
using Savory.SentenceManage.Repository.Request;
using Savory.SentenceManage.Utility;

namespace Savory.SentenceManage.Convertor.Implement
{
    public class SentenceConvertor : ISentenceConvertor
    {

        public SentenceEntity ToEntity(SentenceCreateRequest request)
        {
            SentenceEntity entity = new SentenceEntity();

            var item = request.Item;

            entity.Content = item.Content;
            entity.DataStatus = 1;
            entity.CreateTime = TimeConvertor.FromMilliTicks(TimeConvertor.ToMilliTicks(DateTime.Now));
            entity.LastUpdateTime = TimeConvertor.FromMilliTicks(TimeConvertor.ToMilliTicks(DateTime.Now));

            return entity;
        }

        public SentenceEntity ToEntity(SentenceUpdateRequest request, SentenceEntity oldEntity)
        {
            SentenceEntity entity = new SentenceEntity();

            var item = request.Item;

            entity.Id = request.Id;
            entity.Content = item.Content;
            entity.DataStatus = oldEntity.DataStatus;
            entity.CreateTime = oldEntity.CreateTime;
            entity.LastUpdateTime = TimeConvertor.FromMilliTicks(TimeConvertor.ToMilliTicks(DateTime.Now));

            return entity;
        }

        /// <summary>
        /// 将entity转换为vo
        /// </summary>
        public SentenceBasicVo ToBasicVo(SentenceEntity entity)
        {
            SentenceBasicVo vo = new SentenceBasicVo();

            CopyToVo(vo, entity);


            return vo;
        }

        /// <summary>
        /// 将entity转换为vo
        /// </summary>
        public SentenceExtendedVo ToExtendedVo(SentenceEntity entity)
        {
            SentenceExtendedVo vo = new SentenceExtendedVo();

            CopyToVo(vo, entity);

            return vo;
        }

        public List<SentenceBasicVo> ToBasicVoList(List<SentenceEntity> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            List<SentenceBasicVo> voList = new List<SentenceBasicVo>();
            foreach (SentenceEntity entity in entityList)
            {
                SentenceBasicVo vo = ToBasicVo(entity);
                voList.Add(vo);
            }

            return voList;
        }

        public List<SentenceExtendedVo> ToExtendedVoList(List<SentenceEntity> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            List<SentenceExtendedVo> voList = new List<SentenceExtendedVo>();
            foreach (SentenceEntity entity in entityList)
            {
                SentenceExtendedVo vo = ToExtendedVo(entity);
                voList.Add(vo);
            }

            return voList;
        }

        /// <summary>
        /// 将entity转换为vo。不包括来自元数据的属性
        /// </summary>
        private void CopyToVo(SentenceVo vo, SentenceEntity entity)
        {
            vo.Id = entity.Id;
            vo.Content = entity.Content;
            vo.DataStatus = entity.DataStatus;
            vo.CreateTime = entity.CreateTime;
            vo.LastUpdateTime = entity.LastUpdateTime;
        }


        /// <summary>
        /// 转换为数据库请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SentenceGetEntityByPrimaryPropertyRequest ToGetEntityByPrimaryProperty(SentenceItemRequest request)
        {
            SentenceGetEntityByPrimaryPropertyRequest returnValue = new SentenceGetEntityByPrimaryPropertyRequest();


            return returnValue;
        }

        /// <summary>
        /// 转换为数据库请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SentenceGetEntityByPrimaryPropertyRequest ToGetEntityByPrimaryProperty(SentenceBasicRequest request)
        {
            SentenceGetEntityByPrimaryPropertyRequest returnValue = new SentenceGetEntityByPrimaryPropertyRequest();


            return returnValue;
        }

        /// <summary>
        /// 转换为数据库请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SentenceGetEntityByPrimaryPropertyRequest ToGetEntityByPrimaryProperty(SentenceUpdateRequest request)
        {
            SentenceGetEntityByPrimaryPropertyRequest returnValue = new SentenceGetEntityByPrimaryPropertyRequest();


            return returnValue;
        }
    }
}
