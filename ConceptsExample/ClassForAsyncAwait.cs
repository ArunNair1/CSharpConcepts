using System.Text;

namespace ConceptsExample
{
    public class ClassForAsyncAwait
    {

        public string output { get; set; }
        public ClassForAsyncAwait()
        {
            output = "";
        }
        public async Task<int> method1()
        {
            int sum = 0;
            await Task.Run(() => { 
             for (int i = 0; i < 100; i++)
                {
                    sum += 1;

                    output+="Method 1 executed";

                    Console.WriteLine($"Method1: Sum = {0}", sum);
                    Task.Delay(100).Wait();
                } 
            });
           
            return sum;
        }
        public void method2()
        {
            int sum = 0;
            for (int i = 0; i < 25; i++)
            {
                sum += 1;
                output += "Method 2 executed";
                Console.WriteLine($"Method2: Sum = {0}", sum);
                Task.Delay(100).Wait();
            }

        }
        public void method3(int result)
        {
            output += "Method 3 executed";
            Console.WriteLine($"Method1: Sum = {0}", result);
        }

        public async Task<string> useAllMethods()
        {
            output += "Method useAll executed";
            int result = await method1();
            method2();
            var result1 = method5();
            var result2 = method4();

            method3(result);

            return output;

        }

        public async Task<int> method5()
        {
            int sum = 0;
            await Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    sum += 1;
                    output += "Method 5 executed";
                    Console.WriteLine($"Method5: Sum = {0}", sum);
                    Task.Delay(100).Wait();
                }
            });

            return sum;
        }
        public async Task<int> method4()
        {
            int sum = 0;
            await Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    sum += 1;
                    output += "Method 4 executed";
                    Console.WriteLine($"Method4: Sum = {0}", sum);
                    Task.Delay(100).Wait();
                }
            });

            return sum;
        }

        public string PrintNumbers()
        {
            for (int i = 0; i < 25; i++)
            {
                output += $"Method {i}executed \n";
                Task.Delay(100).Wait();
            }
            return output;
        }
    }

    

}