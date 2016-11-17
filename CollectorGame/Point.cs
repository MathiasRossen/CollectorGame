namespace CollectorGame
{
    public class Point
    {
        int x, y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value < 0)
                    x = 0;
                else
                    x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 0)
                    y = 0;
                else
                    y = value;
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (ToString() == obj.ToString())
                return true;

            return false;
        }

        public override string ToString()
        {
            return "x" + x + "y" + y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
