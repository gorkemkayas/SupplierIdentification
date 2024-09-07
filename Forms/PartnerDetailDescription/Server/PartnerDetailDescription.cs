using System;
using System.Collections.Generic;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.Events;
using SupplierIdentification.Entities;
using Bimser.CSP.Runtime.Common.Extensions;
using System.Linq;
using Newtonsoft.Json;
using Bimser.Synergy.ServiceAPI.Models.Authentication;
using Bimser.Synergy.ServiceAPI;
using System.Net.Http;
using Bimser.Microservices.SystemConfigurationEntities;
using Bimser.CSP.InternalAPI;
using Bimser.CSP.InternalAPI.DocumentManagement;
using Bimser.Framework.Dependency;
using Bimser.Framework.Storage;
using System.IO;

namespace SupplierIdentification.Forms {

    public partial class PartnerDetailDescription {
        
        private string _bimserEncryptedData;
        private string _language;
        private string _bimserFootPrint;
        private string _token;
        private HeaderParameters _headerParameters;
        private HeaderParameters Headers
        {
            get
            {
                _headerParameters ??= new HeaderParameters
                {
                    EncryptedData = _bimserEncryptedData,
                    Language = _language,
                    FootPrint = _bimserFootPrint ?? "",
                    LogSeverity = "",
                    Token = _token
                };
                return _headerParameters;
            }
        }
        private LoginWithTokenAuthenticationParameters TokenCredentials
        {
            get
            {
                return new LoginWithTokenAuthenticationParameters
                {
                    EncryptedData = Session.EncryptedData,
                    Language = Session.Language,
                    Token = Session.Token
                };
            }
        }

        private HttpClientConfiguration _httpClientConfiguration;
        public HttpClientConfiguration HttpClientConfiguration
        {
            get
            {
                if (_httpClientConfiguration == null)
                {
                    var envVar = Environment.GetEnvironmentVariable("HTTP_CLIENT_OPTIONS") ?? "";
                    _httpClientConfiguration = JsonConvert.DeserializeObject<HttpClientConfiguration>(envVar);
                }
                return _httpClientConfiguration;
            }
        }

        private ServiceAPI _serviceApi;
        protected ServiceAPI ServiceApi
        {
            get
            {
                if (_serviceApi == null)
                {
                    _serviceApi = new ServiceAPI(TokenCredentials, HttpClientConfiguration.WebInterfaceUrl.Contains("preportal") ? "preportal" : "app");
                }
                return _serviceApi;
            }
        }
        
        public void Rename(List<RelatedDocumentFile> relatedList)
        {
            foreach (var related in relatedList)
            {
                related.Name = $"{related.Id}.{related.Extension}";
            }
        }

        void PartnerDetails_OnBeforeSave(object sender, BeforeSaveEventArgs e)
        {
            if (ResponseParameters.ContainsKey("Mode") && ResponseParameters["Mode"].ToString() == "Update")
            {

                Rename(imageDocuments.Files);
                Rename(imageDocuments.Files);
    
                Bimser.CSP.InternalAPI.Client.Services.DocumentManagementService documentManagementService = null;
                string tokenId = "";
                if (Session is UserSession userSession)
                {
                    documentManagementService = new Bimser.CSP.InternalAPI.Client.Services.DocumentManagementService(HttpClientConfiguration.InternalApiUrl);
                    tokenId = userSession.TokenId;
                    _token = userSession.Token;
                    _bimserEncryptedData = userSession.EncryptedData;
                    _language = userSession.Language;
                }
    
                IStorageFactory storageFactory = IocManager.Instance.Resolve<IStorageFactory>();
                storageFactory.UpdateStorageConfigurationForInstance(Session.Instance);
    
                UploadToStorage(imageDocuments.Files, storageFactory, tokenId, documentManagementService);
                UploadToStorage(imageDocuments.Files, storageFactory, tokenId, documentManagementService);
            }
        }

        public void UploadToStorage(List<RelatedDocumentFile> relatedList, IStorageFactory storageFactory, string tokenId, Bimser.CSP.InternalAPI.Client.Services.DocumentManagementService documentManagementService)
        {
            try
            {
                IStorage storage = null;
                foreach (var related in relatedList)
                {
                    storage = storageFactory.GetStorageForInstance(Session.Instance, "default");
                    string key = Path.GetFileName(related.Name);
                    GetContentsRequest getContentRequest = new GetContentsRequest
                    {
                        Parameters = Headers,
                        ParentId = Convert.ToInt64(related.Id),
                        ParentType = ObjectType.File,
                        TokenId = tokenId
                    };

                    var content = storage.Object.Get(documentManagementService.GetContents(getContentRequest).Result.Result.FirstOrDefault().Object.Id.ToString());
                    MemoryStream memoryStream = new MemoryStream();
                    ((Bimser.Framework.AspNetCore.Classes.DocumentResult)content).Source.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    string type = "";
                    switch (related.Extension)
                    {
                        case "png":
                            type = "image/png";
                            break;
                        case "jpg":
                        case "jpeg":
                            type = "image/jpeg";
                            break;
                        case "pdf":
                            type = "application/pdf";
                            break;
                        case "mp4":
                            type = "video/mp4";
                            break;
                        default:
                            break;
                    }
                    storage = storageFactory.GetStorageForInstance(Session.Instance);
                    string uploadId = storage.Object.Put(key, memoryStream, type);
                }
                if (storage != null)
                {
                    storage.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public class GetPartnerDefinitionByCompanyIdResponse
        {
            public long? DOCUMENTID { get; set; }
            public long? CompanyId { get; set; }
        }

    }
}