namespace TCP_Server
{
    class Program
    {
        public static VariableData data;
        public static void Main()
        {
            data = new VariableData();
            try
            {
                new Listen(data);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
    }
}