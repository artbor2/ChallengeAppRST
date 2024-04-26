User user1 = new User("Adam", "");
User user2 = new User("Monika", "");
User user3 = new User("Zuzia", "");
User user4 = new User("Damian", "");

// public, protected, internal, private
// user1.login = "Adam";

internal class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "_";
        this.password = "_";
        this.name = "_";
    }

    public User(string login)
    {
        this.login = login;
        this.password = "_";
        this.name = "_";
    }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "_";
    }
}