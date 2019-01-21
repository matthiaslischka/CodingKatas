using System;

namespace MonteCarloPi
{
    public class MonteCarloPi
    {
        public decimal CalculatePi(int numberOfAttempts)
        {
            var pointsInCircle = 0;

            for (var i = 0; i < numberOfAttempts; i++)
            {
                var isPointInCircle = IsPointInCircle(GetRandomPoint());
                if (isPointInCircle)
                {
                    pointsInCircle++;
                }
            }

            var probabilityRandomPointInCircle = (decimal)pointsInCircle / numberOfAttempts;
            var pi = 4 * probabilityRandomPointInCircle;

            return pi;
        }

        public bool IsPointInCircle(Point point)
        {
            return point.X * point.X + point.Y * point.Y <= 1;
        }

        public Point GetRandomPoint()
        {
            var random = new Random();
            decimal x = (decimal)random.Next(-100, 100) / 100;
            decimal y = (decimal)random.Next(-100, 100) / 100;

            return new Point { X = x, Y = y };
        }

        public class Point
        {
            public decimal X { get; set; }
            public decimal Y { get; set; }
        }
    }
}