namespace GCHFDPE.DecoratingObjects.AbstractClasses
{
    public abstract class Beverage
    {
        /*
         * DP: Open-Closed Principle
         * Classes should be open for extension, but closed for modification
         *      Ex: We can Subject any time in Observer pattern without doing any code changes
         *      One more ex is decorator pattern here as well
         */
        
        /*

        DECORATOR PATTERN: 
        Component and Decorator

            Attaches additional responsibilities to an object dynamically, 
            - Flexible alternative to subclassing for extending functionality
            - Though we use 'inheritance' to achieve the "type" matching between Decorator and the object it wraps
            - We aren't using inheritance to get "behavior"
                - Because if we rely only on inheritance here, then our behavior is determined statically at compile time
                - So we get only whatever behavior superclass has to offer or that we override; leading to code changes in future
            - With 'composition' for "behavior" we can mix and match decorators any we like, at runtime

        */
        protected string _description = "Unknown Beverage"; //protect so its inheriting members can access

        //Without "virtual" the method would be 'sealed', meaning we couldn’t override it in any subclasses
        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double Cost();
    }
}
