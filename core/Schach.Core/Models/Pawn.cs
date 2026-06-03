namespace Schach.Core;

public class Pawn : Figure
{
   public Pawn((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "Pawn";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_pawn.png" : "Assets/pictures/black_pawn.png";
   }

   public override void Move()
   {
      
   }

   public override void Take()
   {
      
   }

   public override void OnClick_ShowAvailableMoves()
   {
      throw new NotImplementedException();
   }

   public override List<(int row, int col)> GetAvailableMoves(Board board)
   {
      throw new NotImplementedException();
   }
}
