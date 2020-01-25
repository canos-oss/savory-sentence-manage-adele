using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Savory.SentenceManage.Contract.Request;
using Savory.SentenceManage.Contract.Response;
using Savory.SentenceManage.Convertor;
using Savory.SentenceManage.Lookup;
using Savory.SentenceManage.Repository;
using Savory.SentenceManage.Repository.Entity;

namespace Savory.SentenceManage.Service
{
    [Route("api/sentence")]
    public class SentenceController : BaseController
    {
        /// <summary>
        /// 分页，每页个数
        /// </summary>
        private static readonly int PAGE_SIZE = 15;

        private ISentenceRepository sentenceRepository;

        private ISentenceConvertor sentenceConvertor;

        private ISentenceLookupProvider sentenceLookupProvider;

        public SentenceController(
            ISentenceRepository sentenceRepository,
            ISentenceConvertor sentenceConvertor,
            ISentenceLookupProvider sentenceLookupProvider)
        {
            this.sentenceRepository = sentenceRepository;
            this.sentenceConvertor = sentenceConvertor;
            this.sentenceLookupProvider = sentenceLookupProvider;
        }

        [HttpPost]
        [Route("items")]
        public SentenceItemsResponse Items([FromBody]SentenceItemsRequest request)
        {
            SentenceItemsResponse response = new SentenceItemsResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            int pageIndex = request.PageIndex != null && request.PageIndex >= 0 ? request.PageIndex.Value : 1;

            List<SentenceEntity> entityList = sentenceRepository.GetPagedEntityList(pageIndex, PAGE_SIZE);

            response.Items = sentenceConvertor.ToExtendedVoList(entityList);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("data")]
        public SentenceDataResponse Data([FromBody]SentenceDataRequest request)
        {
            SentenceDataResponse response = new SentenceDataResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            int pageIndex = request.PageIndex != null && request.PageIndex >= 0 ? request.PageIndex.Value : 1;

            List<SentenceEntity> entityList = sentenceRepository.GetPagedEntityList(pageIndex, PAGE_SIZE);

            response.Items = sentenceConvertor.ToExtendedVoList(entityList);
            response.Headers = sentenceLookupProvider.Headers;

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("count")]
        public SentenceCountResponse Count([FromBody]SentenceCountRequest request)
        {
            SentenceCountResponse response = new SentenceCountResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            int count = sentenceRepository.GetTotalCount();

            response.TotalCount = count;

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("item")]
        public SentenceItemResponse Item([FromBody]SentenceItemRequest request)
        {
            SentenceItemResponse response = new SentenceItemResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            SentenceEntity entity = null;
            if (request.Id > 0)
            {
                entity = sentenceRepository.GetEntityById(request.Id);
            }

            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = sentenceConvertor.ToExtendedVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("create")]
        public SentenceCreateResponse Create([FromBody]SentenceCreateRequest request)
        {
            SentenceCreateResponse response = new SentenceCreateResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            sentenceRepository.Create(sentenceConvertor.ToEntity(request));

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("empty")]
        public SentenceEmptyResponse Empty([FromBody]SentenceEmptyRequest request)
        {
            SentenceEmptyResponse response = new SentenceEmptyResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }


            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("basic")]
        public SentenceBasicResponse Basic([FromBody]SentenceBasicRequest request)
        {
            SentenceBasicResponse response = new SentenceBasicResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            SentenceEntity entity = null;
            if (request.Id > 0)
            {
                entity = sentenceRepository.GetEntityById(request.Id);
            }

            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = sentenceConvertor.ToBasicVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("update")]
        public SentenceUpdateResponse Update([FromBody]SentenceUpdateRequest request)
        {
            SentenceUpdateResponse response = new SentenceUpdateResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            if (request.Id > 0)
            {
                SentenceEntity entity = sentenceRepository.GetEntityById(request.Id);
                if(entity != null)
                {
                    sentenceRepository.UpdateById(sentenceConvertor.ToEntity(request, entity));
                    response.Status = 1;
                }
            }

            if (response.Status == 0)
            {
                response.Status = 404;
                return response;
            }

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("enable")]
        public SentenceEnableResponse Enable([FromBody]SentenceEnableRequest request)
        {
            SentenceEnableResponse response = new SentenceEnableResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            sentenceRepository.Enable(request.Id);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("disable")]
        public SentenceDisableResponse Disable([FromBody]SentenceDisableRequest request)
        {
            SentenceDisableResponse response = new SentenceDisableResponse();

            if (request == null)
            {
                response.Status = -1;
                return response;
            }

            sentenceRepository.Disable(request.Id);

            response.Status = 1;
            return response;
        }
    }
}
