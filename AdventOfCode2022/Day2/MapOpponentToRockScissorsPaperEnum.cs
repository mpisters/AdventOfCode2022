namespace AdventOfCode2022.Day2;

public static class MapOpponentToRockScissorsPaperEnum
{
    public static RockScissorsPaperEnum MapOpponentRockPaperScissorsTo(this OpponentRockPaperSissors opponentRockPaperSissors)
    {
        switch (opponentRockPaperSissors)
        {
            case OpponentRockPaperSissors.A:
                return RockScissorsPaperEnum.Rock;
            case OpponentRockPaperSissors.B:
                return RockScissorsPaperEnum.Paper;
            case OpponentRockPaperSissors.C:
                return RockScissorsPaperEnum.Scissors;
        }
        return 0;
    }
}