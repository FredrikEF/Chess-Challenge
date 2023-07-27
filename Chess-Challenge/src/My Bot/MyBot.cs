﻿//namespace System;
//using ChessChallenge.API;
//using Linq;

//public class MyBot : IChessBot
//{
//    private static Random random = new(20108638);

//    public double[] Wheights = new[] { -0.7656628209006334, -0.14090474282433496, 0.5668097294712484, 0.17726331817790086, 0.8424124838050513, 0.472705255017013, 0.3280062979683309, 0.22647429594140234, 0.16851812562370583, 0.7534386700733744, -0.4172329918561657, -0.1773595163493229, 0.6408956682499944, 0.9949516626051402, -0.47429964760052956, 0.1395409699247876, -0.7686928882117816, 0.9655863428328122, 0.7310201738639828, 0.27560944728348846, -0.8451261501038103, 0.24735794740140338, 0.9860091051021633, -0.5119243895224874, -0.8342443517568727, -0.6610505374432777, -0.5974976781744034, 0.3864036050561832, -0.20129852145970728, -0.9875233424769357, 0.12411521148128202, -0.6863478644221779, -0.7116991913466245, -0.6876711471414525, 0.7656104330744642, 0.8637269445991735, 0.697641174168159, -0.5477259548137551, 0.46220702094128674, -0.8705147709094523, 0.9375913394324442, 0.4144634769365487, 0.8122272220497146, -0.33192878371660073, 0.885569676703573, 0.3808652606703644, -0.59721622038503, -0.7673083216731009, 0.3898852818598437, 0.5884396525046041, -0.7145166190874375, 0.9247601199544782, 0.19842018801645378, 0.02584101773139147, 0.640782520939029, 0.6895805847316889, 0.1313462672435428, 0.9511770531307799, -0.13672058709744395, 0.11952195182420411, -0.9449439821508452, -0.8452750322619802, 0.6674792383180368, -0.24258787894741995, -0.9868021169615919, -0.31008866490334674, -0.7491045993515777, -0.3399986249115312, 0.4557234660981797, 0.9556438838856498, 0.37078532733525393, 0.774968520633396, 0.6544003047302367, 0.11688997555379288, -0.04997092999982222, 0.29299233168968564, 0.14376758557919755, 0.31793788881876406, -0.5168300399169465, 0.24109051806902992, 0.23172546049194676, -0.634819526055278, -0.8743697059687086, 0.9280253341086326, -0.22969641128075147, 0.24247101659070291, -0.19317316971401366, -0.3099433562298973, -0.2371016346090946, 0.13136335049353698, 0.3112252817075818, 0.9640155052598638, 0.7773440274304451, 0.835544590761673, -0.6487003581825179, 0.3123583529667735, -0.2478167420475822, 0.8689944668994258, 0.7972087281743105, 0.9887720914505291, 0.2569700829950021, 0.48708938876497054, 0.6159261118694797, -0.6301733533060985, -0.6543166347100943, -0.8222930737874904, -0.06082235232965194, 0.9439704408608238, -0.9241880522687864, -0.3423728753544264, -0.32011756083002196, -0.20553524382670185, -0.6770270465300544, 0.3281824082733049, -0.4380691812550971, 0.0239737932681916, 0.7120003345012667, 0.603284210713247, -0.0600287872646138, 0.37943994131844483, -0.36349260032339603, 0.21313841511175902, 0.6943580143593056, -0.03530465114643078, -0.06067221102336062, -0.19176217317197575, 0.6169089924622835, -0.9909245623233377, -0.49516158527469334, 0.1087198886595293, -0.20603326764238683, 0.12776564486686404, 0.09338796934736338, -0.26155640429889615, -0.6474703707021989, 0.3387819301983257, -0.699171794438349, -0.3395798734107892, 0.017975556206877963, 0.699681516596899, -0.8709933040062866, 0.2669958198755029, 0.5541175145442214, -0.047639133896510644, -0.2445128398223374, -0.25791376142665456, 0.5497722567756531, -0.48331568086674237, 0.2736137720167702, -0.8122943424676985, 0.7505425073907444, -0.17018380908769737, 0.7868791268146034, 0.320547971558081, 0.9776880629256777, 0.5309727627462582, 0.48316001216096804, -0.06689725959063375, 0.7250596283586042, -0.17834583724771902, -0.12571843207148758, -0.33894131767514224, 0.1482052743193718, 0.6295369442689871, 0.15997985711320295, 0.7563498689589789, 0.7010767868259349, -0.4233805376213885, -0.4233536838662595, -0.4063854307897321, -0.42925156719482116, -0.02245883225577827, -0.5746796483056059, -0.3028959125759527, 0.8165118106717764, 0.32921965575275003, 0.06684842382876588, 0.2943216586924724, 0.7556824645752471, -0.01769438247089017, 0.5353507369455652, 0.5033588015955681, -0.5943748101565869, 0.8406748715046211, -0.6728428693827442, 0.5738922225189824, 0.16939391343360488, 0.7245525353236835, 0.9513959279057551, 0.14096704457931541, 0.009721036539283023, -0.7161052104626341, 0.0997811682055616, -0.8036786065454029, -0.11409962508552696, -0.3607683141533138, -0.6089513775002916, -0.6795320267228093, 0.8014742069884548, -0.19943777900162984, -0.11165996320157312, 0.6484681505935583, -0.3901074525854119, -0.36817483853929434, 0.7330280466624666, -0.22699866035347738, -0.8358577824364686, 0.7870009242496459, -0.8640746240802457, -0.9374031368351556, 0.4438053515943723, 0.5854040289229732, 0.177420275834119, -0.24203590268363984, 0.6801195711270531, -0.6140761178052407, 0.7797274430188013, -0.08562315771618079, 0.3931698759054625, -0.48422705358091134, -0.5888515755482258, 0.45368015647571536, 0.26073941926506317, 0.02520720708426416, 0.5050240072910785, 0.6235438173746428, -0.003239744810033418, -0.29624619022768284, -0.8338726897881705, 0.9623043816361132, 0.42145921169848144, -0.5018111884136736, 0.5019406497021861, -0.9311270899749953, -0.36714461323206526, -0.6713566340838357, -0.6384232657209148, 0.4302878535493686, -0.8130186711498624, 0.3439989897161717, 0.16939638330107387, 0.2728961805221142, -0.5741654800130824, -0.6670177325918422, 0.1803972009478123, 0.5031865329962162, 0.7415624958190892, -0.5171155880750695, 0.9954480063148998, -0.5995199231428653, -0.7069731250903444, 0.9045278811382724, 0.615140571079748, -0.8873257925209244, -0.5539992319205772, 0.7190677997279296 };

//    public MyBot InitializeRandom()
//    {
//        foreach(var i in Enumerable.Range(0,16*16))
//        {
//            if(random.NextDouble() < 0.2)
//                Wheights[i] = random.NextDouble() * 2.0 - 1.0;
//        }

//        return this;
//    }

//    public void FromParents(MyBot a, MyBot b)
//    {
//        for (int i = 0; i < 16*16; i++)
//        {
//            Wheights[i] = random.NextDouble() < 0.5 
//                ? a.Wheights[i] 
//                : b.Wheights[i];

//            if (random.NextDouble() < 0.05)
//            {
//                Wheights[i] = random.NextDouble() * 2.0 - 1.0;
//            }
//        }
//    }

//    public Move Think(Board board, Timer timer)
//        => board.GetLegalMoves()
//            .OrderByDescending(m => X(m, m.CapturePieceType, m.MovePieceType)).First();

//    //private double Order(Move m)
//    //{
//    //    var ct = m.CapturePieceType;
//    //    var mt = m.MovePieceType;
//    //    var w = new[] {
//    //        ct == PieceType.Pawn,   // 0
//    //        ct == PieceType.Knight, // 1
//    //        ct == PieceType.Bishop, // 2
//    //        ct == PieceType.Rook,   // 3
//    //        ct == PieceType.Queen,  // 4
//    //        ct == PieceType.Knight, // 5
//    //        m.IsCapture,            // 6
//    //        m.IsPromotion,          // 7
//    //        m.IsCastles,            // 8
//    //        m.IsEnPassant,          // 9
//    //        m.IsNull,               // 10
//    //        mt == PieceType.Pawn,   // 11
//    //        mt == PieceType.Knight, // 12
//    //        mt == PieceType.Bishop, // 13
//    //        mt == PieceType.Rook,   // 14
//    //        mt == PieceType.Queen,  // 15
//    //        mt == PieceType.Knight  // 16
//    //    };
//    //    var x = Enumerable.Range(0, 16)
//    //        .SelectMany(row => Wheights[(row * 16)..(row * 16 + 16)].Zip(w).Select(a => a.First * (a.Second ? 1 : 0)))
//    //        .Sum();
//    //    return x;
//    //}

//    double X(Move m, PieceType ct, PieceType mt)
//        => Enumerable.Range(0, 16)
//            .SelectMany(row => Wheights[(row * 16)..(row * 16 + 16)].Zip(new[] {
//            ct == PieceType.Pawn,   // 0
//            ct == PieceType.Knight, // 1
//            ct == PieceType.Bishop, // 2
//            ct == PieceType.Rook,   // 3
//            ct == PieceType.Queen,  // 4
//            ct == PieceType.Knight, // 5
//            m.IsCapture,            // 6
//            m.IsPromotion,          // 7
//            m.IsCastles,            // 8
//            m.IsEnPassant,          // 9
//            m.IsNull,               // 10
//            mt == PieceType.Pawn,   // 11
//            mt == PieceType.Knight, // 12
//            mt == PieceType.Bishop, // 13
//            mt == PieceType.Rook,   // 14
//            mt == PieceType.Queen,  // 15
//            mt == PieceType.Knight  // 16
//        }).Select(a => a.First * (a.Second ? 1 : 0)))
//            .Sum();
//}

namespace System;
using ChessChallenge.API;
using Linq;
using System.Collections.Generic;

public class MyBot : IChessBot
{
    ulong[] PieceEvaluationTable = new[]
    {
        //Pawn
        0x00_00_00_00_00_00_00_00UL,
        0x32_32_32_32_32_32_32_32UL,
        0x0A_0A_14_1E_1E_14_0A_0AUL,
        0x05_05_0A_19_19_0A_05_05UL,
        0x00_00_00_14_14_00_00_00UL,
        0x05_FB_F6_00_00_F6_FB_05UL,
        0x05_0A_0A_EC_EC_0A_0A_05UL,
        0x00_00_00_00_00_00_00_00UL,

        //Knight
        0xCE_D8_E2_E2_E2_E2_D8_CEUL,
        0xD8_EC_00_00_00_00_EC_D8UL,
        0xE2_00_0A_0F_0F_0A_00_E2UL,
        0xE2_05_0F_14_14_0F_05_E2UL,
        0xE2_00_0F_14_14_0F_00_E2UL,
        0xE2_05_0A_0F_0F_0A_05_E2UL,
        0xD8_EC_00_05_05_00_EC_D8UL,
        0xCE_D8_E2_E2_E2_E2_D8_CEUL,

        //Bishop
        0xEC_F6_F6_F6_F6_F6_F6_ECUL,
        0xF6_00_00_00_00_00_00_F6UL,
        0xF6_00_05_0A_0A_05_00_F6UL,
        0xF6_05_05_0A_0A_05_05_F6UL,
        0xF6_00_0A_0A_0A_0A_00_F6UL,
        0xF6_0A_0A_0A_0A_0A_0A_F6UL,
        0xF6_05_00_00_00_00_05_F6UL,
        0xEC_F6_F6_F6_F6_F6_F6_ECUL,

        //Rook
        0x00_00_00_00_00_00_00_00UL,
        0x05_0A_0A_0A_0A_0A_0A_05UL,
        0xFB_00_00_00_00_00_00_FBUL,
        0xFB_00_00_00_00_00_00_FBUL,
        0xFB_00_00_00_00_00_00_FBUL,
        0xFB_00_00_00_00_00_00_FBUL,
        0xFB_00_00_00_00_00_00_FBUL,
        0x00_00_00_05_05_00_00_00UL,

        //Queen
        0xEC_F6_F6_FB_FB_F6_F6_ECUL,
        0xF6_00_00_00_00_00_00_F6UL,
        0xF6_00_05_05_05_05_00_F6UL,
        0xFB_00_05_05_05_05_00_FBUL,
        0x00_00_05_05_05_05_00_FBUL,
        0xF6_05_05_05_05_05_00_F6UL,
        0xF6_00_05_00_00_00_00_F6UL,
        0xEC_F6_F6_FB_FB_F6_F6_ECUL,

        //King
        0xE2_D8_D8_CE_CE_D8_D8_E2UL,
        0xE2_D8_D8_CE_CE_D8_D8_E2UL,
        0xE2_D8_D8_CE_CE_D8_D8_E2UL,
        0xE2_D8_D8_CE_CE_D8_D8_E2UL,
        0xEC_E2_E2_D8_D8_E2_E2_ECUL,
        0xF6_EC_EC_EC_EC_EC_EC_F6UL,
        0x14_14_00_00_00_00_14_14UL,
        0x14_1E_0A_00_00_0A_1E_14UL
    };

    

    //                      Null, Pawn, Knight, Bishop, Rook, Queen, King
    int[] scoring = new[] { 0,    10,   30,     30,     50,   90,    2000};
    int multiplier;
    Board board;

    int counter;


    HashSet<Move> repeats;
    int repeatCounter = 0;
    public Move Think(Board board_, Timer timer)
    {
        counter = 0;
        board = board_;
        multiplier = board.IsWhiteToMove ? 1 : -1;

        int best = int.MinValue;
        Move move = new();
        foreach(var moveToCheck in board.GetLegalMoves())
        {
            repeats = new HashSet<Move>();
            repeatCounter = 0;
            var score = Best(moveToCheck, 3, best);
            if (score > best)
            {
                best = score;
                move = moveToCheck;
            }
        }
        //int best = int.MinValue;
        //var (score, move) = board.GetLegalMoves()
        //    .Select(x => (Best(x, 3, best), x))
        //    .MaxBy(x => x.Item1);

        Console.WriteLine($"best {move}: {best} ({counter} moves tested)");
        return move;
    }

    //If white is playing

    int Best(Move move, int recurse, int best)
    {
        counter++;
        Move[] moves;
        if (!repeats.Add(move))
        {
            repeatCounter++;
        }
        if (repeatCounter >= 1)
        {
            Console.WriteLine($"Repeat! {recurse}");
            return int.MinValue;
        }
        
        board.MakeMove(move);
        // compute the score based on pieces left
        // White pieces defaults to positives scores, and black negatives
        // We then need to multiply by -1 if we're playing black(so that the scores become correct
        int score = board
            .GetAllPieceLists()
            .Sum(piece
                => piece
                    .Sum(x =>
                    {
                        int index = 8 * (int)(x.PieceType - 1) +
                                     7 * (x.IsWhite ? 1 : 0) + x.Square.Rank * (x.IsWhite ? -1 : 1);

                        int bitshift = (7 - x.Square.File) * 8;

                        return 
                        (
                            // The local score of the piece
                            scoring[(int)x.PieceType] +
                            // The score based on its position
                            (sbyte)(PieceEvaluationTable[index] >> bitshift) & 0xff
                        
                        //Negate score if it's a black piece
                        ) * (x.IsWhite ? 1 : -1);

                        //negate the entire score if we're playing black.
                    }) * multiplier);
    
        //Search deeper if our current score is equal or better than the previous one, and there are more legal moves, and we can recurse further
        if (score > best && recurse > 0 && (moves = board.GetLegalMoves())?.Length > 0)
            score = Math.Min(score, moves.Min(x => Best(x, recurse-1, score)));
        board.UndoMove(move);
        repeats.Remove(move);
        return score;
    }
}