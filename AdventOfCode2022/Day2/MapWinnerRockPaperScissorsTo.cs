namespace AdventOfCode2022.Day2;

public static class MapWinnerRockPaperScissorsTo
{
    public static RockScissorsPaperEnum MapOpponentRockPaperScissorsTo(this WinnerRockPaperScissors winner)
    {
        switch (winner)
        {
            case WinnerRockPaperScissors.X:
                return RockScissorsPaperEnum.Rock;
            case WinnerRockPaperScissors.Y:
                return RockScissorsPaperEnum.Paper;
            case WinnerRockPaperScissors.Z:
                return RockScissorsPaperEnum.Scissors;
        }
        return 0;
    }
}