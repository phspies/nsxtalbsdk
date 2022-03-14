
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
    public class Anomaly
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public Anomaly(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public NSXTALBAnomalyzerQueryResponseApiResponseType GetAnalyticsAnomalyPool(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            NSXTALBAnomalyzerQueryResponseApiResponseType? returnValue = default(NSXTALBAnomalyzerQueryResponseApiResponseType);
            StringBuilder GetAnalyticsAnomalyPoolServiceURL = new StringBuilder("/api/analytics/anomaly/pool/");
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
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", Aggregation.ToString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", AggregationWindow.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", IncludeRelated.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (Model != null) { request.AddQueryParameter("model", Model.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Priority != null) { request.AddQueryParameter("priority", Priority.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsAnomalyPoolServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBAnomalyzerQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBAnomalyzerQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBAnomalyzerQueryResponseType GetAnalyticsAnomalyPoolUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBAnomalyzerQueryResponseType? returnValue = default(NSXTALBAnomalyzerQueryResponseType);
            StringBuilder GetAnalyticsAnomalyPoolUuidServiceURL = new StringBuilder("/api/analytics/anomaly/pool/{uuid}");
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
            GetAnalyticsAnomalyPoolUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", Aggregation.ToString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", AggregationWindow.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", IncludeRelated.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (Model != null) { request.AddQueryParameter("model", Model.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Priority != null) { request.AddQueryParameter("priority", Priority.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsAnomalyPoolUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyPoolUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBAnomalyzerQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBAnomalyzerQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBAnomalyzerQueryResponseApiResponseType GetAnalyticsAnomalyServiceengine(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            NSXTALBAnomalyzerQueryResponseApiResponseType? returnValue = default(NSXTALBAnomalyzerQueryResponseApiResponseType);
            StringBuilder GetAnalyticsAnomalyServiceengineServiceURL = new StringBuilder("/api/analytics/anomaly/serviceengine/");
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
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", Aggregation.ToString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", AggregationWindow.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", IncludeRelated.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (Model != null) { request.AddQueryParameter("model", Model.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Priority != null) { request.AddQueryParameter("priority", Priority.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsAnomalyServiceengineServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyServiceengineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBAnomalyzerQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBAnomalyzerQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBAnomalyzerQueryResponseType GetAnalyticsAnomalyServiceengineUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBAnomalyzerQueryResponseType? returnValue = default(NSXTALBAnomalyzerQueryResponseType);
            StringBuilder GetAnalyticsAnomalyServiceengineUuidServiceURL = new StringBuilder("/api/analytics/anomaly/serviceengine/{uuid}");
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
            GetAnalyticsAnomalyServiceengineUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", Aggregation.ToString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", AggregationWindow.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", IncludeRelated.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (Model != null) { request.AddQueryParameter("model", Model.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Priority != null) { request.AddQueryParameter("priority", Priority.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsAnomalyServiceengineUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyServiceengineUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBAnomalyzerQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBAnomalyzerQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBAnomalyzerQueryResponseApiResponseType GetAnalyticsAnomalyVirtualservice(bool? IncludeName = null, bool? SkipDefault = null, string? Name = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            NSXTALBAnomalyzerQueryResponseApiResponseType? returnValue = default(NSXTALBAnomalyzerQueryResponseApiResponseType);
            StringBuilder GetAnalyticsAnomalyVirtualserviceServiceURL = new StringBuilder("/api/analytics/anomaly/virtualservice/");
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
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", Aggregation.ToString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", AggregationWindow.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", IncludeRelated.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (Model != null) { request.AddQueryParameter("model", Model.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Priority != null) { request.AddQueryParameter("priority", Priority.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsAnomalyVirtualserviceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyVirtualserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBAnomalyzerQueryResponseApiResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBAnomalyzerQueryResponseApiResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        public NSXTALBAnomalyzerQueryResponseType GetAnalyticsAnomalyVirtualserviceUuid(string Uuid, bool? IncludeName = null, bool? SkipDefault = null, string? XAviTenant = null, string? XAviTenantUUID = null, string? XCsrftoken = null, bool? AggregateObjId = null, string? Aggregation = null, int? AggregationWindow = null, bool? DetailedHeader = null, string? DimensionFilterOp = null, string? EntityUuid = null, bool? IncludeRefs = null, bool? IncludeRelated = null, int? Limit = null, string? MetricEntity = null, string? MetricId = null, string? Model = null, string? ObjId = null, string? OrderBy = null, int? Page = null, int? PageSize = null, string? PoolUuid = null, string? Priority = null, string? ResultFormat = null, string? Server = null, string? ServiceengineUuid = null, string? Start = null, int? Step = null, string? Stop = null, string? TenantUuid = null)
        {
            if (Uuid == null) { throw new ArgumentNullException("Uuid cannot be null"); }
            NSXTALBAnomalyzerQueryResponseType? returnValue = default(NSXTALBAnomalyzerQueryResponseType);
            StringBuilder GetAnalyticsAnomalyVirtualserviceUuidServiceURL = new StringBuilder("/api/analytics/anomaly/virtualservice/{uuid}");
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
            GetAnalyticsAnomalyVirtualserviceUuidServiceURL.Replace("{uuid}", Uri.EscapeDataString(Helpers.ConvertToString(Uuid, System.Globalization.CultureInfo.InvariantCulture)));
            if (AggregateObjId != null) { request.AddQueryParameter("aggregate_obj_id", AggregateObjId.ToString()); }
            if (Aggregation != null) { request.AddQueryParameter("aggregation", Aggregation.ToString()); }
            if (AggregationWindow != null) { request.AddQueryParameter("aggregation_window", AggregationWindow.ToString()); }
            if (DetailedHeader != null) { request.AddQueryParameter("detailed_header", DetailedHeader.ToString()); }
            if (DimensionFilterOp != null) { request.AddQueryParameter("dimension_filter_op", DimensionFilterOp.ToString()); }
            if (EntityUuid != null) { request.AddQueryParameter("entity_uuid", EntityUuid.ToString()); }
            if (IncludeRefs != null) { request.AddQueryParameter("include_refs", IncludeRefs.ToString()); }
            if (IncludeRelated != null) { request.AddQueryParameter("include_related", IncludeRelated.ToString()); }
            if (Limit != null) { request.AddQueryParameter("limit", Limit.ToString()); }
            if (MetricEntity != null) { request.AddQueryParameter("metric_entity", MetricEntity.ToString()); }
            if (MetricId != null) { request.AddQueryParameter("metric_id", MetricId.ToString()); }
            if (Model != null) { request.AddQueryParameter("model", Model.ToString()); }
            if (ObjId != null) { request.AddQueryParameter("obj_id", ObjId.ToString()); }
            if (OrderBy != null) { request.AddQueryParameter("order_by", OrderBy.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PoolUuid != null) { request.AddQueryParameter("pool_uuid", PoolUuid.ToString()); }
            if (Priority != null) { request.AddQueryParameter("priority", Priority.ToString()); }
            if (ResultFormat != null) { request.AddQueryParameter("result_format", ResultFormat.ToString()); }
            if (Server != null) { request.AddQueryParameter("server", Server.ToString()); }
            if (ServiceengineUuid != null) { request.AddQueryParameter("serviceengine_uuid", ServiceengineUuid.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (Step != null) { request.AddQueryParameter("step", Step.ToString()); }
            if (Stop != null) { request.AddQueryParameter("stop", Stop.ToString()); }
            if (TenantUuid != null) { request.AddQueryParameter("tenant_uuid", TenantUuid.ToString()); }
            request.Resource = GetAnalyticsAnomalyVirtualserviceUuidServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAnalyticsAnomalyVirtualserviceUuidServiceURL.ToString() + " did not complete successfull";
                throw new NSXTALBException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTALBAnomalyzerQueryResponseType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTALBAnomalyzerQueryResponseType).FullName + ".";
					throw new NSXTALBException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
