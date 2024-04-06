
using ConsoleApp1;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("New world"); 

ApplicationCode appCode = new ApplicationCode();
//appCode.ConvertStringToLowercase(); // Convert string to lowercase
//appCode.ReverseStringpredefineFunction(); // Reverse string

//appCode.ReverseStringWithoutpredefineFunction();   //***************** without reverse function

//appCode.ReverseNumber();//***************** Reverse Number
appCode.ReplaceHash();


//************************************************
List<string> list = new List<string>() { "Ranjan", "Rishab", "sandhya", "Amith" };
List<int> list1 = new List<int>() { 1, 2, 3 };

List<Student> std = new List<Student>() {
  new  Student() { StudentID=1,StudentName="Ranjan",Age=10 },
  new Student() {StudentID=2,StudentName="Rishabh",Age=20},
  new Student() {StudentID=3,StudentName="Amith",Age=30},
  new Student() {StudentID=4,StudentName="Sandhya",Age = 40},
  new Student() {StudentID=4,StudentName="Nikhil",Age = 50},
  new Student() {StudentID=4,StudentName="Rehan",Age = 60},
  new Student() {StudentID=4,StudentName="Anuj",Age = 70}
};

var msSoD = list1.Where(x => x > 2).SingleOrDefault();

var qs = (from stds in std
          select stds.StudentID).ToList();
var stMS = std.ToList();


var employee = std
   // .OrderByDescending(e => e.Age)
   .OrderBy(x => x.Age)
       .Skip(5)
    .First();

var ms = std.Where(std => std.Age > 30).ToList();

var stu = from st in std.Where(s => s.Age > 15)
              //select st.StudentName;
          select new Student()
          {
              StudentID = st.StudentID,
              StudentName = st.StudentName,
              Age = st.Age
          };

var stMS1 = std.Select(x => new Student()
{
    StudentID = x.StudentID,
    StudentName = x.StudentName,
    Age = x.Age
}
            ).ToList();


foreach (var st in stMS1)
{
    Console.WriteLine($"Id={st.StudentID},Name={st.StudentName},Age={st.Age}");
}


Console.ReadLine();

