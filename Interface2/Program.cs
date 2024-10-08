namespace Interface2
{
    //N1
    interface ICalc
    {
        public int Less(int valueToCompare);

        public int Greater(int valueToCompare);



    }
    interface IShow
    {
        public void ShowEven();
        public void ShowOdd();
    }

    interface ICalc2
    {
        public int CountDistinct(); 
        public int EqualToValue(int valueToCompare);
    }
    
    class Aray: ICalc, IShow, ICalc2
    {
        public int[] arr {  get; set; }
        public Aray(int[] arr)
        {
            this.arr = arr;
        }
        public int Less(int value)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (value < arr[i])
                {
                    count++;
                }    
            }
            return count;
        }
        public int Greater(int value)
        {

            int count = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (value > arr[i]) {
                
                count++;
                
                }
            }
            return count;
        }
        public void ShowEven()
        {
            Console.WriteLine("Четные элементы:");
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void ShowOdd()
        {
            Console.WriteLine("Нечетные элементы:");
            foreach ( var i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public int CountDistinct()
        {
            HashSet<int> uniqueElements = new HashSet<int>(arr);
            return uniqueElements.Count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (valueToCompare == arr[i]) 
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            Aray obj = new Aray([2, 3, 4, 5, 6, 7,8,9]);


            Console.WriteLine("Количество элементов больше 5: " + obj.Less(5));
            Console.WriteLine("Количество элементов меньше 6: " + obj.Greater(6));
            ////N2

            obj.ShowEven();

            obj.ShowOdd();
            //N3

            Console.WriteLine("Количество уникальных элементов: " + obj.CountDistinct());

            Console.WriteLine("Количество чисел равных 4: " + obj.EqualToValue(4));
        }
    }
}
