
namespace RefactorVolumeOfPiramid
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Length: ");
            double Lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
            
            var Volume = (Lenght * Width * Height) / 3;
            Console.WriteLine("Pyramid Volume: {0:f2}", Volume);
        }
    }
}