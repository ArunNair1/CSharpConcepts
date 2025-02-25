namespace ConceptsExample
{
    public class MyGenericClass<T>
    {
        public T testValue;

        public MyGenericClass(T _testValue)
        {
            testValue = _testValue;
        }
        public void PrintMyValue()
        {
            Console.WriteLine(testValue);
        }
    }

    public class CallingClass
    {
        public T callMyGenericClass<T>()
        {
            int a = 10;
            MyGenericClass<int> abc = new MyGenericClass<int>(a);
            abc.PrintMyValue();

            string b = "test";
            MyGenericClass<string> abcd = new MyGenericClass<string>(b);
            abcd.PrintMyValue();

            MyModel myModel = new MyModel();
            myModel.rollNo = 1;
            myModel.FirstName = "Test";
            myModel.LastName = "Test2";
            MyGenericClass<MyModel> ab = new MyGenericClass<MyModel>(myModel);
            ab.PrintMyValue();

            return (T)Convert.ChangeType(a, typeof(T)); 

        }
    }

    public class MyModel
    {
        public int rollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}