using CardLib.Enum;

namespace CardLib.Models;

/// <summary>
/// 一副完整扑克牌
/// </summary>
public class Deck
{
    /// <summary>
    /// 所有扑克
    /// </summary>
    private readonly Card[] _cards = new Card[52];

    /// <summary>
    /// 构造函数
    /// </summary>
    public Deck()
    {
        for (int suitVal = 0; suitVal < 4; suitVal++)
        {
            for (int rankVal = 1; rankVal < 14; rankVal++)
            {
                _cards[suitVal * 13 + rankVal - 1] = new Card((Suit) suitVal, (Rank) rankVal);
            }
        }
    }

    /// <summary>
    /// 获取扑克牌
    /// </summary>
    /// <param name="cardNum"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Card GetCard(int cardNum)
    {
        if (cardNum >= 0 && cardNum <= 51) return _cards[cardNum];
        throw (new ArgumentOutOfRangeException(nameof(cardNum), cardNum, "Value must be between 0 and 51."));
    }

    /// <summary>
    /// 洗牌
    /// </summary>
    public void Shuffle()
    {
        Card[] newDeck = new Card[52];
        bool[] assigned = new bool[52];
        Random sourceGen = new Random();
        for (int i = 0; i < 52; i++)
        {
            int sourceCard = 0;
            bool foundCard = false;
            while (foundCard == false)
            {
                sourceCard = sourceGen.Next(52);
                if (assigned[sourceCard] == false)
                    foundCard = true;
            }

            assigned[sourceCard] = true;
            newDeck[i] = _cards[sourceCard];
        }

        newDeck.CopyTo(_cards, 0);
    }

    /// <summary>
    /// 自己实现洗牌
    /// </summary>
    public void Shuffle2()
    {
        _cards.OrderBy(card=>Guid.NewGuid()).ToArray().CopyTo(_cards, 0);
    }
}