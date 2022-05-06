using Newtonsoft.Json;
using nsxtalbsdk.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace nsxtalbsdk.Modules
{
    public class Anomaly
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public Anomaly(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBAnomalyzerQueryResponseApiResponseType> GetAnalyticsAnomalyPoolAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            StringBuilder GetAnalyticsAnomalyPoolServiceURL = new StringBuilder("/api/analytics/anomaly/pool/");
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
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", JsonConvert.ToString(Aggregation).ToLowerString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", JsonConvert.ToString(AggregationWindow).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", JsonConvert.ToString(IncludeRelated).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (Model != null) { request.AddQueryParameter("model", JsonConvert.ToString(Model).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Priority != null) { request.AddQueryParameter("priority", JsonConvert.ToString(Priority).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsAnomalyPoolServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAnomalyzerQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnomalyzerQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAnomalyzerQueryResponseType> GetAnalyticsAnomalyPoolUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetAnalyticsAnomalyPoolUuidServiceURL = new StringBuilder("/api/analytics/anomaly/pool/{uuid}");
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
            GetAnalyticsAnomalyPoolUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", JsonConvert.ToString(Aggregation).ToLowerString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", JsonConvert.ToString(AggregationWindow).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", JsonConvert.ToString(IncludeRelated).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (Model != null) { request.AddQueryParameter("model", JsonConvert.ToString(Model).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Priority != null) { request.AddQueryParameter("priority", JsonConvert.ToString(Priority).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsAnomalyPoolUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAnomalyzerQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnomalyzerQueryResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyPoolUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAnomalyzerQueryResponseApiResponseType> GetAnalyticsAnomalyServiceengineAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            StringBuilder GetAnalyticsAnomalyServiceengineServiceURL = new StringBuilder("/api/analytics/anomaly/serviceengine/");
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
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", JsonConvert.ToString(Aggregation).ToLowerString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", JsonConvert.ToString(AggregationWindow).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", JsonConvert.ToString(IncludeRelated).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (Model != null) { request.AddQueryParameter("model", JsonConvert.ToString(Model).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Priority != null) { request.AddQueryParameter("priority", JsonConvert.ToString(Priority).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsAnomalyServiceengineServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAnomalyzerQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnomalyzerQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyServiceengineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAnomalyzerQueryResponseType> GetAnalyticsAnomalyServiceengineUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetAnalyticsAnomalyServiceengineUuidServiceURL = new StringBuilder("/api/analytics/anomaly/serviceengine/{uuid}");
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
            GetAnalyticsAnomalyServiceengineUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", JsonConvert.ToString(Aggregation).ToLowerString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", JsonConvert.ToString(AggregationWindow).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", JsonConvert.ToString(IncludeRelated).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (Model != null) { request.AddQueryParameter("model", JsonConvert.ToString(Model).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Priority != null) { request.AddQueryParameter("priority", JsonConvert.ToString(Priority).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsAnomalyServiceengineUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAnomalyzerQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnomalyzerQueryResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyServiceengineUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAnomalyzerQueryResponseApiResponseType> GetAnalyticsAnomalyVirtualserviceAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            StringBuilder GetAnalyticsAnomalyVirtualserviceServiceURL = new StringBuilder("/api/analytics/anomaly/virtualservice/");
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
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", JsonConvert.ToString(Aggregation).ToLowerString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", JsonConvert.ToString(AggregationWindow).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", JsonConvert.ToString(IncludeRelated).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (Model != null) { request.AddQueryParameter("model", JsonConvert.ToString(Model).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Priority != null) { request.AddQueryParameter("priority", JsonConvert.ToString(Priority).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsAnomalyVirtualserviceServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAnomalyzerQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnomalyzerQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
        public async Task<NSXTALBAnomalyzerQueryResponseType> GetAnalyticsAnomalyVirtualserviceUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            StringBuilder GetAnalyticsAnomalyVirtualserviceUuidServiceURL = new StringBuilder("/api/analytics/anomaly/virtualservice/{uuid}");
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
            GetAnalyticsAnomalyVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", JsonConvert.ToString(Aggregation).ToLowerString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", JsonConvert.ToString(AggregationWindow).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", JsonConvert.ToString(IncludeRelated).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (Model != null) { request.AddQueryParameter("model", JsonConvert.ToString(Model).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Priority != null) { request.AddQueryParameter("priority", JsonConvert.ToString(Priority).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            request.Resource = GetAnalyticsAnomalyVirtualserviceUuidServiceURL.ToString();
            request.AddParameter("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value, ParameterType.Cookie);
            request.AddParameter("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value, ParameterType.Cookie);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBAnomalyzerQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnomalyzerQueryResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers);
            }
            return response.Data;
        }
    }
}
