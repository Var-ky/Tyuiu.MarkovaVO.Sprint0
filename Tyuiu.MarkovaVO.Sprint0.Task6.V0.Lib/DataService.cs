namespace Tyuiu.MarkovaVO.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] nambers)
        {
            var total = 0;
            for (var i = 0; i < nambers.Length; i++)
            {
                total = total + nambers[i];
            }
            return total;
        }

        public static object SubtractionArray(int[] nambers)
        {
            var total = 0;
            int index = 0;
            while (index < nambers.Length)
            {
                total = total - nambers[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] nambers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * nambers[index];
                index++;
            }
            while (index < nambers.Length);

            return total;
        }
    }
}
