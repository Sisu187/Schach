namespace Schach.Core;

public class Queen : Figure
{
   public Queen((int, int) position, ColorEnum color)
   {
      _position = position;
      _name = "Queen";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "pictures/white_queen.png" : "pictures/black_queen.png";
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
