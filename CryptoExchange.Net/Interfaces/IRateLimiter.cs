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
    /// �������ƽӿ�
    /// </summary>
    public interface IRateLimiter
    {
        /// <summary>
        /// Limit a request based on previous requests made
        /// �����趨�����ƹ�����������
        /// </summary>
        /// <param name="log">��־ The logger</param>
        /// <param name="endpoint">����˵� The endpoint the request is for</param>
        /// <param name="method">Http���󷽷� The Http request method</param>
        /// <param name="signed">�Ƿ���Ҫǩ�� Whether the request is singed(private) or not</param>
        /// <param name="apiKey">����������� api ��Կ The api key making this request</param>
        /// <param name="limitBehaviour">�ﵽ����ʱ��������Ϊ The limit behavior for when the limit is reached</param>
        /// <param name="requestWeight">�����Ȩ�� The weight of the request</param>
        /// <param name="ct">����ȡ���ȴ���ȡ����� Cancellation token to cancel waiting</param>
        /// <returns>�ȴ���ʱ�䣨�Ժ���Ϊ��λ��The time in milliseconds spend waiting</returns>
        Task<CallResult<int>> LimitRequestAsync(Log log, string endpoint, HttpMethod method, bool signed, SecureString? apiKey, RateLimitingBehaviour limitBehaviour, int requestWeight, CancellationToken ct);
    }
}
