namespace GeometrusAkulovIvan
{
    public class CubeMath
    {
        public double S(float a)
        {
            double S = Math.Pow(a,2);
            return S;
        }
        public double V(float a)
        {
            double V = S(a) * a;
            return V;
        }
        
        public double math(float number)
        {
            return Math.Pow(number, 3) / 2;
        }
    }
}