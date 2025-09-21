namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = (Math.Abs(d) >= 1);                
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            answer = (((d + f) / 2) > 0);
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = ((a+b) > (((Math.Abs(a) + Math.Abs(b))/2)));
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int[] n = { a, b, c };
            answer = n.Max();
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) <= 1)
                answer = (x*x - 1);
            // end
            
            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y <= (1+x) && y >= 0 && y <= (1-x))
                answer = true;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
                answer = false;
            else if (n % 2 == 0)
                answer = false;
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int day = X;
            if (X % 2 != 0)
            {
                day = (X / 2) + 1;
            }
            else
            {
                day = X / 2;
            }
            int up = day * Y;
            if ((up >= 240) && (up <= 360) && X >= 7) { answer = true; }
            // end

            return answer;
        }
    }
}