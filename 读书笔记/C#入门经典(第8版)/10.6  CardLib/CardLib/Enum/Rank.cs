using System.ComponentModel;

namespace CardLib.Enum;

/// <summary>
/// 大小
/// </summary>
[Description("大小")]
public enum Rank
{
    /// <summary>
    /// A
    /// </summary>
    [Description("A")] Ace = 1,

    /// <summary>
    /// 2
    /// </summary>
    [Description("2")] Deuce,

    /// <summary>
    /// 3
    /// </summary>
    [Description("3")] Three,

    /// <summary>
    /// 4
    /// </summary>
    [Description("4")] Four,

    /// <summary>
    /// 5
    /// </summary>
    [Description("5")] Five,

    /// <summary>
    /// 6
    /// </summary>
    [Description("6")] Six,

    /// <summary>
    /// 7
    /// </summary>
    [Description("7")] Seven,

    /// <summary>
    /// 8
    /// </summary>
    [Description("8")] Eight,

    /// <summary>
    /// 9
    /// </summary>
    [Description("9")] Nine,

    /// <summary>
    /// 10
    /// </summary>
    [Description("10")] Ten,

    /// <summary>
    /// J
    /// </summary>
    [Description("J")] Jack,

    /// <summary>
    /// Q
    /// </summary>
    [Description("Q")] Queen,

    /// <summary>
    /// K
    /// </summary>
    [Description("K")] King
}