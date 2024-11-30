namespace Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

        }

        public static List<int> FillList(List<int> list, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter element {i + 1} :");
                list.Add(i);
            }
            return list;
        }

        public static bool ElementMoreFive(List<string> list)
        {
            var result = false;
            var AllElement = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var CounterElement = 0;
                for (int j = 0; j < list[i].Length; j++)
                {
                    CounterElement++;
                }

                if (CounterElement < 5)
                {
                    AllElement++;
                }
            }
            var size = list.Count;
            if (AllElement == size)
            {
                return true;
            }
            return result;

        }



        public static int FindEvenElements(List<int> Even)
        {
            var Counter = 0;
            for (int i = 0; i < Even.Count; i++)
            {
                if (Even[i] % 2 == 0)
                {
                    Counter++;
                }
            }
            return Counter;
        }

        public static string GetFirsthree(string text)
        {
            var SubsteredText = text.Substring(0, 3);
            return SubsteredText;

        }

        public static bool FindPdp(string text)
        {
            var result = false;
            if (text.Substring(0, 3) == "Pdp")
            {
                result = true;
            }

            return result;
        }






    }





}
