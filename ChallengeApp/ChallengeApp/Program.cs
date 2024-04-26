using ChallengeApp;

User user1 = new User("Adam", "3466534t7684");
User user2 = new User("Monika", "3636272727");
User user3 = new User("Zuzia", "2666663436662");
User user4 = new User("Damian", "2663748445r");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var pi = Math.PI;