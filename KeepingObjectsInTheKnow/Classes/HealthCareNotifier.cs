namespace GCHFDPE.KeepingObjectsInTheKnow.Classes
{
    public class HealthCareNotifier
    {
        /* Events and Delegates
         * 
         * Pager is delegate, 
         *      while PageDepartments is the event that enables
         *      HealthCareNotifier to notify all listeners
         * 
         * Reads: 
         * https://medium.com/@lexitrainerph/observer-pattern-in-c-from-basics-to-advanced-ea4b2d748e
         * https://dev.to/sebastiandevelops/understanding-c-delegates-and-events-with-real-world-examples-2an6
         * 
         */
        /*
         * HealthCareNotifier is the Subject
         *      with PatientMetricMonitor trigger that triggers notification
         *      using PageDepartments?.Invoke() which notifies all listeners
         *      listeners MUST MATCH delegate signature (from which event is built on)
         *          Ex: "No _overload_ Cardiology matches delegate HealthCareNotifier.Pager"
         *              , if I provided string param for Cardiology
         */
        public delegate void Pager();

        public event Pager PageDepartments;

        public void PatientMetricMonitor()
        {
            if(40 < 80)
            {
                Console.WriteLine("Patient metrics down");
                PageDepartments?.Invoke();
            }
        }

        public void Cardiology()
        {
            Console.WriteLine("Cardiac department alert!");
        }

        public void Neurology()
        {
            Console.WriteLine("Neurology department alert!");
        }

        public void Nurse()
        {
            Console.WriteLine("Nurse department alert!");
        }
    }
}
