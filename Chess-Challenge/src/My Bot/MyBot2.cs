namespace System;
using ChessChallenge.API;
using Linq;

public class MyBot2 : IChessBot
{

    int[] scoring = new[] { 0, 10, 20, 20, 30, 40, 50, 100, 1000 };
    int multiplier;
    Board board;
    int sd = 10;
    public Move Think(Board board_, Timer timer)
    {
        multiplier = board.IsWhiteToMove ? 1 : -1;
        board = board_;
        return board.GetLegalMoves()
            .Select(x=> (Best(x),x))
            .MaxBy(x=>x.Item1).x;
    }

    //If white is playing

    int Best(Move move)
    {
        board.MakeMove(move);
        // compute the score based on pieces left
        // White pieces defaults to positives scores, and black negatives
        // We then need to multiply by -1 if we're playing black(so that the scores become correct
        int score = board.GetAllPieceLists().Sum(piece => piece.Sum(x => scoring[(int)x.PieceType]*multiplier*(x.IsWhite?1:-1)));
        if (sd == 0) return score;
        sd--;
        int min = Math.Min(score, board.GetLegalMoves().Min(Best));
        sd++;
        board.UndoMove(move);
        return min;
    }
}