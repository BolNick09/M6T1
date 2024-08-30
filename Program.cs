namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Learner[] mLearners =
            //{
            //    new Schoolar ("Ivan", "Ivanov", new DateTime (1990, 1, 1), "Math", "A"),
            //    new Schoolar ("Petr", "Petrov", new DateTime (1992, 2, 2), "Math", "B")
            //};

            //foreach (var m in mLearners)
            //{
            //    m.print();
            //    m.think();
            //    m.study();
            //}

            Triangle trg = new Triangle(3, 4, 5);

            Console.WriteLine($"Perimetr: {trg.calcPermetr()}");
            Console.WriteLine($"Square: {trg.calcSquare()}");

        }
    }
}
