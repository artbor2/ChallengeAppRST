using System.Diagnostics;
using System.Globalization;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid data (ocena z poza zakresu 0-100)");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Strin in not float");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (this.grades.Count > 0)
            {
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                //var index = 0;
                //while (index < this.grades.Count)
                //{
                //    statistics.Max = Math.Max(statistics.Max, grades[index]);
                //    statistics.Min = Math.Min(statistics.Min, grades[index]);
                //    statistics.Average += grades[index];
                //    index++;
                //}

                // var index = 0;

                //do
                //{
                //    statistics.Max = Math.Max(statistics.Max, grades[index]);
                //    statistics.Min = Math.Min(statistics.Min, grades[index]);
                //    statistics.Average += grades[index];
                //    index++;
                //} while (index < this.grades.Count);

                foreach (var grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

                statistics.Average /= this.grades.Count;
            }
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        internal Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        internal Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;

            return statistics;

        }

        internal Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;
            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}