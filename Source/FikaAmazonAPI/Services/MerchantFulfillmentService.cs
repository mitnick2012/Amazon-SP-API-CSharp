﻿using FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment;
using FikaAmazonAPI.Search;
using FikaAmazonAPI.Utils;
using System.Threading.Tasks;

namespace FikaAmazonAPI.Services
{
    public class MerchantFulfillmentService : RequestService
    {

        public MerchantFulfillmentService(AmazonCredential amazonCredential) : base(amazonCredential)
        {

        }


        public GetEligibleShipmentServicesResult GetEligibleShipmentServicesOld(GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest) =>
            Task.Run(() => GetEligibleShipmentServicesOldAsync(getEligibleShipmentServicesRequest)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<GetEligibleShipmentServicesResult> GetEligibleShipmentServicesOldAsync(GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest)
        {

            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetEligibleShipmentServicesOld, RestSharp.Method.Post, postJsonObj: getEligibleShipmentServicesRequest);

            var response = await ExecuteRequestAsync<GetEligibleShipmentServicesResponse>(RateLimitType.MerchantFulFillment_GetEligibleShipmentServicesOld);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetEligibleShipmentServicesResult GetEligibleShipmentServices(GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest) =>
            Task.Run(() => GetEligibleShipmentServicesAsync(getEligibleShipmentServicesRequest)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<GetEligibleShipmentServicesResult> GetEligibleShipmentServicesAsync(GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetEligibleShipmentServices, RestSharp.Method.Post, postJsonObj: getEligibleShipmentServicesRequest);

            var response = await ExecuteRequestAsync<GetEligibleShipmentServicesResponse>(RateLimitType.MerchantFulFillment_GetEligibleShipmentServices);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment GetShipment(string shipmentId, IParameterBasedPII ParameterBasedPII = null) =>
            Task.Run(() => GetShipmentAsync(shipmentId, ParameterBasedPII = null)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<Shipment> GetShipmentAsync(string shipmentId, IParameterBasedPII ParameterBasedPII = null)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetShipment(shipmentId), RestSharp.Method.Get, parameter: ParameterBasedPII);

            var response = await ExecuteRequestAsync<GetShipmentResponse>(RateLimitType.MerchantFulFillment_GetShipment);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
        public Shipment CancelShipment(string shipmentId, IParameterBasedPII parameterBasedPII = null) =>
            Task.Run(() => CancelShipmentAsync(shipmentId, parameterBasedPII)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<Shipment> CancelShipmentAsync(string shipmentId, IParameterBasedPII parameterBasedPII = null)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetShipment(shipmentId), RestSharp.Method.Delete, parameter: parameterBasedPII);

            var response = await ExecuteRequestAsync<GetShipmentResponse>(RateLimitType.MerchantFulFillment_CancelShipment);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment CancelShipmentOld(string shipmentId, IParameterBasedPII parameterBasedPII = null) =>
            Task.Run(() => CancelShipmentOldAsync(shipmentId, parameterBasedPII)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<Shipment> CancelShipmentOldAsync(string shipmentId, IParameterBasedPII ParameterBasedPII = null)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.CancelShipmentOld(shipmentId), RestSharp.Method.Put, parameter: ParameterBasedPII);

            var response = await ExecuteRequestAsync<GetShipmentResponse>(RateLimitType.MerchantFulFillment_CancelShipmentOld);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment CreateShipment(CreateShipmentRequest createShipmentRequest, IParameterBasedPII parameterBasedPII = null) =>
            Task.Run(() => CreateShipmentAsync(createShipmentRequest, parameterBasedPII)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<Shipment> CreateShipmentAsync(CreateShipmentRequest createShipmentRequest, IParameterBasedPII parameterBasedPII = null)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.CreateShipment, RestSharp.Method.Post, postJsonObj: createShipmentRequest, parameter: parameterBasedPII);

            var response = await ExecuteRequestAsync<CreateShipmentResponse>(RateLimitType.MerchantFulFillment_CreateShipment);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetAdditionalSellerInputsResult GetAdditionalSellerInputsOld(GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest) =>
            Task.Run(() => GetAdditionalSellerInputsOldAsync(getAdditionalSellerInputsRequest)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<GetAdditionalSellerInputsResult> GetAdditionalSellerInputsOldAsync(GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetAdditionalSellerInputsOld, RestSharp.Method.Post, postJsonObj: getAdditionalSellerInputsRequest);

            var response = await ExecuteRequestAsync<GetAdditionalSellerInputsResponse>(RateLimitType.MerchantFulFillment_GetAdditionalSellerInputsOld);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetAdditionalSellerInputsResult GetAdditionalSellerInputs(GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest) =>
            Task.Run(() => GetAdditionalSellerInputsAsync(getAdditionalSellerInputsRequest)).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task<GetAdditionalSellerInputsResult> GetAdditionalSellerInputsAsync(GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetAdditionalSellerInputs, RestSharp.Method.Post, postJsonObj: getAdditionalSellerInputsRequest);

            var response = await ExecuteRequestAsync<GetAdditionalSellerInputsResponse>(RateLimitType.MerchantFulFillment_GetAdditionalSellerInputs);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}
