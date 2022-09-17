namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator videoeditor = new VideoEditor("Georgi");
            Creator programmer = new Programmer("Asen");
            programmer.Name = "Ivan";
            //polymorphism  example
            List<Creator> creators = new List<Creator>();
            creators.Add(videoeditor);
            creators.Add(programmer);

            List<Programmer> programmers = new List<Programmer>();

            foreach (var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                Console.WriteLine(creator.Name);
                creator.Act();
            }

            //LINQ operations
            int programmersCount = creators.Where(p => p is Programmer).Count();
            creators = creators
                .OrderBy(c => c.Name)
                .ToList();
            creators = creators
                .OrderByDescending(c => c.Name)
                .ToList();
            var creators2 = creators
                .GroupBy(c => c.Name)
                .ToList();

            // Console.WriteLine(creators2.Count);

            // List<int> energies = creators
            //   .Select(c => c.Energy)
            // .ToList();
        }

    }
}