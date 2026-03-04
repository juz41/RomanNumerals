using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests;

[TestClass]
[TestSubject(typeof(RomanNumeral))]
public class RomanNumeralTest
{

    [TestMethod]
    public void OneSymbolTest()
    {
        Assert.AreEqual("I", (new RomanNumeral(1)).Representation);
        Assert.AreEqual("V", (new RomanNumeral(5)).Representation);
        Assert.AreEqual("X", (new RomanNumeral(10)).Representation);
        Assert.AreEqual("L", (new RomanNumeral(50)).Representation);
        Assert.AreEqual("C", (new RomanNumeral(100)).Representation);
        Assert.AreEqual("D", (new RomanNumeral(500)).Representation);
        Assert.AreEqual("M", (new RomanNumeral(1000)).Representation);
    }
    
    [TestMethod]
    public void AdditionTest()
    {
        Assert.AreEqual("III", (new RomanNumeral(3)).Representation);
        Assert.AreEqual("VIII", (new RomanNumeral(8)).Representation);
        Assert.AreEqual("XII", (new RomanNumeral(12)).Representation);
        Assert.AreEqual("LVI", (new RomanNumeral(56)).Representation);
        Assert.AreEqual("CII", (new RomanNumeral(102)).Representation);
        Assert.AreEqual("DXXII", (new RomanNumeral(522)).Representation);
        Assert.AreEqual("MDCLXII", (new RomanNumeral(1662)).Representation);
    }
    
    [TestMethod]
    public void SubtractionTest()
    {
        Assert.AreEqual("IV", (new RomanNumeral(4)).Representation);
        Assert.AreEqual("IX", (new RomanNumeral(9)).Representation);
        Assert.AreEqual("XL", (new RomanNumeral(40)).Representation);
        Assert.AreEqual("XC", (new RomanNumeral(90)).Representation);
        Assert.AreEqual("CD", (new RomanNumeral(400)).Representation);
        Assert.AreEqual("CM", (new RomanNumeral(900)).Representation);
    }

    [TestMethod]
    public void MixedTest()
    {
        Assert.AreEqual("XIV", (new RomanNumeral(14)).Representation);
        Assert.AreEqual("XIX", (new RomanNumeral(19)).Representation);
        Assert.AreEqual("XLIV", (new RomanNumeral(44)).Representation);
        Assert.AreEqual("XCIX", (new RomanNumeral(99)).Representation);
        Assert.AreEqual("CDXLIV", (new RomanNumeral(444)).Representation);
        Assert.AreEqual("MCMXCIV", (new RomanNumeral(1994)).Representation);
    }
    
    [TestMethod]
    public void ZeroShouldThrow()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new RomanNumeral(0));
    }

    [TestMethod]
    public void NegativeShouldThrow()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new RomanNumeral(-5));
    }

    [TestMethod]
    public void TooLargeShouldThrow()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new RomanNumeral(4000));
    }
}