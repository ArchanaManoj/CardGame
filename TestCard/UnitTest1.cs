//Test Project submitted by Archana Manoj, archana.manoj @gmail.com, dated 08/25/2017
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCard
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShuffle()
        {
            //arrange
            List<CardGame.Card> testdeck1 = new List<CardGame.Card>();
            List<CardGame.Card> testdeck2 = new List<CardGame.Card>();
            CardGame.Deck trial = new CardGame.Deck();
            testdeck1 = trial.GetPack();
            //act
            testdeck2 = trial.ShufflePack(trial.GetPack());
            //assert
            Assert.AreNotEqual(testdeck1, testdeck2);
        }

        [TestMethod]
        public void TestSort()
        {
            //arrange
            List<CardGame.Card> testdeck1 = new List<CardGame.Card>();
            List<CardGame.Card> testdeck2 = new List<CardGame.Card>();
            CardGame.Deck trial = new CardGame.Deck();
            testdeck1 = trial.GetPack();
            //act
            testdeck2 = trial.SortPack(trial.GetPack());
            //assert
            for(int i = 0; i<testdeck1.Count;i++)
            {
                Assert.AreEqual(testdeck1[i].CardSuit, testdeck2[i].CardSuit);
                Assert.AreEqual(testdeck1[i].CardValue, testdeck2[i].CardValue);
            }
           
        }
    }
}
