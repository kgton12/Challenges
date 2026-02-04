using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReturnTheDayTest
{
    [Test]
    [TestCase(1, "Sunday")]
    [TestCase(2, "Monday")]
    [TestCase(3, "Tuesday")]
    [TestCase(4, "Wednesday")]
    [TestCase(5, "Thursday")]
    [TestCase(6, "Friday")]
    [TestCase(7, "Saturday")]
    [TestCase(-1, "Wrong, please enter a number between 1 and 7")]
    [TestCase(0, "Wrong, please enter a number between 1 and 7")]
    [TestCase(8, "Wrong, please enter a number between 1 and 7")]
    [TestCase(20, "Wrong, please enter a number between 1 and 7")]
    public void FixedTest(int n, string expected)
    {
        Assert.That(ReturnTheDay.WhatDay(n), Is.EqualTo(expected));
    }
}
