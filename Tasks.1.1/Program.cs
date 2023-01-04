namespace Tasks._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region task 1
            ////Console.WriteLine("The lengh of massive");
            ////int n = int.Parse(Console.ReadLine());
            ////int[] arr = new int[n];
            ////int count = 0;
            ////int sum = 0;

            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    arr[i] = int.Parse(Console.ReadLine());
            ////}

            ////for (int i = 0; i < arr.Length; i++)
            ////{

            ////    if (arr[i] < 0)
            ////    {
            ////        count++;
            ////        sum += arr[i];
            ////    }

            ////}
            ////Console.WriteLine($"The sum of the negative elements of the array {sum}, number {count}");
            //#endregion

            ////#region task 2
            //Console.WriteLine("The lengh of massive");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 5 == 0 && arr[i] % 7 !=0)
            //    {
            //        count++;
            //        sum += arr[i];
            //    }
            //}       
            //Console.WriteLine($"sum {sum} and number {count} of array elements divisible by 5 and not divisible by 7");
            ////#endregion




            //#region task 3
            //Console.WriteLine("The lengh of massive");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0 && arr[i] % 2 == 1)
            //    {
            //        count++;
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine($"Sum {sum} and number {count} of array elements that are both positive and odd at the same time");
            //#endregion


            //#region task 4
            //Console.WriteLine("The lengh of massive");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 ==1 && arr[i] % 2 == 0)
            //    {
            //        count++;
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine($"sum {sum} and number {count} of even array elements in even places");
            //#endregion


            //#region task 5
            //Console.WriteLine("The lengh of massive");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 0 && arr[i] % 2 == 0)
            //    {
            //        count++;
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine($"sum {sum} and number {count} of even array elements in odd order");
            //#endregion


            //#region task 6
            //Console.WriteLine("The lengh of massive");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 1 && arr[i] % 2 == 1)
            //    {
            //        count++;
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine($"sum {sum} and number {count} of odd array elements in even order");
            //#endregion


            #region task 7
            Console.WriteLine("The lengh of massive");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 1 || arr[i] % 7 == 2 || arr[i] % 7 == 5)
                {
                    count++;
                }
            }
            Console.WriteLine($"the number  of elements with a remainder of 1, 2, or 5 when divided by 7: {count}");
            #endregion
        }
    }
}