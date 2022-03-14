
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
        public Healthscore(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBHealthScoreQueryResponseApiResponseType GetAnalyticsHealthscorePool(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            NSXTALBHealthScoreQueryResponseApiResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseApiResponseType);
            StringBuilder GetAnalyticsHealthscorePoolServiceURL = new StringBuilder("/api/analytics/healthscore/pool/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", HsType.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", OrderSeriesBy.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", PatchOperStatus.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsHealthscorePoolServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscorePoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBHealthScoreQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBHealthScoreQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBHealthScoreQueryResponseType GetAnalyticsHealthscorePoolUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
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
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAnalyticsHealthscorePoolUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", HsType.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", OrderSeriesBy.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", PatchOperStatus.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsHealthscorePoolUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscorePoolUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBHealthScoreQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBHealthScoreQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBHealthScoreQueryResponseApiResponseType GetAnalyticsHealthscoreServiceengine(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            NSXTALBHealthScoreQueryResponseApiResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseApiResponseType);
            StringBuilder GetAnalyticsHealthscoreServiceengineServiceURL = new StringBuilder("/api/analytics/healthscore/serviceengine/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", HsType.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", OrderSeriesBy.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", PatchOperStatus.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsHealthscoreServiceengineServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreServiceengineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBHealthScoreQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBHealthScoreQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBHealthScoreQueryResponseType GetAnalyticsHealthscoreServiceengineUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
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
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAnalyticsHealthscoreServiceengineUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", HsType.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", OrderSeriesBy.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", PatchOperStatus.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsHealthscoreServiceengineUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreServiceengineUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBHealthScoreQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBHealthScoreQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBHealthScoreQueryResponseApiResponseType GetAnalyticsHealthscoreVirtualservice(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
        {
            NSXTALBHealthScoreQueryResponseApiResponseType? returnValue = default(NSXTALBHealthScoreQueryResponseApiResponseType);
            StringBuilder GetAnalyticsHealthscoreVirtualserviceServiceURL = new StringBuilder("/api/analytics/healthscore/virtualservice/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", HsType.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", OrderSeriesBy.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", PatchOperStatus.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsHealthscoreVirtualserviceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBHealthScoreQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBHealthScoreQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBHealthScoreQueryResponseType GetAnalyticsHealthscoreVirtualserviceUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? DetailedHeader = null, string? DimensionAggregation = null, string? EntityUuid = null, string? HsType = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, int? Limit = null, string? MetricEntity = null, string? OrderSeriesBy = null, bool? PadMissingData = null, bool? PatchOperStatus = null, string? PoolUuid = null, string? ResultFormat = null, string? Server = null, string? Start = null, int? Step = null, string? Stop = null, bool? Summary = null, string? TenantUuid = null)
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
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (SkipDefault != null) { request.AddQueryParameter("skip_default", SkipDefault.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            GetAnalyticsHealthscoreVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (HsType != null) { request.AddQueryParameter("hs_type", HsType.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (OrderSeriesBy != null) { request.AddQueryParameter("order_series_by", OrderSeriesBy.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (PatchOperStatus != null) { request.AddQueryParameter("patch_oper_status", PatchOperStatus.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (Summary != null) { request.AddQueryParameter("summary", Summary.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsHealthscoreVirtualserviceUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsHealthscoreVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBHealthScoreQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBHealthScoreQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
