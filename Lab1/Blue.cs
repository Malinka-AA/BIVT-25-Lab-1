namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            // code here
            if (a > 0 && b > 0 || a < 0 && b < 0 || a == 0 && b ==0)
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if ((int)d != (double)d )
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && Math.Abs(a)%Math.Abs(b)==0)
                answer = true;
            // end
            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = f;

            // code here
            if (Math.Abs(d) > Math.Abs(answer))
                answer = d;
            if (Math.Abs(g) > Math.Abs(answer))
                answer = g;

                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if (x > -1 && x <= 0)
                answer = x + 1;
            else
                answer = 1;
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            if (Math.Sqrt(circleS/Math.PI)*2 <= Math.Sqrt(squareS))
                answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int coins = (a/2 + b/2 + c/2);
            if (a > 0 && b > 0 && c > 0)
            {
                if (coins % 3 == 0 || (coins + 1) % 3 == 0)
                {
                    if (a>=(coins+1)/3 && b>=(coins+1)/3 && c>=(coins + 1)/3)
                    {
                        answer = true;
                    }

                }
                // end
            }
            return answer;
        }
    }

}
