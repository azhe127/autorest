// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// OdataOperations operations.
    /// </summary>
    internal partial class OdataOperations : IServiceOperations<AutoRestAzureSpecialParametersTestClient>, IOdataOperations
    {
        /// <summary>
        /// Initializes a new instance of the OdataOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal OdataOperations(AutoRestAzureSpecialParametersTestClient client)
        {
            if (client == null) 
            {
                throw new ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the AutoRestAzureSpecialParametersTestClient
        /// </summary>
        public AutoRestAzureSpecialParametersTestClient Client { get; private set; }

        /// <summary>
        /// Specify filter parameter with value '$filter=id gt 5 and name eq
        /// 'foo'&amp;$orderby=id&amp;$top=10'
        /// </summary>
        /// <param name='odataQuery'>
        /// The filter parameter with value '$filter=id gt 5 and name eq 'foo''.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<AzureOperationResponse> GetWithFilterWithHttpMessagesAsync(ODataQuery<OdataFilter> odataQuery = default(ODataQuery<OdataFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("odataQuery", odataQuery);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "GetWithFilter", tracingParameters);
            }
            // Construct URL
            var baseUrl = this.Client.BaseUri.AbsoluteUri;
            var url = new Uri(new Uri(baseUrl + (baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/odata/filter").ToString();
            List<string> queryParameters = new List<string>();
            if (odataQuery != null)
            {
                var _odataFilter = filter.ToString();
                if (!string.IsNullOrEmpty(_odataFilter)) 
                {
                    queryParameters.Add(_odataFilter);
                }
            }
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", Guid.NewGuid().ToString());
            if (this.Client.AcceptLanguage != null)
            {
                if (httpRequest.Headers.Contains("accept-language"))
                {
                    httpRequest.Headers.Remove("accept-language");
                }
                httpRequest.Headers.TryAddWithoutValidation("accept-language", this.Client.AcceptLanguage);
            }
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    if (httpRequest.Headers.Contains(header.Key))
                    {
                        httpRequest.Headers.Remove(header.Key);
                    }
                    httpRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if ((int)statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                try
                {
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error errorBody = JsonConvert.DeserializeObject<Error>(responseContent, this.Client.DeserializationSettings);
                    if (errorBody != null)
                    {
                        ex.Body = errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new AzureOperationResponse();
            result.Request = httpRequest;
            result.Response = httpResponse;
            if (httpResponse.Headers.Contains("x-ms-request-id"))
            {
                result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

    }
}
