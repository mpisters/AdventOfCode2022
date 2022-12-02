namespace AdventOfCode2022.Day2;

public class Day2
{
    public int GetDay2Part1(List<string> inputValues)
    {
        var total = 0;
        foreach (var inputValue in inputValues)
        {
            var items = inputValue.Split(" ");
            var opponent = Enum.Parse<OpponentRockPaperSissors>(items[0]);
            var winner = Enum.Parse<WinnerRockPaperScissors>(items[1]);
            var rowScore = getScoreForRow(opponent, winner);
            total += rowScore;
        }

        return total;
    }

    private int getScoreForRow(OpponentRockPaperSissors opponent, WinnerRockPaperScissors winner)
    {
        var opponentStandard = opponent.MapWinnerRockPaperScissorsTo();
        var winnerStandard = winner.MapOpponentRockPaperScissorsTo();
        var scorePerson2 = GetScoreOfPerson2(opponentStandard, winnerStandard);
        return (int)winnerStandard + (int)scorePerson2;
    }

    private WinLoseGameEnum GetScoreOfPerson2(RockScissorsPaperEnum person1, RockScissorsPaperEnum person2)
    {
     
        switch (person1)
        {
            case RockScissorsPaperEnum.Rock:
                switch (person2)
                {
                    case RockScissorsPaperEnum.Rock:
                        return WinLoseGameEnum.Tie;
                    case RockScissorsPaperEnum.Paper:
                        return WinLoseGameEnum.Win;
                    case RockScissorsPaperEnum.Scissors:
                        return WinLoseGameEnum.Lose;
                }

                break;
            case RockScissorsPaperEnum.Paper:
                switch (person2)
                {
                    case RockScissorsPaperEnum.Rock:
                        return WinLoseGameEnum.Lose;
                    case RockScissorsPaperEnum.Paper:
                        return WinLoseGameEnum.Tie;
                    case RockScissorsPaperEnum.Scissors:
                        return WinLoseGameEnum.Win;
                }

                break;
            case RockScissorsPaperEnum.Scissors:
                switch (person2)
                {
                    case RockScissorsPaperEnum.Rock:
                        return WinLoseGameEnum.Win;
                    case RockScissorsPaperEnum.Paper:
                        return WinLoseGameEnum.Lose;
                    case RockScissorsPaperEnum.Scissors:
                        return WinLoseGameEnum.Tie;
                }

                break;
        }

        return 0;
    }
    
  
    
    
    
    
    
    
}