namespace CoffeeMachine.API.Model
{
    public static class APICounter
    {
        static APICounter()
        {
            ResetAPICount();
        }
        public static int APICount { get; set; }

        public static void ResetAPICount()
        {
            APICount = 0;
        }
    }
}
