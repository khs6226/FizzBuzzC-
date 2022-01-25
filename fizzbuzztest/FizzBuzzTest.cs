using System;
using fizzbuzzlibrary;
using Xunit;

namespace fizzbuzztest;

public class FizzBuzzTest
{
  [Fact]
  public void Given2Result12()
  {
    FizzBuzz fb = new FizzBuzz();
    string expected = "1 2 ";
    string actual = fb.GetResult(2);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given4Result12Fizz4()
  {
    FizzBuzz fb = new FizzBuzz();
    string expected = "1 2 fizz 4 ";
    string actual = fb.GetResult(4);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given5Result12Fizz4Buzz()
  {
    FizzBuzz fb = new FizzBuzz();
    string expected = "1 2 fizz 4 buzz ";
    string actual = fb.GetResult(5);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given15Result12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz()
  {
    FizzBuzz fb = new FizzBuzz();
    string expected = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz ";
    string actual = fb.GetResult(15);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void GivenMorethan100ThrowException()
  {
    FizzBuzz fb = new FizzBuzz();
    Action act = () => fb.GetResult(101);
    Assert.Throws<Exception>(act);
  }

  [Fact]
  public void GivenNegativeNumberThrowException()
  {
    FizzBuzz fb = new FizzBuzz();
    Action act = () => fb.GetResult(-1);
    Assert.Throws<Exception>(act);
  }
}