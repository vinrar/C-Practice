namespace NullableTypesAndNullCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tyes can be categeorized into 2 categeories
            //reference type and value type
            //value type - int, double, float etc
            //reference type - class, delegate, interface etc.,

            //Just like int default value is 0, reference types 
            //default value is null

            int age = 10;
            //int age = null; won't work
            //but what if user in a field doesn't tell us about the age. What if he leaves it blank?
            //then comes conversion of value types to nullable type

            int? age2 = null;
            //age2 can be a value or null

            bool trueOrFalse = true; //boolean values always have to be either true or false
            //they can also be converted to nullable types

            bool? trueOrFalse2 = null; //this variable can be assigned with true, false or null.

            //Now Null Coalescing operator

            int? ticketsOnSale = null;
            int availableTickets;

            if (ticketsOnSale != null)
                availableTickets = ticketsOnSale.Value;
            else
                availableTickets = 0;

            // the above code can be optimised using null-coalescing operator

            availableTickets = ticketsOnSale ?? 0;
            //It implies avaiableTickets is equal to ticketsOnSale if it is not equal to null else it is 0;
        }
    }
}
