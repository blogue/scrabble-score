using Xunit;

namespace ScrabbleScore
{
  public class ScrabbleTests
  {
    [Fact]
    public void calculateScore_A_1()
    {
      ScoreCalculator sc = new ScoreCalculator();
      Assert.Equal(1, sc.calculateScore("A"));
    }
    [Fact]
    public void calculateScore_LUNAR_5()
    {
      ScoreCalculator sc = new ScoreCalculator();
      Assert.Equal(5, sc.calculateScore("LUNAR"));
    }
    [Fact]
    public void calculateScore_QJKFBDA_33()
    {
      ScoreCalculator sc = new ScoreCalculator();
      Assert.Equal(33, sc.calculateScore("QJKFBDA"));
    }
  }
}
