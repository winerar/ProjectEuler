using ProjectEuler;

var problems = new List<IProblem>
{
    new LargestPrimeFactor(),
    new EvenFibonacciNumbers(),
    new MultiplesOf3Or5(),
    new NumberLetterCounts(),
    new LargestPalindromeProduct(),
    new SmallestMultiple(),
    new SumSquareDifference(),
    new TenThousandFirstPrime(),
    new LargestProductInASeries(),
    new SpecialPythagoreanTriplet(),
    new SummationOfPrimes(),
    new PowerDigitSum(),
};
var orderedProblems = new SortedList<int, IProblem>();

problems.ForEach(problem => orderedProblems.Add(problem.Id, problem));

bool exit = false;
while (!exit)
{
    Console.Clear();
    Console.WriteLine($"Total solved: {orderedProblems.Count}.\n");
    foreach (var problem in orderedProblems.Values)
    {
        PrintProblemTitle(problem);
    }

    Console.WriteLine("\nEnter problem ID: ");
    int.TryParse(Console.ReadLine(), out int id);
    if (!orderedProblems.ContainsKey(id))
    {
        continue;
    }
    else
    {
        Console.Clear();
        PrintProblem(orderedProblems[id]);
    }

    Console.WriteLine("\n\"Esc\" to exit. Other key to show problem list.");
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Escape:
            exit = true;
            break;
        default:
            break;
    }
}

void PrintProblem(IProblem problem)
{
    PrintProblemTitle(problem);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\n{problem.Description}\n");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Solution: {problem.Solution}.");
    Console.ResetColor();
}

void PrintProblemTitle(IProblem problem)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Problem {problem.Id}. {problem.Title}.");
    Console.ResetColor();
}