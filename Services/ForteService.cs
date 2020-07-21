using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ForteSdk
{
    public abstract class ForteService<TEntity> where TEntity : class, new()
    {
        protected string _strUser = "";
        protected string _strPassword = "";
        protected string _strAuthOrganizationID = "";
        protected string _serverName = "";
        protected string _url = "";
        protected string _resourceName = "";
        
        public ForteService(ForteOptions createOptions, string resource, string resourceName)
        {
            createOptions.Resource = resource;
            _serverName = GetServerDetails.Geturl(createOptions);
            _strUser = createOptions.UserId;
            _strPassword = createOptions.Password;
            _strAuthOrganizationID = createOptions.AuthOrganizationId;
            string urlparam = ParameterBuilder.ApplyAllParameters(createOptions);
            _url = _serverName + urlparam;
            _resourceName = resourceName;
        }


        public virtual IEnumerable<TEntity> List()
        {
            RequestorResponse requestorResponse = Requestor.Get(_url, _strUser, _strPassword, _strAuthOrganizationID);
            this.HandleError("List" + _resourceName, requestorResponse);
            ForteListResult<TEntity> entityResults = JsonConvert.DeserializeObject<ForteListResult<TEntity>>(requestorResponse.Content);
            return entityResults.results;
        }

        public virtual TEntity Get()
        {
            RequestorResponse requestorResponse = Requestor.Get(_url, _strUser, _strPassword, _strAuthOrganizationID);
            this.HandleError("Get" + _resourceName, requestorResponse);
            TEntity entity = Mapper<TEntity>.MapFromJson(requestorResponse.Content);
            return entity;
        }
        
        public virtual string Create(TEntity entity)
        {
            RequestorResponse requestorResponse = Requestor.PostString(_url, entity, _strUser, _strPassword, _strAuthOrganizationID);
            this.HandleError("Create" + _resourceName, requestorResponse);
            return requestorResponse.Content;
        }

        public virtual string Delete()
        {
            RequestorResponse requestorResponse = Requestor.Delete(_url, _strUser, _strPassword, _strAuthOrganizationID);
            this.HandleError("Delete" + _resourceName, requestorResponse);
            return requestorResponse.Content;
        }

        public virtual string Update(TEntity entity)
        {
            RequestorResponse requestorResponse = Requestor.PutString(_url, entity, _strUser, _strPassword, _strAuthOrganizationID);
            this.HandleError("Update" + _resourceName, requestorResponse);
            return requestorResponse.Content;
        }

        public string GetURL()
        {
            return _url;
        }


        protected void HandleError(string source, RequestorResponse requestorResponse)
        {
            if(requestorResponse.StatusCode.ToString("D").StartsWith("2"))
            {
                return;
            }

            ForteException forteException = new ForteException();
            forteException.Source = source;
            forteException.HttpStatusCode = requestorResponse.StatusCode;
            forteException.ForteError.Message = requestorResponse.Content;
            forteException.ForteError.ErrorType = requestorResponse.Message;
            throw forteException;
        }
    }
}
