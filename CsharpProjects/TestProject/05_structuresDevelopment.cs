/*
Supongamos que es auxiliar de un profesor en un colegio y que desarrolló una aplicación 
para automatizar el proceso de calificación. La aplicación usa matrices para almacenar 
los nombres de los alumnos y las tareas calificadas. La aplicación también implementa 
una combinación de instrucciones de iteración y selección para calcular y notificar 
la calificación final de cada alumno. La aplicación incluso diferencia entre las tareas 
de los exámenes y las tareas de créditos adicionales al calcular las calificaciones de 
los alumnos. Aunque la aplicación hace todo lo que el profesor solicitó, ha recibido una 
solicitud de nuevas características. El profesor le ha pedido que actualice el informe de 
calificaciones para que muestre las notas de los exámenes y las tareas de créditos 
adicionales separadas de la calificación numérica final y la nota con letra.
*/

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
// This code updates the student grade report to include an extra credit score.

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

decimal extraCreditScore;

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    // New change: Declare and initialize the extra credit score variable.
    extraCreditScore = 0;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    New change: Add the extra credit score to the sum of assignment scores if the number of graded assignments is greater than the number of exam assignments.
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
        {
            sumAssignmentScores += score / 10;
            extraCreditScore += score / 10;
        }
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    // New change: Print the extra credit score.
    Console.WriteLine($"{currentStudent}\t\t{sumAssignmentScores}\t{currentStudentGrade}\t{extraCreditScore}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
