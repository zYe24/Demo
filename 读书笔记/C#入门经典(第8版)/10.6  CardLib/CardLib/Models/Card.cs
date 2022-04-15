using System.ComponentModel;
using CardLib.Enum;

namespace CardLib.Models;

/// <summary>
/// 扑克牌
/// </summary>
[Description("扑克牌")]
public class Card
{
    /// <summary>
    /// 花色
    /// </summary>
    private readonly Suit _suit;

    /// <summary>
    /// 大小
    /// </summary>
    private readonly Rank _rank;

    /// <summary>
    /// 私有默认构造函数
    /// </summary>
    private Card()
    {
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="suit">花色</param>
    /// <param name="rank">大小</param>
    public Card(Suit suit, Rank rank)
    {
        _suit = suit;
        _rank = rank;
    }

    /// <summary>
    /// 重写ToString方法
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"The {_rank} of {_suit}s";
}