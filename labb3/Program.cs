namespace labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.Man;
            Hair hair = new Hair { Hairlength = "Short And", Haircolor = "Red" };
            DateTime birthday = new DateTime(1999, 09, 09);
            string eyecolor = "Red";

            Person person = new Person(gender, hair, eyecolor, birthday);

            Console.WriteLine(person.ToString());
            Console.ReadKey();
        }
    }
}
