using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool isValidHand = false;

            if (hand.Cards.Count==5)
            {
                isValidHand = true;
            }
            else
            {
                isValidHand = false;
            }
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (isValidHand)
                {
                    for (int j = i+1; j < hand.Cards.Count; j++)
                    {
                        if ((hand.Cards[i].Face == hand.Cards[j].Face) && (hand.Cards[i].Suit == hand.Cards[j].Suit))
                        {
                            isValidHand = false;
                            break;
                        }
                    }
                }
            }
            return isValidHand;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (IsHandStraight(hand)&&IsHandFlush(hand))
            {
                return true;
            }
            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool isFourOfAKind = false;
            if (IsValidHand(hand))
            {
                SortedDictionary<int, int> cardFacesCount = CountCardFaces(hand);
                foreach (var card in cardFacesCount)
                {
                    if (card.Value == 4)
                    {
                        isFourOfAKind = true;
                        break;
                    }
                }
            }
            return isFourOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (IsHandThreeOfAKind(hand)&&IsHandOnePair(hand))
            {
                return true;
            }
            return false;
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsHandStraight(hand))
            {
                if (IsHandFlush(hand))
                {
                    return true;
                }
            }
            return false;
        }


        public bool IsStraight(IHand hand)
        {
            if (!IsHandFlush(hand))
            {
                if (IsHandStraight(hand))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!IsHandOnePair(hand))
            {
                if (IsHandThreeOfAKind(hand))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            bool isTwoPair = false;
            int counterOfPairs = 0;
            if (IsValidHand(hand))
            {
                SortedDictionary<int, int> cardFacesCount = CountCardFaces(hand);
                foreach (var card in cardFacesCount)
                {
                    if (card.Value == 2)
                    {
                        counterOfPairs++;
                    }
                }
                if (counterOfPairs == 2)
                {
                    isTwoPair = true;
                }
            }
            return isTwoPair;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!IsHandThreeOfAKind(hand))
            {
                if (IsHandOnePair(hand))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            bool isHighCard = false;
            if (IsValidHand(hand))
            {
                bool isNothing=!IsStraightFlush(hand)&&!IsFourOfAKind(hand)&&!IsFullHouse(hand)&&
                    !IsFlush(hand)&&!IsStraight(hand)&&!IsThreeOfAKind(hand)&&!IsTwoPair(hand)&&!IsOnePair(hand);
                if (isNothing)
                {
                    return true;
                }
            }
            return isHighCard;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            int firstHandPower=GetHandPower(firstHand);
            int secondHandPower = GetHandPower(secondHand);

            if (firstHandPower > secondHandPower)
            {
                return 1;
            }
            else if (firstHandPower == secondHandPower)
            {
                return 0;
            }
            else
	        {
                return -1;  
	        }
        }

        private int GetHandPower(IHand firstHand)
        {
            int numberOfPossibleHandCombinations = 9;
            int[] handsPower = new int[numberOfPossibleHandCombinations];
            int power = 0;
            if (IsStraightFlush(firstHand))
            {
                handsPower[8]++;
            }
            else if (IsFourOfAKind(firstHand))
            {
                handsPower[7]++;
            }
            else if (IsFullHouse(firstHand))
            {
                handsPower[6]++;
            }
            else if (IsFlush(firstHand))
            {
                handsPower[5]++;
            }
            else if (IsStraight(firstHand))
            {
                handsPower[4]++;
            }
            else if (IsThreeOfAKind(firstHand))
            {
                handsPower[3]++;
            }
            else if (IsTwoPair(firstHand))
            {
                handsPower[2]++;
            }
            else if (IsOnePair(firstHand))
            {
                handsPower[1]++;
            }
            else
            {
                handsPower[0]++;
            }

            for (int i = 0; i < handsPower.Length; i++)
            {
                if (handsPower[i] == 1)
                {
                    power = i;
                    break;
                }
            }

            return power;
        }

        private SortedDictionary<string, int> CountCardSuits(IHand hand)
        {
            SortedDictionary<string, int> cardSuitsCount = new SortedDictionary<string, int>();
            foreach (var card in hand.Cards)
            {
                if (cardSuitsCount.ContainsKey(card.Suit.ToString()))
                {
                    cardSuitsCount[card.Suit.ToString()]++;
                }
                else
                {
                    cardSuitsCount.Add(card.Suit.ToString(), 1);
                }
            }
            return cardSuitsCount;
        }

        private SortedDictionary<int, int> CountCardFaces(IHand hand)
        {
            SortedDictionary<int, int> cardFacesCount = new SortedDictionary<int, int>();
            foreach (var card in hand.Cards)
            {
                if (cardFacesCount.ContainsKey((int)card.Face))
                {
                    cardFacesCount[(int)card.Face]++;
                }
                else
                {
                    cardFacesCount.Add((int)card.Face, 1);
                }
            }
            return cardFacesCount;
        }

        private bool IsHandFlush(IHand hand)
        {
            bool isFlush = false;
            if (IsValidHand(hand))
            {
                SortedDictionary<string, int> cardSuitsCount = CountCardSuits(hand);

                foreach (var card in cardSuitsCount)
                {
                    if (card.Value == 5)
                    {
                        isFlush = true;
                        break;
                    }
                }
            }

            return isFlush;
        }

        private bool IsHandStraight(IHand hand)
        {
            bool isStraight = false;
            int counterOfConsecutiveCards = 1;
            if (IsValidHand(hand))
            {
                SortedDictionary<int, int> cardFacesCount = CountCardFaces(hand);

                // Store keys in a List
                List<int> faces = new List<int>(cardFacesCount.Keys);

                for (int i = 0; i < cardFacesCount.Count - 1; i++)
                {
                    //using sorted dictionary(so if there are two consecutive cards increase counter with 1)
                    if (faces[i] + 1 == faces[i + 1])
                    {
                        counterOfConsecutiveCards++;
                    }
                }
                if (counterOfConsecutiveCards == 5)
                {
                    isStraight = true;
                }
            }
            return isStraight;
        }

        private bool IsHandOnePair(IHand hand)
        {
            bool isOnePair = false;
            int counterOfPairs = 0;
            if (IsValidHand(hand))
            {
                SortedDictionary<int, int> cardFacesCount = CountCardFaces(hand);
                foreach (var card in cardFacesCount)
                {
                    if (card.Value == 2)
                    {
                        counterOfPairs++;
                    }
                }
                if (counterOfPairs == 1)
                {
                    isOnePair = true;
                }
            }
            return isOnePair;
        }

        private bool IsHandThreeOfAKind(IHand hand)
        {
            bool isThreeOfAKind = false;
            if (IsValidHand(hand))
            {
                SortedDictionary<int, int> cardFacesCount = CountCardFaces(hand);
                foreach (var card in cardFacesCount)
                {
                    if (card.Value == 3)
                    {
                        isThreeOfAKind = true;
                        break;
                    }
                }
            }
            return isThreeOfAKind;
        }
    }
}
