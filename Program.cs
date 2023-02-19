// 1. klasa Employee, - imię , nazwisko, wiek oraz punkty - w postaci liczb całkowitych.
// 2. stworzyć 3 pracowników każdemu pięć ocen
// 3. nappisz program który wyszuka pracownika z najwyższą liczbą ocen - wyświetl jego dane.

using ConsoleApp71;

Employee employee1 = new Employee("Edward", "Stanek", 30);
Employee employee2 = new Employee("Ewelina", "Krzywonos", 28);
Employee employee3 = new Employee("Stanisław", "Szkutnik", 19);

employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(7);

employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(4);

employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>();
{
    employees.Add(employee1);
    employees.Add(employee2);
    employees.Add(employee3);
};

var bestUser = employee1;
foreach (var employee in employees)
{
    if (employee.Resault > bestUser.Resault)
    {
        Employee userWithMaxResult = employee;
    }
}
Console.WriteLine($"Najlepszy rtezultat uzyskał pracownik {bestUser.Name} {bestUser.LastName} : {bestUser.Resault} punktów.");