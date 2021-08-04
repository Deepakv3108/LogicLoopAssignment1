using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogicLoopAssignment1.ChessBoard
{
    public class ChessBoard
    {
        public void generateChessBoard()
        {
            StringBuilder sb = new StringBuilder("<html><head><title>Chessboard</title>");
            sb.Append("<style type='text/css'>");
            sb.Append(".chessboard{width: 240px;border: 15px solid grey}");
            sb.Append(".black{width: 30px; height: 30px; background-color: black; display: inline-block;}");
            sb.Append(".white{width: 30px; height: 30px; background-color: white; display: inline-block;}");
            sb.Append("</style></head><body>");
            sb.Append("<div class='chessboard'>");
            for(int y = 1; y<=8; y++)
            {
                sb.Append("<div>");
                for(int x=1; x<=8; x++)
                {
                    if((x+y)  % 2 == 0)
                        sb.Append("<div class='white'></div>");
                    else
                        sb.Append("<div class='black'></div>");
                }
                sb.Append("</div>");
            }
            sb.Append("</div></body></html>");
            string filePath = Environment.CurrentDirectory + @"\ChessBoard.html";
            File.WriteAllText(filePath, sb.ToString());
            Console.WriteLine("Chessboard.html file Created at '{0}'", filePath);

        }
    }
}
