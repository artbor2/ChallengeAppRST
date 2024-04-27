/*
 * 1. Stwórz klasę Employee, w której przechowasz imie, nazwisko, wiek
 * oraz punktypracownika w postaci listy
 * 2. Stwórz 3 pracowników i kazdemu przydziel po 5 ocen z zakresu od 1 do 10
 * 3. Napisz program który wyszuka pracownika z najwyzszą liczbą ocen
 * a następnie wyswietli jego dane oraz wynik.
 */

using ChallengeApp;

Employee emp1 = new("Jan", "Abacki", 25);
Employee emp2 = new("Tomasz", "Babacki", 35);
Employee emp3 = new("Adam", "Cabacki", 31);

emp1.AddScore(4);
emp1.AddScore(7);
emp1.AddScore(6);
emp1.AddScore(5);
emp1.AddScore(6);

emp2.AddScore(5);
emp2.AddScore(4);
emp2.AddScore(7);
emp2.AddScore(2);
emp2.AddScore(9);

emp3.AddScore(3);
emp3.AddScore(4);
emp3.AddScore(8);
emp3.AddScore(9);
emp3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};

Employee maxScoreEmployee = employees[0];
foreach (var employee in employees)
{
    if (employee.Result > maxScoreEmployee.Result)
    {
        maxScoreEmployee = employee;
    }
}

Console.WriteLine(maxScoreEmployee.Name);
Console.WriteLine(maxScoreEmployee.Surname);
Console.WriteLine(maxScoreEmployee.Age);
Console.WriteLine("Scores: " + maxScoreEmployee.Result);