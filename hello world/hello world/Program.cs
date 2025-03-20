Console.WriteLine("how many students you have? ");

int students = int.Parse(Console.ReadLine());

int counter = 1;

int sum = 0;

while (counter <= students)
{
    Console.WriteLine("please enter the student grade: ");
    
    int grade = int.Parse(Console.ReadLine());

    sum = sum + grade;

    counter++;

}

double average = (double)sum / students;

Console.WriteLine("the average grade of your students is : " + " " + average);