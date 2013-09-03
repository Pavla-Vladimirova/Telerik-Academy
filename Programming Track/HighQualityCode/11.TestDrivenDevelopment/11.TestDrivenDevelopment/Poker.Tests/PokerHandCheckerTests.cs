using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandCheckerTests
    {
        #region Test IsValidHand

        [TestMethod]
        public void TestIsValidHand()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Spades)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker=new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsValidHandWithTwoIdenticalCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsValidHandWithFiveIdenticalCardFaces()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Spades)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsValidHandWithThreeCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsStraightFlush

        [TestMethod]
        public void TestIsStraightFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Hearts),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightFlushWithInconsecutiveCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Eight,CardSuit.Clubs),
                new Card(CardFace.Six,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Clubs),
                new Card(CardFace.Nine,CardSuit.Clubs)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightFlushWithOnlyStraight()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightFlushWithOnlyFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Spades)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsFourOfAKind

        [TestMethod]
        public void TestIsFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFourOfAKindWithFiveIdentcialCardFaces()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsFullHouse

        [TestMethod]
        public void TestIsFullHouse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFullHouse(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsFlush

        [TestMethod]
        public void TestIsFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Spades)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushWithDifferentSuit()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Spades)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushWithStraightFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Hearts),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsStraight

        [TestMethod]
        public void TestIsStraight()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraight(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightWithInconsecutiveCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Eight,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraight(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightWithStraightFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Hearts),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraight(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion
        
        #region Test IsThreeOfAKind

        [TestMethod]
        public void TestIsThreeOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsThreeOfAKindWithFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        public void TestIsThreeOfAKindWithFullHouse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsTwoPair

        [TestMethod]
        public void TestIsTwoPair()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsTwoPairWithFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsOnePair

        [TestMethod]
        public void TestIsOnePair()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsOnePairWithTwoPairs()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsOnePairWithThreeOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsOnePairWithFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsOnePairWithFullHouse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test IsHighCard

        [TestMethod]
        public void TestIsHighCard()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.King,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        //TEST WITH EVEYITHING ELSE

        [TestMethod]
        public void TestIsHighCardWithStraightFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Hearts),
                new Card(CardFace.Eight,CardSuit.Hearts),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardWithFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardWithFullHouser()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardWithFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Spades),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Spades)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardWithStraight()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five,CardSuit.Spades),
                new Card(CardFace.Six,CardSuit.Hearts),
                new Card(CardFace.Seven,CardSuit.Clubs),
                new Card(CardFace.Eight,CardSuit.Diamonds),
                new Card(CardFace.Nine,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardWithThreeOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardTwoPair()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHighCardWithOnePair()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);
            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test CompareHands

        [TestMethod]
        public void TestCompareHandsFirsBiggerThanSecond()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);

            IList<ICard> cards2 = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            IHand hand2 = new Hand(cards2);
            int expected = 1; 
            PokerHandsChecker checker = new PokerHandsChecker();
            int actual = checker.CompareHands(hand, hand2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareHandsFirsSmallerThanSecond()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);

            IList<ICard> cards2 = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            IHand hand2 = new Hand(cards2);
            int expected = -1; 
            PokerHandsChecker checker = new PokerHandsChecker();
            int actual = checker.CompareHands(hand,hand2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareHandsWithTwoEqualHands()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack,CardSuit.Spades),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Seven,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            IHand hand = new Hand(cards);
            IHand hand2 = new Hand(cards);
            int expected = 0;
            PokerHandsChecker checker = new PokerHandsChecker();
            int actual = checker.CompareHands(hand, hand2);
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
