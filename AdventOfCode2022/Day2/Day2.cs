namespace AdventOfCode2022.Day2;

public class Day2 : AdventOfCodeDay
{
    public int GetPart1(List<string> inputValues)
    {
        var total = 0;
        foreach (var inputValue in inputValues)
        {
            var items = inputValue.Split(" ");
            var opponent = Enum.Parse<OpponentRockPaperSissors>(items[0]);
            var winner = Enum.Parse<WinnerRockPaperScissors>(items[1]);
            var rowScore = GetScoreForRow(opponent, winner);
            total += rowScore;
        }

        return total;
    }
    
    public int GetPart2(List<string> inputValues)
    {
        var total = 0;
        foreach (var inputValue in inputValues)
        {
            var items = inputValue.Split(" ");
            var opponent = Enum.Parse<OpponentRockPaperSissors>(items[0]);
            var winner = Enum.Parse<WinnerRockPaperScissors>(items[1]);
            var rowScore = GetScoreForRowWithStrategyGuide(opponent, winner);
            total += (int) rowScore + (int) winner;
        }

        return total;
    }

    private int GetScoreForRow(OpponentRockPaperSissors opponent, WinnerRockPaperScissors winner)
    {
        var opponentStandard = opponent.MapOpponentRockPaperScissorsTo();
        var winnerStandard = winner.MapWinnerRockPaperScissorsTo();
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

    private RockScissorsPaperEnum GetScoreForRowWithStrategyGuide(OpponentRockPaperSissors opponent,
        WinnerRockPaperScissors winner)
    {
        var opponentStandard = opponent.MapOpponentRockPaperScissorsTo();

        RockScissorsPaperEnum selectedItem = (RockScissorsPaperEnum)0;
        switch (winner)
        {
            case WinnerRockPaperScissors.X:
            {
                var losingItem = GetRockPaperScissorsEnumBasedOnOpponent(opponentStandard, WinLoseGameEnum.Lose);
                selectedItem = losingItem;
                break;
            }
            case WinnerRockPaperScissors.Y:
                selectedItem = opponentStandard;
                break;
            case WinnerRockPaperScissors.Z:
            {
                var winnerItem = GetRockPaperScissorsEnumBasedOnOpponent(opponentStandard, WinLoseGameEnum.Win);
                selectedItem = winnerItem;
                break;
            }
        }

        return selectedItem;
    }

    private RockScissorsPaperEnum GetRockPaperScissorsEnumBasedOnOpponent(RockScissorsPaperEnum opponent, WinLoseGameEnum winLoseGameEnum)
    {
        var allItems = Enum.GetValues(typeof(RockScissorsPaperEnum));
        foreach (var selectItem in allItems)
        {
            var score = GetScoreOfPerson2(opponent, (RockScissorsPaperEnum)selectItem);
            if (score == winLoseGameEnum)
            {
                return (RockScissorsPaperEnum)selectItem;
            }
        }

        return RockScissorsPaperEnum.Paper;
    }
}

