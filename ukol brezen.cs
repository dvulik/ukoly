using Spectre.Console;

string[] months = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
var selectedMonth = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("vyber si [blue]měsíc[/]")
        .PageSize(12)
        .AddChoices(months));

int numberOfDays = DateTime.DaysInMonth(DateTime.Now.Year, Array.IndexOf(months, selectedMonth) + 1);
int[] poleTeplot = new int[numberOfDays];

for (int i = 0; i < numberOfDays; i++)
{
    Console.WriteLine("zadej teplotu pro " + (i + 1) + ". den");
    int teplota = Convert.ToInt32(Console.ReadLine());
    poleTeplot[i] = teplota;
}

double average = Queryable.Average(poleTeplot.AsQueryable());

Console.WriteLine("Průměrná teplota: " + average + "°C" );
Console.WriteLine("Minimální teplota: " + (poleTeplot.Min()) + "°C");
Console.WriteLine("Maximální teplota: " + (poleTeplot.Max()) + "°C");