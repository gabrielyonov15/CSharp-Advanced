namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<decimal>();
                }
                studentGrades[studentName].Add(grade);
            }
            foreach (var student in studentGrades)
            {
                string name = student.Key;
                List<decimal> grades = student.Value;
                decimal average = grades.Average();
                string gradesOutput = string.Join(" ", grades.Select(g => g.ToString("F2")));
                Console.WriteLine($"{name} -> {gradesOutput} (avg: {average:F2})");
            }
        }
    }
}