using OpenQA.Selenium.Support.PageObjects;

namespace Framework.AndroidPages
{
    
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(App.Driver, page);
            return page;

        }
        //Application page definitions
        public static TriRailMainPage TriRailMain => GetPage<TriRailMainPage>();

        public static TripPlannerPage TripPlanner => GetPage<TripPlannerPage>();

        public static SystemMapPage SystemMap => GetPage<SystemMapPage>();

        public static TrainSchedulePage TrainSchedule => GetPage<TrainSchedulePage>();

        public static SchedulePage Schedule => GetPage<SchedulePage>();

        public static FaresPage Fares => GetPage<FaresPage>();

        public static FareCalculatorPage FareCalculator => GetPage<FareCalculatorPage>();
    }
}