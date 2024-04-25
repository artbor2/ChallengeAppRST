int[] grades = new int[5];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piatek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
Console.WriteLine(dayOfWeeks[2]);
Console.WriteLine(dayOfWeeks.Length);

string[] dayOfWeeks2 = new string[] {"poniedziałek", "wtorek", "środa",
                                     "czwartek", "piątek", "sobota",
                                     "niedziela"};
Console.WriteLine(dayOfWeeks2[3]);
Console.WriteLine(dayOfWeeks2.Length);

string[] dayOfWeeks3 = {"poniedziałek", "wtorek", "środa", "czwartek", 
                        "piątek", "sobota", "niedziela"};
Console.WriteLine(dayOfWeeks3[4]);
Console.WriteLine(dayOfWeeks3.Length);