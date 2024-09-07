using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace SupplierIdentification.DataSources
{
   ///RequestEntities
  public class ConsultingDefinition_Archive_DataSourceRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String Culture { get; set; }

public System.String PARAMS { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Culture", Culture },
{ "PARAMS", PARAMS }
        };
    }
}

public class Flow1_ProcessItemsRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public List<object> Users { get; set; }

public List<object> Positions { get; set; }

public System.Int64 Skip { get; set; }

public System.Int64 Take { get; set; }

public System.String Culture { get; set; }

public System.Int64 ProcessType { get; set; }

public System.DateTime EndDate { get; set; }

public System.DateTime StartDate { get; set; }

public System.String FlowName { get; set; }

public System.String ProjectName { get; set; }

public System.Int64 RequestId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Users", Users },
{ "Positions", Positions },
{ "Skip", Skip },
{ "Take", Take },
{ "Culture", Culture },
{ "ProcessType", ProcessType },
{ "EndDate", EndDate },
{ "StartDate", StartDate },
{ "FlowName", FlowName },
{ "ProjectName", ProjectName },
{ "RequestId", RequestId }
        };
    }
}

public class Solutions_Archive_DataSourceRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String Culture { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Culture", Culture }
        };
    }
}

public class PartnerUserLast2_Archive_DataSourceRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String Culture { get; set; }

public System.String PARAMS { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Culture", Culture },
{ "PARAMS", PARAMS }
        };
    }
}

public class SupplyPageLast2_Archive_DataSourceRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String Culture { get; set; }

public System.String PARAMS { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Culture", Culture },
{ "PARAMS", PARAMS }
        };
    }
}

public class GetPartnerInformationRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String CULTURE { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "CULTURE", CULTURE }
        };
    }
}

public class DeletePartnerUserRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.Int64 UserId { get; set; }

public System.Int64 DocumentId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "UserId", UserId },
{ "DocumentId", DocumentId }
        };
    }
}

public class UpdatePartnerStatusRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String DocumentId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "DocumentId", DocumentId }
        };
    }
}

public class UpdateSupplyStatusRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String DocumentId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "DocumentId", DocumentId }
        };
    }
}

public class DeletePartnerSupplyRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.Int64 UserId { get; set; }

public System.Int64 DocumentId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "UserId", UserId },
{ "DocumentId", DocumentId }
        };
    }
}

public class ConsultingDefinition2_Archive_DataSourceRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String Culture { get; set; }

public System.String PARAMS { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "Culture", Culture },
{ "PARAMS", PARAMS }
        };
    }
}

public class DeleteConsultingDefinitionRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.Int64 UserId { get; set; }

public System.Int64 DocumentId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "UserId", UserId },
{ "DocumentId", DocumentId }
        };
    }
}

public class UpdateConsultingDefinitionRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    public System.String DocumentId { get; set; }

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            { "DocumentId", DocumentId }
        };
    }
}
}