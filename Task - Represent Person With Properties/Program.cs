namespace Task___Represent_Person_With_Properties
{
    internal class Program
    {
        static void Main()
        {
            Person aliceSmith = new("Alice", "Smith", "Teacher", 32);
            aliceSmith.IntroduceMyself();

            Person jamesLee = new("James", "Lee", "Lawyer", 28);
            jamesLee.IntroduceMyself();

            Person mariaGarcia = new("Maria", "Garcia", "Nurse", 35);
            mariaGarcia.IntroduceMyself();

            Person davidJones = new("David", "Jones", "Engineer", 30);
            davidJones.IntroduceMyself();

            Person emmaWang = new("Emma", "Wang", "Artist", 25);
            emmaWang.IntroduceMyself();
        }
    }
}