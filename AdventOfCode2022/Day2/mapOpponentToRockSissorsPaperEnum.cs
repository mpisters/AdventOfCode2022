namespace AdventOfCode2022.Day2;

public static class mapOpponentToRockSissorsPaperEnum
{
    public static RockScissorsPaperEnum MapWinnerRockPaperScissorsTo(this OpponentRockPaperSissors opponentRockPaperSissors)
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