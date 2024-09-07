using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.CSP.InternalAPI;
using Bimser.CSP.InternalAPI.DocumentManagement;
using Bimser.Microservices.SystemConfigurationEntities;
using System;
using Newtonsoft.Json;
using Bimser.Synergy.ServiceAPI.Models.Authentication;
using static SupplierIdentification.Helper.Model;
using RestSharp;
using System.Text.RegularExpressions;
using System.Linq;
using Bimser.Framework.Json;


namespace SupplierIdentification.Forms
{
    [Route("apps/SupplierIdentification/latest/api/PartnerDetailDescription/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/PartnerDetailDescription/[action]")]
    [Route("api/PartnerDetailDescription/[action]")]
    [Produces("application/json")]
    public class PartnerDetailDescriptionController : BaseFormController<PartnerDetailDescription>
    {
        public PartnerDetailDescriptionController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "PartnerDetailDescription API Controller is ok";            
        }

        // bundan sonrası referansa göre

        private LoginWithAccessTokenParameters _accessToken;
        protected LoginWithAccessTokenParameters AccessToken
        {
            get
            {
                var connection = HttpClientConfiguration.WebInterfaceUrl.Contains("preportal") ? "https://preportal-bd.synergynow.io/ac64f047-d8d2-4da0-83c8-ac611ba37f46/deployagent/apps/" : "https://portal-bd.synergynow.io/fc3399b5-1d20-46da-9c9f-3901b15e3917/deployagent/apps/";
                var accessToken = SendRequest(connection + "PartnerDetailDescription/latest/api/PartnerDefinition/GetAccessTokenByInstanceName", Method.Get, null).result;
                _accessToken ??= new LoginWithAccessTokenParameters
                {
                    DomainAddress = HttpClientConfiguration.WebInterfaceUrl.Replace("/api/web/", ""),
                    Language = "tr-TR",
                    AccessToken = accessToken.accessToken.ToString()
                };
                return _accessToken;
            }
        }
        public dynamic SendRequest(string url, Method method, SessionProperties session, string body = null)
        {

            try
            {
                Regex urlRegex = new Regex(@"(https://.*?)(\/.*)");
                var newUrl = urlRegex.Split(url).Where(x => !string.IsNullOrEmpty(x)).ToList<string>();
                var baseUrl = newUrl[0];
                var resourceUrl = newUrl[1];
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest(resourceUrl, method);
                if (session != null)
                {
                    request.AddHeader("Bimser-Language", session.Language);
                    request.AddHeader("Bimser-Encrypted-Data", session.EncryptedData);
                    request.AddHeader("Authorization", "Bearer " + session.Token);
                }
                if (!string.IsNullOrEmpty(body))
                {
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                }
                RestResponse response = client.Execute(request);
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                if (jsonResponse.success == false)
                {
                    BimserExceptionMessage bimserEx = JsonConvert.DeserializeObject<BimserExceptionMessage>(Convert.ToString(jsonResponse));
                    BimserException innerEx = null;
                    do
                    {
                        if (innerEx == null)
                        {
                            innerEx = bimserEx.exception.InnerException;
                        }
                        else
                        {
                            innerEx = innerEx.InnerException;
                        }
                    } while (innerEx.InnerException != null);
                    throw new Exception(Convert.ToString(innerEx.Message));
                }
                return jsonResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HeaderProperties GetLoginParameters()
        {
            var client = new RestClient(HttpClientConfiguration.WebInterfaceUrl);
            var request = new RestRequest("Login/GetLoginParameters", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            object requestBody = new
            {
                DomainAddress = HttpClientConfiguration.WebInterfaceUrl.Replace("/api/web/", ""),
                Source = "WebInterface"
            };

            request.AddParameter("application/json", requestBody.ToJsonString(), ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception("Connection error!, Http Status Code: " + response.StatusCode.ToString());

            HeaderProperties headerProperties = new HeaderProperties()
            {
                EncryptedData = response.Headers.FirstOrDefault(x => x.Name == "Bimser-Encrypted-Data")?.Value.ToString(),
                Language = response.Headers.FirstOrDefault(x => x.Name == "Bimser-Language")?.Value.ToString()
            };
            return headerProperties;
        }
        public SessionProperties Login()
        {
            var getLoginParameters = GetLoginParameters();

            var client = new RestClient(HttpClientConfiguration.WebInterfaceUrl);
            var request = new RestRequest("Login/LoginWithAccessToken", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Bimser-Encrypted-Data", getLoginParameters.EncryptedData);

            object requestBody = new
            {
                language = AccessToken.Language,
                accessToken = AccessToken.AccessToken
            };

            request.AddParameter("application/json", requestBody.ToJsonString(), ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception("Connection error!, Http Status Code: " + response.StatusCode.ToString());

            return new SessionProperties()
            {
                EncryptedData = response.Headers.FirstOrDefault(x => x.Name == "Bimser-Encrypted-Data")?.Value.ToString(),
                Language = response.Headers.FirstOrDefault(x => x.Name == "Bimser-Language")?.Value.ToString(),
                Token = response.Headers.FirstOrDefault(x => x.Name == "Authorization")?.Value.ToString().Replace("Bearer ", ""),
            };
        }
        #region InternalApi

        private HttpClientConfiguration _httpClientConfiguration;
        private HttpClientConfiguration HttpClientConfiguration
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
        private HeaderParameters _headerParameters;
        private HeaderParameters Headers
        {
            get
            {
                _headerParameters ??= new HeaderParameters
                {
                    EncryptedData = _EncryptedData,
                    Language = _Language,
                    FootPrint = "",
                    LogSeverity = "",
                    Token = _Token
                };
                return _headerParameters;
            }
        }
        #endregion

        public string _EncryptedData { get; set; }
        public string _Language { get; set; }
        public string _Token { get; set; }

        [HttpPost]
        [ActionName("DownloadBase64Image")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string DownloadBase64Image([FromBody] dynamic body)
        {
            var login = Login();
            _EncryptedData = login.EncryptedData;
            _Token = login.Token;
            _Language = login.Language;

            Bimser.CSP.InternalAPI.Client.Services.DocumentManagementService dmService = new Bimser.CSP.InternalAPI.Client.Services.DocumentManagementService(HttpClientConfiguration.InternalApiUrl);

            DownloadDataRequest downloadDataRequest = new DownloadDataRequest
            {
                Id = long.Parse(body.Id.ToString()),
                Parameters = Headers,
                ForDownload = true,
                Type = ObjectType.File
            };
            var downloadResponse = dmService.DownloadData(downloadDataRequest).Result.Result.Data;
            return downloadResponse.ToBase64();

        }
    }
}