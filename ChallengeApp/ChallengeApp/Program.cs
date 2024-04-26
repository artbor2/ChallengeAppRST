﻿User user1 = new User("Adam", "3466534t7684");
User user2 = new User("Monika", "3636272727");
User user3 = new User("Zuzia", "2666663436662");
User user4 = new User("Damian", "2663748445r");

var name = user1.Login;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);

internal class User
{
    private List<int> scores = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.scores.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.scores.Add(number);
    }
}