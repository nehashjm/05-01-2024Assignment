namespace CalculatorAssignment
{
    public class Class1
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        
        public int Multiply()
        {
            int res;
            res = Fnum * Snum;
            return res;
        }
        public int Substract()
        {

            int res;
            res = Fnum - Snum;
            return res;
        }
        public int Division()
        {

            int res;
            res = Fnum / Snum;
            return res;
        }
    }
}