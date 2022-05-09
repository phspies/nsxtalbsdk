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
using System.Linq;
using System.Collections.Generic;
namespace nsxtalbsdk.Modules
{
    public class Metrics
    {
        private RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        private string defaultXAviVerion;
        private List<RestResponseCookie> sessionCookies;
        public Metrics(RestClient Client, List<RestResponseCookie> _sessionCookies, CancellationToken _cancellationToken, int _timeout, int _retry, string _defaultXAviVerion)
        {
            restClient = Client;
            cancellationToken = _cancellationToken;
            retry = _retry;
            timeout = _timeout;
            defaultXAviVerion = _defaultXAviVerion;
            sessionCookies = _sessionCookies;
        }
        public async Task<NSXTALBMetricsCollectionApiRspType> PostAnalyticsMetricsCollectionAsync(NSXTALBMetricsCollectionApiReqType Body, bool? IncludeName = null, bool? IncludeRefs = null, int? Limit = null, bool? PadMissingData = null, string? Start = null, int? Step = null, string? Stop = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            
            
            
            
            
            
            
            
            
            
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            StringBuilder PostAnalyticsMetricsCollectionServiceURL = new StringBuilder("/api/analytics/metrics/collection/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", JsonConvert.ToString(IncludeName).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(Body);
            request.Resource = PostAnalyticsMetricsCollectionServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsCollectionApiRspType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsCollectionApiRspType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP POST operation to " + PostAnalyticsMetricsCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseApiResponseType> GetAnalyticsMetricsControllerAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsControllerServiceURL = new StringBuilder("/api/analytics/metrics/controller/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsControllerServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsControllerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseType> GetAnalyticsMetricsControllerUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsControllerUuidServiceURL = new StringBuilder("/api/analytics/metrics/controller/{uuid}");
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
            GetAnalyticsMetricsControllerUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsControllerUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsControllerUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseApiResponseType> GetAnalyticsMetricsPoolAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsPoolServiceURL = new StringBuilder("/api/analytics/metrics/pool/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsPoolServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseType> GetAnalyticsMetricsPoolUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsPoolUuidServiceURL = new StringBuilder("/api/analytics/metrics/pool/{uuid}");
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
            GetAnalyticsMetricsPoolUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsPoolUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsPoolUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseApiResponseType> GetAnalyticsMetricsServiceengineAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsServiceengineServiceURL = new StringBuilder("/api/analytics/metrics/serviceengine/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsServiceengineServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsServiceengineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseType> GetAnalyticsMetricsServiceengineUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsServiceengineUuidServiceURL = new StringBuilder("/api/analytics/metrics/serviceengine/{uuid}");
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
            GetAnalyticsMetricsServiceengineUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsServiceengineUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsServiceengineUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseApiResponseType> GetAnalyticsMetricsVirtualserviceAsync(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsVirtualserviceServiceURL = new StringBuilder("/api/analytics/metrics/virtualservice/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsVirtualserviceServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseApiResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<NSXTALBMetricsQueryResponseType> GetAnalyticsMetricsVirtualserviceUuidAsync(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            
            
            
            
            
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            StringBuilder GetAnalyticsMetricsVirtualserviceUuidServiceURL = new StringBuilder("/api/analytics/metrics/virtualservice/{uuid}");
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
            GetAnalyticsMetricsVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", JsonConvert.ToString(AggregateEntity).ToLowerString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", JsonConvert.ToString(AggregateObjId).ToLowerString()); }
            if (Asn != null) { request.AddQueryParameter("asn", JsonConvert.ToString(Asn).ToLowerString()); }
            if (Attack != null) { request.AddQueryParameter("attack", JsonConvert.ToString(Attack).ToLowerString()); }
            if (Browser != null) { request.AddQueryParameter("browser", JsonConvert.ToString(Browser).ToLowerString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", JsonConvert.ToString(ClientInsights).ToLowerString()); }
            if (Country != null) { request.AddQueryParameter("country", JsonConvert.ToString(Country).ToLowerString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", JsonConvert.ToString(DetailedHeader).ToLowerString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", JsonConvert.ToString(Devtype).ToLowerString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", JsonConvert.ToString(DimensionAggregation).ToLowerString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", JsonConvert.ToString(DimensionFilterOp).ToLowerString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", JsonConvert.ToString(DimensionLimit).ToLowerString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", JsonConvert.ToString(DimensionSampling).ToLowerString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", JsonConvert.ToString(Dimensions).ToLowerString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", JsonConvert.ToString(EntityUuid).ToLowerString()); }
            if (Id != null) { request.AddQueryParameter("id", JsonConvert.ToString(Id).ToLowerString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", JsonConvert.ToString(IncludeRefs).ToLowerString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", JsonConvert.ToString(IncludeStatistics).ToLowerString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", JsonConvert.ToString(Ipgroup).ToLowerString()); }
            if (Lang != null) { request.AddQueryParameter("lang", JsonConvert.ToString(Lang).ToLowerString()); }
            if (Limit != null) { request.AddQueryParameter("limit", JsonConvert.ToString(Limit).ToLowerString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", JsonConvert.ToString(MetricEntity).ToLowerString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", JsonConvert.ToString(MetricId).ToLowerString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", JsonConvert.ToString(MicroserviceLevels).ToLowerString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", JsonConvert.ToString(ObjId).ToLowerString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", JsonConvert.ToString(OrderBy).ToLowerString()); }
            if (Os != null) { request.AddQueryParameter("os", JsonConvert.ToString(Os).ToLowerString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", JsonConvert.ToString(PadMissingData).ToLowerString()); }
            if (Page != null) { request.AddQueryParameter("page", JsonConvert.ToString(Page).ToLowerString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", JsonConvert.ToString(PageSize).ToLowerString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", JsonConvert.ToString(PoolUuid).ToLowerString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", JsonConvert.ToString(Prediction).ToLowerString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", JsonConvert.ToString(ResultFormat).ToLowerString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", JsonConvert.ToString(SamplingLevel).ToLowerString()); }
            if (Server != null) { request.AddQueryParameter("server", JsonConvert.ToString(Server).ToLowerString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", JsonConvert.ToString(ServiceengineUuid).ToLowerString()); }
            if (Start != null) { request.AddQueryParameter("start", JsonConvert.ToString(Start).ToLowerString()); }
            if (Step != null) { request.AddQueryParameter("step", JsonConvert.ToString(Step).ToLowerString()); }
            if (Stop != null) { request.AddQueryParameter("stop", JsonConvert.ToString(Stop).ToLowerString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", JsonConvert.ToString(TenantUuid).ToLowerString()); }
            if (Url != null) { request.AddQueryParameter("url", JsonConvert.ToString(Url).ToLowerString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", JsonConvert.ToString(ValidateData).ToLowerString()); }
            request.Resource = GetAnalyticsMetricsVirtualserviceUuidServiceURL.ToString();
            request.AddCookie("csrftoken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddCookie("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("X-CSRFToken", sessionCookies.Find(x => x.Name == "csrftoken").Value);
            request.AddHeader("sessionid", sessionCookies.Find(x => x.Name == "sessionid").Value);
            request.AddHeader("Referer", restClient.BaseUrl.AbsoluteUri.ToString());
            IRestResponse<NSXTALBMetricsQueryResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBMetricsQueryResponseType>(request, cancellationToken, timeout, retry);
		    if (!(200 <= (int)response.StatusCode && (int)response.StatusCode <= 300)) 
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
