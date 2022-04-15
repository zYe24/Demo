using System.ComponentModel;

namespace CardLib.Enum;

/// <summary>
/// 花色
/// </summary>
[Description("花色")]
public enum Suit
{
    /// <summary>
    /// 方片
    /// </summary>
    [Description("方片")] Club,

    /// <summary>
    /// 梅花
    /// </summary>
    [Description("梅花")] Diamond,

    /// <summary>
    /// 红桃
    /// </summary>
    [Description("红桃")] Heart,

    /// <summary>
    /// 黑桃
    /// </summary>
    [Description("黑桃")] Spade
}