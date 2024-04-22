/// <summary>
/// delegate declaration
/// </summary>
public delegate int Number(int n);
namespace GettingStarted_UST
{
    public class DelegateAssignment
    {
        static int Num = 10;
        public static int AddNum(int a)
        {
        Num += a;
        return Num;
        }
        public static int MultNum( int b)
        {
            Num *= b;
            return Num;
        }
        public static int SubNum(int c)
        {
            Num -= c;
            return Num;
        }
        public static int getNum()
        {
            return Num;
        }

        internal class Number
        {
        }
    }
}
