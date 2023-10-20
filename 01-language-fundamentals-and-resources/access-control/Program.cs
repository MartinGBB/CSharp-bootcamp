public class Program
{
  public static void Main()
  {
    Console.Clear();

    int numberOfPeople = 0;
    int numberOfChildren = 0;

    int inputAge;

    do
    {
      Console.WriteLine("Informe a idade da pessoa. Informe 0 para sair.");
      string? inputUser = Console.ReadLine();
      bool ageIsValid = int.TryParse(inputUser, out inputAge);

      if (!ageIsValid) Console.WriteLine("Dado invalido.");

      if (inputAge == 0) break;

      numberOfPeople++;
      if (inputAge < 18) numberOfChildren++;
    } while (inputAge > 0);

    if (numberOfPeople < 1)
    {
      Console.WriteLine("Até mais.");
      return;
    }

    double rateOfChildren = 100 * numberOfChildren / numberOfPeople;

    string childrenPluralOrSingular = numberOfChildren > 1 ? "crianças" : "criança";

    Console.WriteLine($"Temos {numberOfPeople} personas, e entre elas {numberOfChildren} {childrenPluralOrSingular}.");
    Console.WriteLine($"Com isso temos {rateOfChildren}% de crianças.");
  }
}