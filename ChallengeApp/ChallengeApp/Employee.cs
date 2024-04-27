using System.Globalization;

namespace ChallengeApp
{
    internal class Employee
    {
        private List<int> scores = new List<int>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get { return scores.Sum(); }
        }


        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddScore(int score)
        {
            this.scores.Add(score);
        }



    }
}
