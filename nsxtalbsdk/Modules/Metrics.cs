
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
    public class Metrics
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public Metrics(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBMetricsCollectionApiRspType PostAnalyticsMetricsCollection(NSXTALBMetricsCollectionApiReqType Body, bool? IncludeName = null, bool? IncludeRefs = null, int? Limit = null, bool? PadMissingData = null, string? Start = null, int? Step = null, string? Stop = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null)
        {
            if (Body == null) { throw new ArgumentNullException("Body cannot be null"); }
            NSXTALBMetricsCollectionApiRspType? returnValue = default(NSXTALBMetricsCollectionApiRspType);
            StringBuilder PostAnalyticsMetricsCollectionServiceURL = new StringBuilder("/api/analytics/metrics/collection/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            if (IncludeName != null) { request.AddQueryParameter("include_name", IncludeName.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (XAviTenant != null) request.AddHeader("X-Avi-Tenant", XAviTenant);
            if (XAviTenantUUID != null) request.AddHeader("X-Avi-Tenant-UUID", XAviTenantUUID);
            if (XCsrftoken != null) request.AddHeader("X-CSRFToken", XCsrftoken);
            request.AddJsonBody(JsonConvert.SerializeObject(Body, defaultSerializationSettings));
            request.Resource = PostAnalyticsMetricsCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostAnalyticsMetricsCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsCollectionApiRspType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsCollectionApiRspType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseApiResponseType GetAnalyticsMetricsController(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            NSXTALBMetricsQueryResponseApiResponseType? returnValue = default(NSXTALBMetricsQueryResponseApiResponseType);
            StringBuilder GetAnalyticsMetricsControllerServiceURL = new StringBuilder("/api/analytics/metrics/controller/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsControllerServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsControllerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseType GetAnalyticsMetricsControllerUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBMetricsQueryResponseType? returnValue = default(NSXTALBMetricsQueryResponseType);
            StringBuilder GetAnalyticsMetricsControllerUuidServiceURL = new StringBuilder("/api/analytics/metrics/controller/{uuid}");
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
            GetAnalyticsMetricsControllerUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsControllerUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsControllerUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseApiResponseType GetAnalyticsMetricsPool(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            NSXTALBMetricsQueryResponseApiResponseType? returnValue = default(NSXTALBMetricsQueryResponseApiResponseType);
            StringBuilder GetAnalyticsMetricsPoolServiceURL = new StringBuilder("/api/analytics/metrics/pool/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsPoolServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseType GetAnalyticsMetricsPoolUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBMetricsQueryResponseType? returnValue = default(NSXTALBMetricsQueryResponseType);
            StringBuilder GetAnalyticsMetricsPoolUuidServiceURL = new StringBuilder("/api/analytics/metrics/pool/{uuid}");
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
            GetAnalyticsMetricsPoolUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsPoolUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsPoolUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseApiResponseType GetAnalyticsMetricsServiceengine(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            NSXTALBMetricsQueryResponseApiResponseType? returnValue = default(NSXTALBMetricsQueryResponseApiResponseType);
            StringBuilder GetAnalyticsMetricsServiceengineServiceURL = new StringBuilder("/api/analytics/metrics/serviceengine/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsServiceengineServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsServiceengineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseType GetAnalyticsMetricsServiceengineUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBMetricsQueryResponseType? returnValue = default(NSXTALBMetricsQueryResponseType);
            StringBuilder GetAnalyticsMetricsServiceengineUuidServiceURL = new StringBuilder("/api/analytics/metrics/serviceengine/{uuid}");
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
            GetAnalyticsMetricsServiceengineUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsServiceengineUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsServiceengineUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseApiResponseType GetAnalyticsMetricsVirtualservice(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            NSXTALBMetricsQueryResponseApiResponseType? returnValue = default(NSXTALBMetricsQueryResponseApiResponseType);
            StringBuilder GetAnalyticsMetricsVirtualserviceServiceURL = new StringBuilder("/api/analytics/metrics/virtualservice/");
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
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsVirtualserviceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBMetricsQueryResponseType GetAnalyticsMetricsVirtualserviceUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateEntity = null, bool? AggregateObjId = null, string? Asn = null, string? Attack = null, string? Browser = null, string? ClientInsights = null, string? Country = null, bool? DetailedHeader = null, string? Devtype = null, string? DimensionAggregation = null, string? DimensionFilterOp = null, int? DimensionLimit = null, int? DimensionSampling = null, string? Dimensions = null, string? EntityUuid = null, string? Id = null, bool? IncludeRefs = null, bool? IncludeStatistics = null, string? Ipgroup = null, string? Lang = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, int? MicroserviceLevels = null, string? ObjId = null, string? OrderBy = null, string? Os = null, bool? PadMissingData = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, bool? Prediction = null, string? ResultFormat = null, string? SamplingLevel = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null, string? Url = null, bool? ValidateData = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBMetricsQueryResponseType? returnValue = default(NSXTALBMetricsQueryResponseType);
            StringBuilder GetAnalyticsMetricsVirtualserviceUuidServiceURL = new StringBuilder("/api/analytics/metrics/virtualservice/{uuid}");
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
            GetAnalyticsMetricsVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateEntity != null) { request.AddQueryParameter("aggregate_entity", AggregateEntity.ToString()); }
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Asn != null) { request.AddQueryParameter("asn", Asn.ToString()); }
            if (Attack != null) { request.AddQueryParameter("attack", Attack.ToString()); }
            if (Browser != null) { request.AddQueryParameter("browser", Browser.ToString()); }
            if (ClientInsights != null) { request.AddQueryParameter("client_insights", ClientInsights.ToString()); }
            if (Country != null) { request.AddQueryParameter("country", Country.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (Devtype != null) { request.AddQueryParameter("devtype", Devtype.ToString()); }
            if (DimensionAggregation != null) { request.AddQueryParameter("dimension_aggregation", DimensionAggregation.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (DimensionLimit != null) { request.AddQueryParameter("dimension_limit", DimensionLimit.ToString()); }
            if (DimensionSampling != null) { request.AddQueryParameter("dimension_sampling", DimensionSampling.ToString()); }
            if (Dimensions != null) { request.AddQueryParameter("dimensions", Dimensions.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeStatistics != null) { request.AddQueryParameter("include_statistics", IncludeStatistics.ToString()); }
            if (Ipgroup != null) { request.AddQueryParameter("ipgroup", Ipgroup.ToString()); }
            if (Lang != null) { request.AddQueryParameter("lang", Lang.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (MicroserviceLevels != null) { request.AddQueryParameter("microservice_levels", MicroserviceLevels.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Os != null) { request.AddQueryParameter("os", Os.ToString()); }
            if (PadMissingData != null) { request.AddQueryParameter("pad_missing_data", PadMissingData.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Prediction != null) { request.AddQueryParameter("prediction", Prediction.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (SamplingLevel != null) { request.AddQueryParameter("sampling_level", SamplingLevel.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            if (Url != null) { request.AddQueryParameter("url", Url.ToString()); }
            if (ValidateData != null) { request.AddQueryParameter("validate_data", ValidateData.ToString()); }
            request.Resource = GetAnalyticsMetricsVirtualserviceUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsMetricsVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBMetricsQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBMetricsQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
