// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// PolymorphicrecursiveOperations operations.
    /// </summary>
    public partial interface IPolymorphicrecursiveOperations
    {
        /// <summary>
        /// Get complex types that are polymorphic and have recursive
        /// references
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<FishInner>> GetValidWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Put complex types that are polymorphic and have recursive
        /// references
        /// </summary>
        /// <param name='complexBody'>
        /// Please put a salmon that looks like this:
        /// {
        /// "fishtype": "salmon",
        /// "species": "king",
        /// "length": 1,
        /// "age": 1,
        /// "location": "alaska",
        /// "iswild": true,
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "length": 20,
        /// "age": 6,
        /// "siblings": [
        /// {
        /// "fishtype": "salmon",
        /// "species": "coho",
        /// "length": 2,
        /// "age": 2,
        /// "location": "atlantic",
        /// "iswild": true,
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "length": 20,
        /// "age": 6
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// }
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> PutValidWithHttpMessagesAsync(FishInner complexBody, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
