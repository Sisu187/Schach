using System.ComponentModel.DataAnnotations;

namespace Schach.Core;

public abstract class Figure
{
   protected (int, int) _position;

   protected string _name;

   protected string _picturePath;

   public enum ColorEnum
   {
      White,
      Black
   }

   protected ColorEnum _color;

   public abstract void Move();

   public abstract void Take();

   public abstract void Display();

}
