using System;

// initialize variables - graded assignments 
int examAssignments = 5;
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = {90,86,87,98,100,94,90};
int[] andrewScores = {92,89,81,96,90,89};
int[] emmaScores   = {90,85,87,98,68,89,89,89};
int[] loganScores  = {90,95,87,88,96,96};
int[] beckyScores  = {92,91,90,91,92,92,92};
int[] chrisScores  = {84,86,88,90,92,94,96,98};
int[] ericScores   = {80,90,100,80,90,100,80,90};
int[] gregorScores = {91,91,91,91,91,91,91}; 

Console.WriteLine("Student\t\tGrade\n"); //write header line

foreach (string name in studentNames)
{
    string currentStudent = name;
    int[] studentScores = new int[10]; 
    int studentSum = 0;

    //pull score array depending on student
    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }    
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }   
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    } 
    else if (currentStudent == "Becky")
    {
        studentScores = beckyScores;
    }    
    else if (currentStudent == "Chris")
    {
        studentScores = chrisScores;
    }
    else if (currentStudent == "Eric")
    {
        studentScores = ericScores;
    }
    else if (currentStudent == "Gregor")
    {
        studentScores = gregorScores;
    }        
    else
    {
        continue;    
    }

    // initialize/reset a counter for the number of assignments
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;           

        if (gradedAssignments <= examAssignments)
        {
            studentSum += score; // add the exam score to the sum
        }       
        else
        {
            studentSum += score / 10; // add the extra credit points to the sum - bonus points equal to 10% of an exam score  
        }                          
    }    
  
    decimal studentScore = (decimal)studentSum/examAssignments; //calculate score

    //assign letter grade based on score
    string StudentLetterGrade = "";
    if (studentScore >= 97)
    {
        StudentLetterGrade = "A+";
    }
    else if (studentScore >= 93)
    {
        StudentLetterGrade = "A";
    }
    else if (studentScore >= 90)
    {
        StudentLetterGrade = "A-";
    }    
    else if (studentScore >= 87)
    {
        StudentLetterGrade = "B+";
    }
    else if (studentScore >= 83)
    {
        StudentLetterGrade = "B";
    }
    else if (studentScore >= 80)
    {
        StudentLetterGrade = "B-";
    }
    else if (studentScore >= 77)
    {
        StudentLetterGrade = "C+";
    }
    else if (studentScore >= 73)
    {
        StudentLetterGrade = "C";
    }
    else if (studentScore >= 70)
    {
        StudentLetterGrade = "C-";
    }
    else if (studentScore >= 67)
    {
        StudentLetterGrade = "D+";
    }
    else if (studentScore >= 63)
    {
        StudentLetterGrade = "D";
    }
    else if (studentScore >= 60)
    {
        StudentLetterGrade = "D-";
    }
    else
    {
        StudentLetterGrade = "F";
    }

    Console.WriteLine($"{currentStudent}:\t\t{studentScore}\t{StudentLetterGrade}"); //write out results
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
