/* Naapisz w Program.cs kod, w którym:
 * - zadeklarujesz zmienną z imieniem,
 * - zadeklarujesz zmienną z płcią (dobierz odpowiednia),
 * - zadeklarujesz zmienną z wiekiem
 * 
 * A następnie napisz kilka instrukcji warunkowych,
 * które przeanalizują te dane w następujący sposób:
 * 
 * (1) jeśli mamy do czynienia z kobietą i ma ponizej 30 lat,
 *     to zwróć komunikat: "Kobieta poniżej 30 lat"
 * (2)"jeśli mamy do czynienie z osobą o imieniu Ewa i ma ona równe 30 lat,
 *     to zwróć komunikat: "Ewa, lat 30"
 * (3) jeśli mamy do czynienia z mężczyzną i ma poniżej 18 lat zwróć komunikat:
 *     "Niepełnoletni mężczyzna"
 * (4) jeśli dane nie spełniają żadnego z warunków program nie zwraca nic
 * 
 * UWAGA
 * Twój program za wsze powinien zwracać TYLKO JRDEN KOMUNIKAT 
 * lub w przypadku (4) nic !
 */

var name = "Adam";
var sex = 'M';
var age = 20;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if(sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni meżczyzna");
} 
