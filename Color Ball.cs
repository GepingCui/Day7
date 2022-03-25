using System;

namespace _ColorBall
{


    public class Color
    {
        public int RED { set; get; }
        public int GREEN { set; get; }
        public int BLUE { set; get; }
        public int ALPHA { set; get; }

        public Color(int red, int green, int blue, int alpha)
        {
            this.RED = red;
            this.GREEN = green;
            this.BLUE = blue;
            this.ALPHA = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.RED = red;
            this.GREEN = green;
            this.BLUE = blue;
            this.ALPHA = 255;
        }
        public int GrayScale()
        {
            return (this.RED + this.GREEN + this.BLUE) / 3;
        }

    }

    public class Ball
    {  
        
        public Color Color { set; get; }
        public int Size;
        public int ThrownTime;

        public Ball(int size,Color color)
        {
            this.Size=size;
            this.Color=color;
            this.ThrownTime=0;
        }

        public void Pop()
        {
            this.Size=0;
        }

        public void Throw()
        {
            if (this.Size > 0)
            {
                this.ThrownTime++;
            }
        }

        public int ThrownNumber()
        {
            return this.ThrownTime;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Color CL1 = new Color(15,30,45,60);
            Ball Ball1 = new Ball(15,CL1);

            Ball1.Throw();
            Console.WriteLine(Ball1.ThrownNumber());
            Ball1.Throw();
            Ball1.Throw();
            Ball1.Throw();
            Ball1.Throw();
            Ball1.Throw();
            Ball1.Throw();
            Console.WriteLine(Ball1.ThrownNumber());
            Ball1.Pop();
            Console.WriteLine(Ball1.ThrownNumber());
            Ball1.Throw();
            Console.WriteLine(Ball1.ThrownNumber());
        }
    }

}