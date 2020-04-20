namespace CalculatorFunctionsSpase
{
    public class CalculatorFunctions
    {
        public static T Minus<T>(T num_1, T num_2)
        {
            T vichitanie = (dynamic) num_1 - (dynamic) num_2;
            return vichitanie;
        }
        
        public static T Plus<T>(T num_1, T num_2)
        {
            T slozhenie = (dynamic) num_1 + (dynamic) num_2;
            return slozhenie;
        }

        public static T Division <T>(T num_1, T num_2)
        {
            T delenie = (dynamic) num_1 / (dynamic) num_2;
            return delenie;
        }

        public static T Multiplication<T>(T num_1, T num_2)
        {
            T umnozhenie = (dynamic) num_1 * (dynamic) num_2;
            return umnozhenie;
        }
    }
}