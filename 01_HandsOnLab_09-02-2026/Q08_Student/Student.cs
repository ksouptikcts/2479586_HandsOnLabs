using System;

class Student
{
    public string Fname{get; set;}
    public string Lname{get; set;}
    public int Roll{get; set;}
    public int Age{get; set;}
    public string Gender{get; set;}
    public string Grade{get; set;}


    public Student(string fname, string lname, int roll, int age, string gender, string grade)
    {
        Fname = fname;
        Lname = lname;
        Roll = roll;
        Age = age;
        Gender = gender;
        Grade = grade;
    }

    public void PrintStudent()
    {
        Console.WriteLine($"First Name: {Fname}, Last Name: {Lname}, Roll: {Roll}, Age: {Age}, Gender: {Gender}, Grade:{Grade} ");
    }
}