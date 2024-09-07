using Bimser.CSP.DataSource.Api;
using Bimser.CSP.DataSource.Api.Base;
using Bimser.CSP.DataSource.Api.Models;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Bimser.Framework.Domain.Option;
using Bimser.Framework.Domain.Option.Filters;
using Bimser.Framework.Domain.Option.Pagination;
using Bimser.Framework.Domain.Option.Sorts;
using Bimser.Synergy.Entities.DataSource.Providers.Database;
using Bimser.Synergy.Entities.DataSource.Providers.Database.MSSQL;
using Bimser.Synergy.Entities.DataSource.Providers.Database.MYSQL;
using Bimser.Synergy.Entities.DataSource.Providers.Database.ODBC;
using Bimser.Synergy.Entities.DataSource.Providers.Database.Oracle;
using Bimser.Synergy.Entities.DataSource.Providers.GPT;
using Bimser.Synergy.Entities.DataSource.Providers.SAP;
using Bimser.Synergy.Entities.DataSource.Providers.WebService.Rest;
using Bimser.Synergy.Entities.DataSource.Providers.WebService.Soap.Objects;
using System.Collections.Generic;
using System.IO;

namespace SupplierIdentification.DataSources 
{
    [Route("apps/SupplierIdentification/latest/api/DataSource/[action]")]
    [Route("apps/SupplierIdentification/{v:int:min(1)}/api/DataSource/[action]")]
    [Route("api/DataSource/[action]")]
    [Produces ("application/json")]
    [Authorize(AuthenticationSchemes = "BimserBearer")]
    public class DataSourceController : BaseDataSourceController 
    {

        #region [.ctor]

        public DataSourceController (IIocManager iocManager, string authorization = "", string bimserEncryptedData = "", string bimserLanguage = "", string bimserInstance = "") : base (iocManager, authorization, bimserEncryptedData, bimserLanguage, bimserInstance) 
        {

        }

        #endregion

        ///Actions
        [HttpPost]
[AcceptVerbs("POST")]
[ActionName("ConsultingDefinition_Archive_DataSource")]
public async Task<object> ConsultingDefinition_Archive_DataSource_Action([FromBody] ConsultingDefinition_Archive_DataSourceRequest request)
{
    return await ConsultingDefinition_Archive_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("Flow1_ProcessItems")]
public async Task<object> Flow1_ProcessItems_Action([FromBody] Flow1_ProcessItemsRequest request)
{
    return await Flow1_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("Solutions_Archive_DataSource")]
public async Task<object> Solutions_Archive_DataSource_Action([FromBody] Solutions_Archive_DataSourceRequest request)
{
    return await Solutions_Archive_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("PartnerUserLast2_Archive_DataSource")]
public async Task<object> PartnerUserLast2_Archive_DataSource_Action([FromBody] PartnerUserLast2_Archive_DataSourceRequest request)
{
    return await PartnerUserLast2_Archive_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("SupplyPageLast2_Archive_DataSource")]
public async Task<object> SupplyPageLast2_Archive_DataSource_Action([FromBody] SupplyPageLast2_Archive_DataSourceRequest request)
{
    return await SupplyPageLast2_Archive_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("GetPartnerInformation")]
public async Task<object> GetPartnerInformation_Action([FromBody] GetPartnerInformationRequest request)
{
    return await GetPartnerInformation(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DeletePartnerUser")]
public async Task<object> DeletePartnerUser_Action([FromBody] DeletePartnerUserRequest request)
{
    return await DeletePartnerUser(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("UpdatePartnerStatus")]
public async Task<object> UpdatePartnerStatus_Action([FromBody] UpdatePartnerStatusRequest request)
{
    return await UpdatePartnerStatus(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("UpdateSupplyStatus")]
public async Task<object> UpdateSupplyStatus_Action([FromBody] UpdateSupplyStatusRequest request)
{
    return await UpdateSupplyStatus(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DeletePartnerSupply")]
public async Task<object> DeletePartnerSupply_Action([FromBody] DeletePartnerSupplyRequest request)
{
    return await DeletePartnerSupply(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("ConsultingDefinition2_Archive_DataSource")]
public async Task<object> ConsultingDefinition2_Archive_DataSource_Action([FromBody] ConsultingDefinition2_Archive_DataSourceRequest request)
{
    return await ConsultingDefinition2_Archive_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DeleteConsultingDefinition")]
public async Task<object> DeleteConsultingDefinition_Action([FromBody] DeleteConsultingDefinitionRequest request)
{
    return await DeleteConsultingDefinition(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("UpdateConsultingDefinition")]
public async Task<object> UpdateConsultingDefinition_Action([FromBody] UpdateConsultingDefinitionRequest request)
{
    return await UpdateConsultingDefinition(request);
}

        ///Handles
        internal async Task<DataSourceResponse<object>> ConsultingDefinition_Archive_DataSource(ConsultingDefinition_Archive_DataSourceRequest request)
{
    string queryName = "ConsultingDefinition_Archive_DataSource";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> Flow1_ProcessItems(Flow1_ProcessItemsRequest request)
{
    string queryName = "Flow1_ProcessItems";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> Solutions_Archive_DataSource(Solutions_Archive_DataSourceRequest request)
{
    string queryName = "Solutions_Archive_DataSource";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> PartnerUserLast2_Archive_DataSource(PartnerUserLast2_Archive_DataSourceRequest request)
{
    string queryName = "PartnerUserLast2_Archive_DataSource";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> SupplyPageLast2_Archive_DataSource(SupplyPageLast2_Archive_DataSourceRequest request)
{
    string queryName = "SupplyPageLast2_Archive_DataSource";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> GetPartnerInformation(GetPartnerInformationRequest request)
{
    string queryName = "GetPartnerInformation";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> DeletePartnerUser(DeletePartnerUserRequest request)
{
    string queryName = "DeletePartnerUser";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> UpdatePartnerStatus(UpdatePartnerStatusRequest request)
{
    string queryName = "UpdatePartnerStatus";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> UpdateSupplyStatus(UpdateSupplyStatusRequest request)
{
    string queryName = "UpdateSupplyStatus";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> DeletePartnerSupply(DeletePartnerSupplyRequest request)
{
    string queryName = "DeletePartnerSupply";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> ConsultingDefinition2_Archive_DataSource(ConsultingDefinition2_Archive_DataSourceRequest request)
{
    string queryName = "ConsultingDefinition2_Archive_DataSource";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> DeleteConsultingDefinition(DeleteConsultingDefinitionRequest request)
{
    string queryName = "DeleteConsultingDefinition";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> UpdateConsultingDefinition(UpdateConsultingDefinitionRequest request)
{
    string queryName = "UpdateConsultingDefinition";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

        ///Iterators
        [NonAction]
public IEnumerable<Dictionary<string, object>> ConsultingDefinition_Archive_DataSourceIterator(ConsultingDefinition_Archive_DataSourceRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = ConsultingDefinition_Archive_DataSource(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> Flow1_ProcessItemsIterator(Flow1_ProcessItemsRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = Flow1_ProcessItems(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> Solutions_Archive_DataSourceIterator(Solutions_Archive_DataSourceRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = Solutions_Archive_DataSource(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> PartnerUserLast2_Archive_DataSourceIterator(PartnerUserLast2_Archive_DataSourceRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = PartnerUserLast2_Archive_DataSource(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> SupplyPageLast2_Archive_DataSourceIterator(SupplyPageLast2_Archive_DataSourceRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = SupplyPageLast2_Archive_DataSource(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> GetPartnerInformationIterator(GetPartnerInformationRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = GetPartnerInformation(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> DeletePartnerUserIterator(DeletePartnerUserRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = DeletePartnerUser(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> UpdatePartnerStatusIterator(UpdatePartnerStatusRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = UpdatePartnerStatus(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> UpdateSupplyStatusIterator(UpdateSupplyStatusRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = UpdateSupplyStatus(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> DeletePartnerSupplyIterator(DeletePartnerSupplyRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = DeletePartnerSupply(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> ConsultingDefinition2_Archive_DataSourceIterator(ConsultingDefinition2_Archive_DataSourceRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = ConsultingDefinition2_Archive_DataSource(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> DeleteConsultingDefinitionIterator(DeleteConsultingDefinitionRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = DeleteConsultingDefinition(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> UpdateConsultingDefinitionIterator(UpdateConsultingDefinitionRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = UpdateConsultingDefinition(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

    }
}