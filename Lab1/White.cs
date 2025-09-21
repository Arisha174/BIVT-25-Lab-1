namespace Lab1
{
    public class White
    {

        public bool Task1(double d)
        {
            bool answer = false;
            // code here
            if (d > 0)
                answer = true;
            // end
            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;
            // code here
            if (n % 2 == 0)
                answer = true;
            // end
            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = a;
            // code here
            if (b > a)
            {
                answer = b;
            }
            // end
            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = d;
            // code here
            if (Math.Abs(d) > Math.Abs(f))
                answer = f;
            // end
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 1;

            // code here
            if (Math.Abs(x) <= 1) 
            answer = x;
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;
            // code here
            if (Math.Abs(x * x + y * y - r * r) <= 0.0001)
                answer = true;
            // end
            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            answer = (((s - n) > (2 * n)) && (n % 2 == 0));
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;
            // code here
            //answer = (L <= 30 && (M % 2 == 0) && (M >= 5 || T >= 5));
            if (L <= 30 && M + T >= 5 && M % 2 == 0)
            {
                answer = true;
            }
            // end
            return answer;
        }
    }
}