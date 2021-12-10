using System;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using SOLID.Core.Models;

namespace SOLID.Core.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ItPopulatesADeckOfCards()
    {
        
        var card = new Card();
        var cards = card.Cards;
        
        Console.WriteLine($"Cards length is {cards.Count}");
        Console.WriteLine(cards);
        
        Assert.AreEqual(cards, new int[5]);
    }
}