namespace Schach.Core;

public class Rook : Figure
{
   public Rook((int, int) position, ColorEnum color)
   {
      _position = position;
      _name = "Rook";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "pictures/white_rook.png" : "pictures/black_rook.png";
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
