
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtalbsdk;
using nsxtalbsdk.Models;

namespace nsxtalbsdk.Modules
{
    public class Healthscore
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        CancellationToken cancellationToken;
        int timeout;
        int retry;
        public Healthscore(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
        }
        public async Task<NSXTALBHealthScoreQueryResponseApiResponseType> GetAnalyticsHealthscorePool(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            NSXTALBHealthScoreQueryResponseApiResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseApiResponseType);
            StringBuilder GetAnalyticsHealthscorePoolServiceURL = new StringBuilder("/api/analytics/healthscore/pool/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", JsonConvert.ToString(HsType).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", JsonConvert.ToString(OrderSeriesBy).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", JsonConvert.ToString(PatchOperStatus).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (Summary != null) { request.AddQueryParameter("summary", JsonConvert.ToString(Summary).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsHealthscorePoolServiceURL.ToString();
            IRestResponse<NSXTALBHealthScoreQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthScoreQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscorePoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBHealthScoreQueryResponseType> GetAnalyticsHealthscorePoolUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBHealthScoreQueryResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseType);
            StringBuilder GetAnalyticsHealthscorePoolUuidServiceURL = new StringBuilder("/api/analytics/healthscore/pool/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAnalyticsHealthscorePoolUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", JsonConvert.ToString(HsType).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", JsonConvert.ToString(OrderSeriesBy).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", JsonConvert.ToString(PatchOperStatus).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (Summary != null) { request.AddQueryParameter("summary", JsonConvert.ToString(Summary).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsHealthscorePoolUuidServiceURL.ToString();
            IRestResponse<NSXTALBHealthScoreQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthScoreQueryResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscorePoolUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBHealthScoreQueryResponseApiResponseType> GetAnalyticsHealthscoreServiceengine(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            NSXTALBHealthScoreQueryResponseApiResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseApiResponseType);
            StringBuilder GetAnalyticsHealthscoreServiceengineServiceURL = new StringBuilder("/api/analytics/healthscore/serviceengine/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", JsonConvert.ToString(HsType).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", JsonConvert.ToString(OrderSeriesBy).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", JsonConvert.ToString(PatchOperStatus).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (Summary != null) { request.AddQueryParameter("summary", JsonConvert.ToString(Summary).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsHealthscoreServiceengineServiceURL.ToString();
            IRestResponse<NSXTALBHealthScoreQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthScoreQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreServiceengineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBHealthScoreQueryResponseType> GetAnalyticsHealthscoreServiceengineUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBHealthScoreQueryResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseType);
            StringBuilder GetAnalyticsHealthscoreServiceengineUuidServiceURL = new StringBuilder("/api/analytics/healthscore/serviceengine/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAnalyticsHealthscoreServiceengineUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", JsonConvert.ToString(HsType).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", JsonConvert.ToString(OrderSeriesBy).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", JsonConvert.ToString(PatchOperStatus).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (Summary != null) { request.AddQueryParameter("summary", JsonConvert.ToString(Summary).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsHealthscoreServiceengineUuidServiceURL.ToString();
            IRestResponse<NSXTALBHealthScoreQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthScoreQueryResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreServiceengineUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBHealthScoreQueryResponseApiResponseType> GetAnalyticsHealthscoreVirtualservice(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            NSXTALBHealthScoreQueryResponseApiResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseApiResponseType);
            StringBuilder GetAnalyticsHealthscoreVirtualserviceServiceURL = new StringBuilder("/api/analytics/healthscore/virtualservice/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (Name != null) { request.AddQueryParameter("name", JsonConvert.ToString(Name).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", JsonConvert.ToString(HsType).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", JsonConvert.ToString(OrderSeriesBy).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", JsonConvert.ToString(PatchOperStatus).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (Summary != null) { request.AddQueryParameter("summary", JsonConvert.ToString(Summary).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsHealthscoreVirtualserviceServiceURL.ToString();
            IRestResponse<NSXTALBHealthScoreQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthScoreQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
        public async Task<NSXTALBHealthScoreQueryResponseType> GetAnalyticsHealthscoreVirtualserviceUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBHealthScoreQueryResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseType);
            StringBuilder GetAnalyticsHealthscoreVirtualserviceUuidServiceURL = new StringBuilder("/api/analytics/healthscore/virtualservice/{uuid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", JsonConvert.ToString(SkipDefault).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAnalyticsHealthscoreVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", JsonConvert.ToString(HsType).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", JsonConvert.ToString(OrderSeriesBy).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", JsonConvert.ToString(PatchOperStatus).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (Summary != null) { request.AddQueryParameter("summary", JsonConvert.ToString(Summary).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsHealthscoreVirtualserviceUuidServiceURL.ToString();
            IRestResponse<NSXTALBHealthScoreQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthScoreQueryResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers);
			}
            return response.Data;
        }
    }
}
