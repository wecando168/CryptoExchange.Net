using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.Interfaces.CommonClients;
using CryptoExchange.Net.Objects;

namespace CryptoExchange.Net.Interfaces.CommonClients
{
    /// <summary>
    /// Common usdt margined endpoints
    /// U本位合约
    /// </summary>
    public interface IUsdtMarginedClient : IBaseRestClient
    {
        /// <summary>
        /// Place an Isolated usdt margined order
        /// 【逐仓】U本位合约下单
        /// </summary>
        /// <param name="contractCode">合约代码 "BTC-USDT"...</param>
        /// <param name="direction">仓位方向 "buy":买 "sell":卖</param>
        /// <param name="offset">开平方向 "open":开 "close":平 “both”:单向持仓</param>
        /// <param name="price">价格</param>
        /// <param name="leverRate">杠杆倍数[“开仓”若有10倍多单，就不能再下20倍多单;高倍杠杆风险系数较大，请谨慎使用。	</param>
        /// <param name="volume">委托数量(张)</param>
        /// <param name="orderPriceType">订单报价类型	"limit":限价，"opponent":对手价 ，"post_only":只做maker单,post only下单只受用户持仓数量限制,"optimal_5"：最优5档，"optimal_10"：最优10档，"optimal_20"：最优20档，"ioc":IOC订单，"fok"：FOK订单, "opponent_ioc": 对手价-IOC下单，"optimal_5_ioc": 最优5档-IOC下单，"optimal_10_ioc": 最优10档-IOC下单，"optimal_20_ioc"：最优20档-IOC下单，"opponent_fok"： 对手价-FOK下单，"optimal_5_fok"：最优5档-FOK下单，"optimal_10_fok"：最优10档-FOK下单，"optimal_20_fok"：最优20档-FOK下单</param>
        /// <param name="tpTriggerPrice">止盈触发价格</param>
        /// <param name="tpOrderPrice">止盈委托价格（最优N档委托类型时无需填写价格）</param>
        /// <param name="tpOrderPriceType">止盈委托类型	不填默认为limit; 限价：limit ，最优5档：optimal_5，最优10档：optimal_10，最优20档：optimal_20</param>
        /// <param name="slTriggerPrice">止损触发价格</param>
        /// <param name="slOrderPrice">止损委托价格（最优N档委托类型时无需填写价格）</param>
        /// <param name="slOrderPriceType">止损委托类型	不填默认为limit; 限价：limit ，最优5档：optimal_5，最优10档：optimal_10，最优20档：optimal_20</param>
        /// <param name="reduceOnly">是否为只减仓订单（该字段在双向持仓模式下无效，在单向持仓模式下不填默认为0。）	0:表示为非只减仓订单，1:表示为只减仓订单</param>
        /// <param name="clientOrderId">客户自己填写和维护，必须为数字	[1-9223372036854775807]</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<OrderId>> LinearSwapOrder(
            string contractCode,
            UmDirection direction,
            UmOffset offset,
            decimal price,
            UmLeverRate leverRate,
            long volume,
            UmOrderPriceType orderPriceType,
            decimal tpTriggerPrice,
            decimal tpOrderPrice,
            UmOrderPriceType tpOrderPriceType,
            decimal slTriggerPrice,
            decimal slOrderPrice,
            UmOrderPriceType slOrderPriceType,
            int? reduceOnly = null,
            string? clientOrderId = null,
            CancellationToken ct = default
            );

        /// <summary>
        /// Place an Cross usdt margined order
        /// 【全仓】U本位合约下单
        /// </summary>
        /// <param name="contractCode">合约代码 Contract code. Case-Insenstive.Both uppercase and lowercase are supported.e.g. "BTC-USDT"</param>
        /// <param name="direction">仓位方向 "buy":买 "sell":卖</param>
        /// <param name="offset">开平方向	"open":开 "close":平 “both”:单向持仓</param>
        /// <param name="price">价格 The price of the order, only for limit orders</param>
        /// <param name="leverRate">杠杆倍数[“开仓”若有10倍多单，就不能再下20倍多单;高倍杠杆风险系数较大，请谨慎使用。</param>
        /// <param name="volume">委托数量(张)</param>
        /// <param name="orderPriceType">订单报价类型 "limit":限价，"opponent":对手价 ，"post_only":只做maker单,post only下单只受用户持仓数量限制,"optimal_5"：最优5档，"optimal_10"：最优10档，"optimal_20"：最优20档，"ioc":IOC订单，"fok"：FOK订单, "opponent_ioc": 对手价-IOC下单，"optimal_5_ioc": 最优5档-IOC下单，"optimal_10_ioc": 最优10档-IOC下单，"optimal_20_ioc"：最优20档-IOC下单，"opponent_fok"： 对手价-FOK下单，"optimal_5_fok"：最优5档-FOK下单，"optimal_10_fok"：最优10档-FOK下单，"optimal_20_fok"：最优20档-FOK下单</param>
        /// <param name="tpTriggerPrice">止盈触发价格</param>
        /// <param name="tpOrderPrice">止盈委托价格（最优N档委托类型时无需填写价格）</param>
        /// <param name="tpOrderPriceType">止盈委托类型 不填默认为limit; 限价：limit ，最优5档：optimal_5，最优10档：optimal_10，最优20档：optimal_20</param>
        /// <param name="slTriggerPrice">止损触发价格</param>
        /// <param name="slOrderPrice">止损委托价格（最优N档委托类型时无需填写价格）</param>
        /// <param name="slOrderPriceType">止损委托类型	不填默认为limit; 限价：limit ，最优5档：optimal_5，最优10档：optimal_10，最优20档：optimal_20</param>
        /// <param name="pair">交易对	BTC-USDT</param>
        /// <param name="contractType">合约类型	swap（永续）、this_week（当周）、next_week（次周）、quarter（当季）、next_quarter（次季）</param>
        /// <param name="clientOrderId">用户自定义单号</param>
        /// <param name="reduceOnly">是否为只减仓订单（该字段在双向持仓模式下无效，在单向持仓模式下不填默认为0。）	0:表示为非只减仓订单，1:表示为只减仓订单</param>
        /// <param name="ct">[Optional] Cancellation token for cancelling the request</param>
        /// <returns></returns>
        Task<WebCallResult<OrderId>> LinearSwapCrossOrder(
            string contractCode,
            UmDirection direction,
            UmOffset offset,
            decimal price,
            UmLeverRate leverRate,
            long volume,
            UmOrderPriceType orderPriceType,
            decimal tpTriggerPrice,
            decimal tpOrderPrice,
            UmOrderPriceType tpOrderPriceType,
            decimal slTriggerPrice,
            decimal slOrderPrice,
            UmOrderPriceType slOrderPriceType,
            string? pair = null,
            string? contractType = null,
            int? reduceOnly = null,
            string? clientOrderId = null,
            CancellationToken ct = default
            );

        /// <summary>
        /// Get position
        /// 【逐仓】获取用户持仓信息
        /// 该接口仅支持逐仓模式。
        /// </summary>
        /// <param name="contractCode">合约代码	"BTC-USDT"... ,如果缺省，默认返回所有合约</param>
        /// <param name="ct">[Optional] Cancellation token for cancelling the request</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<Position>>> GetLinearSwapPositionInfoAsync(
            string? contractCode = null, 
            CancellationToken ct = default
            );

        /// <summary>
        /// Get position
        /// 【全仓】获取用户持仓信息
        /// 该接口仅支持全仓模式。
        /// 请求参数contract_code支持交割合约代码调用，格式为：BTC-USDT-211225。
        /// pair、contract_type和contract_code同时填写，优先取contract_code。如果全部缺省，则默认返回所有合约持仓（永续和交割）。
        /// </summary>
        /// <param name="contractCode">合约代码 永续："BTC-USDT"... ， 交割：“BTC-USDT-210625” ...</param>
        /// <param name="pair">交易对	BTC-USDT</param>
        /// <param name="umContractType">合约类型	swap（永续）、this_week（当周）、next_week（次周）、quarter（当季）、next_quarter（次季）</param>
        /// <param name="ct">[Optional] Cancellation token for cancelling the request</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<Position>>> GetLinearSwapCrossPositionInfoAsync(
            string? contractCode = null, 
            string? pair = null, 
            UmContractType? umContractType = null, 
            CancellationToken ct = default
            );
    }
}
