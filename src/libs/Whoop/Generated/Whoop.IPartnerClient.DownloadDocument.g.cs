#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Download a document's content<br/>
        /// Returns the raw bytes of a document. Documents that are only a link carry no content - use the url on the document itself. The requesting partner must be an owner of the document.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task DownloadDocumentAsync(
            global::System.Guid id,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download a document's content<br/>
        /// Returns the raw bytes of a document. Documents that are only a link carry no content - use the url on the document itself. The requesting partner must be an owner of the document.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse> DownloadDocumentAsResponseAsync(
            global::System.Guid id,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}