using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._54
{
    class PokerHands : ITestable
    {
        char[] order = new char[] { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
        public void Test()
        {
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Problems\\54\\poker.txt"));
            string[] hands = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (hands != null)
            {
                int count = 0;
                for (int i = 0; i < hands.Length; i++)
                {
                    Hand p1 = Hand.Parse(hands[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), 0, 5);
                    Hand p2 = Hand.Parse(hands[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), 5, 5);

                    var m1 = ComputeMarks(p1);
                    var m2 = ComputeMarks(p2);
                    if (m1.Value == m2.Value)
                    {
                        Console.WriteLine($"Draw at {i}, {p1} and {p2}  ({m1.Description})");
                    }
                    else if (m1.Value > m2.Value)
                        count++;
                }

                Console.WriteLine($"Count is {count}");
            }

        }

        private MatchResult ComputeMarks(Hand p)
        {
            if (p.HasRoyalFlush())
            {
                return new MatchResult("Royal flush", 900);
            }

            if (p.HasStraightFlush())
            {
                return new MatchResult("Straight flush", 800);
            }

            if (p.HasFourOfKind())
            {
                return new MatchResult("Four of a kind", 700);
            }

            if (p.HasFullHouse())
            {
                return new MatchResult("Full house", 600);
            }


            if (p.HasFlush())
            {
                return new MatchResult("Flush", 500);
            }

            if (p.HasStraight())
            {
                return new MatchResult("Straight", 400);
            }

            if (p.HasThreeOfKind())
            {
                return new MatchResult("Three of a kind", 300);
            }

            if (p.HasTwoPairs(out var indexa))
            {
                return new MatchResult("Two pairs", 200+indexa);
            }

            if (p.HasOnePair(out var index))
            {
                return new MatchResult("One pair", 100 + index);
            }

            if (p.HasHigh())
            {
                return new MatchResult("High card", 10);
            }

            return null;
        }

        //High Card: Highest value card.
        //One Pair: Two cards of the same value.
        //Two Pairs: Two different pairs.
        //Three of a Kind: Three cards of the same value.
        //Straight: All cards are consecutive values.
        //Flush: All cards of the same suit.
        //Full House: Three of a kind and a pair.
        //Four of a Kind: Four cards of the same value.
        //Straight Flush: All cards are consecutive values of same suit.
        //Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.
    }

    class Card
    {
        public Card(char value, char suit)
        {
            Value = value;
            Suit = suit;
        }
        public char Value
        {
            get; private set;
        }

        public char Suit
        {
            get; private set;
        }

        public override string ToString()
        {
            return $"{Value}{Suit}";
        }
    }

    class Hand
    {
        public const string CardMap = "23456789TJQKA";

        /// <summary>
        /// The cards
        /// </summary>
        private Card[] cards;

        private Hand(Card[] cards)
        {
            this.cards = cards;
        }
        public override string ToString()
        {
            return string.Join<Card>(' ', cards);
        }

        /// <summary>
        /// Gets the cards.
        /// </summary>
        /// <value>
        /// The cards.
        /// </value>
        public Card[] Cards => cards;

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length => cards?.Length ?? 0;



        public static Hand Parse(string[] hands, int start, int count)
        {
            var cards = new Card[count];
            for (int i = start; i < hands.Length && i < start + count; i++)
            {
                cards[i- start] = new Card(hands[i][0], hands[i][1]);
            }

            return new Hand(cards);
        }

        public bool ContainCardValue(char card)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].Value == card)
                    return true;
            }

            return false;
        }

        public bool ContainCardValues(params char[] cards)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (!ContainCardValue(cards[i]))
                    return false;
            }

            return true;
        }

        public int GeCardValueCount(char card)
        {
            int count = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].Value == card)
                    count++;
            }

            return count;
        }

        public bool HasFlush()
        {
            var suit = cards[0].Suit;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].Suit != suit)
                    return false;
            }

            return true;
        }

        public bool HasRoyalFlush()
        {
            if (Length != 5)
                return false;
            if (!HasFlush())
                return false;
            return ContainCardValues('T', 'J', 'Q', 'K', 'A');
        }

        public bool HasStraightFlush()
        {
            return HasFlush() && HasStraight();
        }

        Card GetHighCard()
        {
            int highIndex = 0;
            Card result= cards[0];
            for (int i = 0; i < cards.Length; i++)
            {
                int index = CardMap.IndexOf(cards[i].Value);
                if (index > highIndex)
                {
                    result = cards[i];
                    highIndex = index;
                }
                   
            }

            return result;
        }

        public bool HasStraight()
        {
            var sorted = SortHand(this.cards);
            int lowIndex = CardMap.IndexOf(sorted[0].Value);
            for (int i = 0; i < sorted.Length; i++)
            {
                if (CardMap.IndexOf(sorted[i].Value) != lowIndex + i)
                    return false;
            }

            return true;
        }

        Card[] SortHand(Card[] cards, bool inPlace = false)
        {
            var result = cards;
            if (!inPlace)
            {
                 result = new Card[cards.Length];
            }

            for (int i = 0; i < cards.Length; i++)
            {
                result[i] = cards[i];
            }

            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 1; i < result.Length; i++)
                {
                    if (CardMap.IndexOf(result[i].Value) < CardMap.IndexOf(result[i - 1].Value))
                    {
                        changed = true;
                        var temp = result[i];
                        result[i] = result[i - 1];
                        result[i - 1] = temp;
                        break;
                    }
                }
            }

            return result;
        }

        public bool HasFourOfKind()
        {
            int[] counts = new int[CardMap.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                int count = GeCardValueCount(cards[i].Value);
                if (count == 4)
                    return true;
            }

            return false;
        }

        internal bool HasFullHouse()
        {
            int[] counts = new int[CardMap.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                counts[CardMap.IndexOf(cards[i].Value)]++;
            }

            bool rank3=false, rank2 = false;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 3)
                    rank3 = true;
                if (counts[i] == 2)
                    rank2 = true;
            }

            return rank2 && rank3;
        }

        internal bool HasThreeOfKind()
        {
            int[] counts = new int[CardMap.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                int count = GeCardValueCount(cards[i].Value);
                if (count == 3)
                    return true;
            }

            return false;
        }

        internal bool HasTwoPairs(out int index)
        {
            index = 0;
            int[] counts = new int[CardMap.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                counts[CardMap.IndexOf(cards[i].Value)]++;
            }

            bool rank3 = false, rank2 = false;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 2)
                {
                    index += 13 * i;
                    rank3 = true;
                }

                if (counts[i] == 2)
                {
                    index += i;
                    rank2 = true;
                }

            }

            return rank2 && rank3;
        }

        internal bool HasOnePair(out int index)
        {
            index = 0;
            int[] counts = new int[CardMap.Length];
            for (int i = 0; i < cards.Length; i++)
            {
                int count = GeCardValueCount(cards[i].Value);
                if (count == 2)
                {
                    index = i;
                    return true;
                }
                    
            }

            return false;
        }

        internal bool HasHigh()
        {
            var hi = GetHighCard();
            return true;
        }
    }

    class MatchResult
    {
        public MatchResult(string description, int value)
        {
            Description = description;
            Value = value;
        }

        public string Description { get; }
        public int Value { get; }
    }
}
