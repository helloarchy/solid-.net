using System;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using SOLID.Core.Models;
using SOLID.Core.Tests.Fixtures;

namespace SOLID.Core.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(typeof(DeckOfCards))]
    public void ItPopulatesADeckOfCards((char, int)[] expectedCards)
    {
        var card = new Card();
        var cards = card.Cards;
        
        Assert.That(cards, Is.EqualTo(expectedCards));
    }
}