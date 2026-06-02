namespace Schach.Core;

public abstract class Figure
{
   protected (int, int) _position;

   protected string _name;

   protected string _picturePath;

   public abstract void Move();

   public abstract void Take();

}
