// Program
/*Assignment: Grade Calculator
Write a C# program that calculates and displays the grade for a student based on their marks. The program should use the following grading system:
 
A: 90 - 100
B: 80 - 89
C: 70 - 79
D: 60 - 69
F: 0 - 59
Requirements:
The program should prompt the user to enter the student's marks.
Use a switch statement to determine the grade based on the marks.
Display the calculated grade to the user.
Additional Challenges (Optional):
Implement a loop to allow the user to enter marks for multiple students until they choose to exit.
Add validation to ensure that the entered marks are within a valid range (0-100).
Implement a feature to display additional comments based on the grade (e.g., "Excellent!" for an 'A' grade).
Example Output:
vbnet
Copy code
Enter the student's marks: 87
Grade: B
*/

using System.ComponentModel;
using System.Linq.Expressions;


var isMarkedEntered = false;
do
{
    Console.WriteLine("Welcome to Grade Calculator!");
    Console.WriteLine("Please enter marks of student to calculate its Grade!");
    var enteredStudentMarks = Console.ReadLine();


    // Processing Now
    // convert string enetered marks to int 
    int marksEntered = Convert.ToInt32(enteredStudentMarks);

    while (marksEntered > 100 || marksEntered < 0 || marksEntered <= -1)
    {
        Console.WriteLine("You entered invalid Numbers, Please enter valid numbers!");
        var newMarks = Console.ReadLine();

        marksEntered = Convert.TryParse(newMarks);
    }
    Console.WriteLine("Verify Please! we are taking your entered marks as: {0}", marksEntered);

    switch (marksEntered)
    {
        case int marks when (marks >= 90 && marks <= 100):
            {
                Console.WriteLine(Comments.Excellent + "! Your Grade is A for the entered marks : {0}", marksEntered);
            }
            break;
        case int marks when (marks >= 80 && marks <= 89):
            {
                Console.WriteLine(Comments.Good + "! Your Grade is B for the entered marks : {0}", marksEntered);
            }
            // code block
            break;
        case int marks when (marks >= 70 && marks <= 79):
            {
                Console.WriteLine(Comments.Average + "! Your Grade is C for the entered marks : {0}", marksEntered);
            }
            break;
        case int marks when (marks >= 60 && marks <= 69):
            {
                Console.WriteLine(Comments.Below_Average+ "! Your Grade is D for the entered marks : {0}", marksEntered);
            }
            break;
        case int marks when (marks >= 0 && marks <= 50):
            {
                Console.WriteLine(Comments.Fail+ "! Opps - Your Grade is F for the entered marks : {0}", marksEntered);
            }
            break;
    }
    
    
    Console.WriteLine("Would you want to calculate grade for other students marks, entere yes otherwise No!  OR Press any key to exit");
    var marksEneteredNew = Console.ReadLine();
    if (marksEneteredNew.Trim().ToLower() == "yes")
    {
        isMarkedEntered = true;
    }
    else if (marksEneteredNew.Trim().ToLower() == "no" || marksEneteredNew == "")
    {
        isMarkedEntered = false;
    }
} while (isMarkedEntered);


public enum Comments
{
    [Description("Excellent")]
    Excellent,

    [Description("Good")]
    Good,

    [Description("Average")]
    Average,

    [Description("Below Average")]
    Below_Average,

    [Description("Fail")]
    Fail
};