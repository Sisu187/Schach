namespace Schach.Core;

public class Pawn : Figure
{
   public Pawn((int, int) position, ColorEnum color)
   {
      _position = position;
      _name = "Pawn";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "pictures/white_pawn.png" : "pictures/black_pawn.png";
   }

   public override void Move()
   {
      
   }

   public override void Take()
   {
      
   }

   public override void Display()
   {
      
   }

}
