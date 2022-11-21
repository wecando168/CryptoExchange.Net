using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchange.Net.CommonObjects
{
    /// <summary>
    /// Position Mode 持仓模式
    /// </summary>
    public enum CmPositionMode
    {
        /// <summary>
        /// Limit type
        /// 单向持仓
        /// </summary>
        single_side,

        /// <summary>
        /// Market type
        /// 双向持仓
        /// </summary>
        dual_side
    }

    /// <summary>
    /// Reduce Only
    /// 是否为只减仓订单
    /// 该字段在双向持仓模式下无效
    /// 0:表示为非只减仓订单，1:表示为只减仓订单
    /// </summary>
    public enum CmReduceOnly
    {
        /// <summary>
        /// 只减仓订单
        /// </summary>
        ReduceOnly = 1,

        /// <summary>
        /// 非只减仓订单
        /// </summary>
        NotReduceOnly = 0,
    }

    /// <summary>
    /// Direction
    /// 仓位方向
    /// </summary>
    public enum CmDirection
    {
        /// <summary>
        /// 买 
        /// </summary>
        buy,
        /// <summary>
        /// 卖
        /// </summary>
        sell
    }

    /// <summary>
    /// Offset
    /// 开平方向
    /// </summary>
    public enum CmOffset
    {
        /// <summary>
        /// 开
        /// </summary>
        open,
        /// <summary>
        /// 平
        /// </summary>
        close,
        /// <summary>
        /// 单向持仓
        /// </summary>
        both
    }

    /// <summary>
    /// Lever Rate
    /// 杠杆倍数
    /// </summary>
    public enum CmLeverRate
    {
        /// <summary>
        /// 不加杠杆
        /// </summary>
        LeverRate_1 = 1,

        /// <summary>
        /// 2倍杠杆
        /// </summary>
        LeverRate_2 = 2,

        /// <summary>
        /// 3倍杠杆
        /// </summary>
        LeverRate_3 = 3,

        /// <summary>
        /// 4倍杠杆
        /// </summary>
        LeverRate_4 = 4,

        /// <summary>
        /// 5倍杠杆
        /// </summary>
        LeverRate_5 = 5,

        /// <summary>
        /// 6倍杠杆
        /// </summary>
        LeverRate_6 = 6,

        /// <summary>
        /// 7倍杠杆
        /// </summary>
        LeverRate_7 = 7,

        /// <summary>
        /// 8倍杠杆
        /// </summary>
        LeverRate_8 = 8,

        /// <summary>
        /// 9倍杠杆
        /// </summary>
        LeverRate_9 = 9,

        /// <summary>
        /// 10倍杠杆
        /// </summary>
        LeverRate_10 = 10,

        /// <summary>
        /// 15倍杠杆
        /// </summary>
        LeverRate_15 = 15,

        /// <summary>
        /// 20倍杠杆
        /// </summary>
        LeverRate_20 = 20,

        /// <summary>
        /// 25倍杠杆
        /// </summary>
        LeverRate_25 = 25,

        /// <summary>
        /// 30倍杠杆
        /// </summary>
        LeverRate_30 = 30,

        /// <summary>
        /// 35倍杠杆
        /// </summary>
        LeverRate_35 = 35,

        /// <summary>
        /// 40倍杠杆
        /// </summary>
        LeverRate_40 = 40,

        /// <summary>
        /// 45倍杠杆
        /// </summary>
        LeverRate_45 = 45,

        /// <summary>
        /// 50倍杠杆
        /// </summary>
        LeverRate_50 = 50,

        /// <summary>
        /// 55倍杠杆
        /// </summary>
        LeverRate_55 = 55,

        /// <summary>
        /// 60倍杠杆
        /// </summary>
        LeverRate_60 = 60,

        /// <summary>
        /// 65倍杠杆
        /// </summary>
        LeverRate_65 = 65,

        /// <summary>
        /// 70倍杠杆
        /// </summary>
        LeverRate_70 = 70,

        /// <summary>
        /// 75倍杠杆
        /// </summary>
        LeverRate_75 = 75,        
    }

    /// <summary>
    /// Order Price Type
    /// 订单报价类型
    /// </summary>
    public enum CmOrderPriceType
    {
        /// <summary>
        /// 限价
        /// </summary>
        limit,

        /// <summary>
        /// 对手价
        /// </summary>
        opponent,

        /// <summary>
        /// 只做maker单
        /// post only下单只受用户持仓数量限制
        /// </summary>
        post_only,

        /// <summary>
        /// 最优5档
        /// </summary>
        optimal_5,

        /// <summary>
        /// 最优10档
        /// </summary>
        optimal_10,

        /// <summary>
        /// 最优20档
        /// </summary>
        optimal_20,

        /// <summary>
        /// IOC订单
        /// </summary>
        ioc,

        /// <summary>
        /// FOK订单
        /// </summary>
        fok,

        /// <summary>
        /// 对手价-IOC下单
        /// </summary>
        opponent_ioc,

        /// <summary>
        /// 最优5档-IOC下单
        /// </summary>
        optimal_5_ioc,

        /// <summary>
        /// 最优10档-IOC下单
        /// </summary>
        optimal_10_ioc,

        /// <summary>
        /// 最优20档-IOC下单
        /// </summary>
        optimal_20_ioc,

        /// <summary>
        /// 对手价-FOK下单
        /// </summary>
        opponent_fok,

        /// <summary>
        /// 最优5档-FOK下单
        /// </summary>
        optimal_5_fok,

        /// <summary>
        /// 最优10档-FOK下单
        /// </summary>
        optimal_10_fok,

        /// <summary>
        /// 最优20档-FOK下单
        /// </summary>
        optimal_20_fok
    }

    /// <summary>
    /// Tp Order Price Type
    /// 止盈委托类型
    /// </summary>
    public enum CmTpOrderPriceType
    {
        /// <summary>
        /// 限价
        /// </summary>
        limit,

        /// <summary>
        /// 最优5档
        /// </summary>
        optimal_5,

        /// <summary>
        /// 最优10档
        /// </summary>
        optimal_10,

        /// <summary>
        /// 最优20档
        /// </summary>
        optimal_20
    }

    /// <summary>
    /// SL Order Price Type
    /// 止损委托类型
    /// </summary>
    public enum CmSlOrderPriceType
    {
        /// <summary>
        /// 限价
        /// </summary>
        limit,

        /// <summary>
        /// 最优5档
        /// </summary>
        optimal_5,

        /// <summary>
        /// 最优10档
        /// </summary>
        optimal_10,

        /// <summary>
        /// 最优20档
        /// </summary>
        optimal_20
    }
}
