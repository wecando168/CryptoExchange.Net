using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using System.Net.Http;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Interfaces
{
    /// <summary>
    /// Rate limiter interface
    /// 速率限制接口
    /// </summary>
    public interface IRateLimiter
    {
        /// <summary>
        /// Limit a request based on previous requests made
        /// 根据设定的限制规则限制请求
        /// </summary>
        /// <param name="log">日志 The logger</param>
        /// <param name="endpoint">请求端点 The endpoint the request is for</param>
        /// <param name="method">Http请求方法 The Http request method</param>
        /// <param name="signed">是否需要签名 Whether the request is singed(private) or not</param>
        /// <param name="apiKey">发出此请求的 api 密钥 The api key making this request</param>
        /// <param name="limitBehaviour">达到限制时的限制行为 The limit behavior for when the limit is reached</param>
        /// <param name="requestWeight">请求的权重 The weight of the request</param>
        /// <param name="ct">用于取消等待的取消标记 Cancellation token to cancel waiting</param>
        /// <returns>等待的时间（以毫秒为单位）The time in milliseconds spend waiting</returns>
        Task<CallResult<int>> LimitRequestAsync(Log log, string endpoint, HttpMethod method, bool signed, SecureString? apiKey, RateLimitingBehaviour limitBehaviour, int requestWeight, CancellationToken ct);
    }
}
