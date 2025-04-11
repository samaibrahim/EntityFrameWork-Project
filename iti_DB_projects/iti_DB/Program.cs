using iti_DB.Context;
using iti_DB.models;

namespace iti_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ITIContext context = new ITIContext();
            
            //// Insert Departments
            //var dept1 = new Department { Dept_Name = "Computer Science", Dept_Desc = "CS Department", Dept_Location = "Building A" };
            //var dept2 = new Department { Dept_Name = "Mathematics", Dept_Desc = "Math Department", Dept_Location = "Building B" };
            //context.Departments.AddRange(dept1, dept2);
            //context.SaveChanges();

            //// Insert Instructors
            //var instructor1 = new Instructor { Ins_Name = "Dr. Ahmed", Ins_Degree = "PhD", Salary = 6000, Dept_id = dept1.Dept_Id };
            //var instructor2 = new Instructor { Ins_Name = "Prof. Ali", Ins_Degree = "MSc", Salary = 5000, Dept_id = dept2.Dept_Id };
            //context.Instructors.AddRange(instructor1, instructor2);
            //context.SaveChanges();

            //// Insert Topics
            //var topic1 = new Topic { Name = "Database Systems" };
            //var topic2 = new Topic { Name = "Artificial Intelligence" };
            //var topic3 = new Topic { Name = "Calculus" };
            //context.Topics.AddRange(topic1, topic2, topic3);
            

            //// Insert Courses
            //var course1 = new Course { Crs_Name = "SQL Fundamentals", Duration = 40, Top_Id = topic1.Top_Id };
            //var course2 = new Course { Crs_Name = "Machine Learning", Duration = 60, Top_Id = topic2.Top_Id };
            //var course3 = new Course { Crs_Name = "Linear Algebra", Duration = 45, Top_Id = topic3.Top_Id };
            //context.Courses.AddRange(course1, course2, course3);
            

            //// Insert Students
            //var student1 = new Student { FName = "Sama", LName = "Ibrahim", St_Address = "Cairo", St_Age = 22, Dept_Id = dept1.Dept_Id };
            //var student2 = new Student { FName = "ahmed", LName = "Ali", St_Address = "Alexandria", St_Age = 23, Dept_Id = dept2.Dept_Id };
            //var student3 = new Student { FName = "mostafa", LName = "Alaa", St_Address = "Giza", St_Age = 21, Dept_Id = dept1.Dept_Id };
            //context.Students.AddRange(student1, student2, student3);
            

            //// Insert Student-Courses 
            //var enrollment1 = new Student_Course { St_Id = student1.St_Id, Crs_Id = course1.Crs_Id, Grade = 90 };
            //var enrollment2 = new Student_Course { St_Id = student2.St_Id, Crs_Id = course2.Crs_Id, Grade = 85 };
            //var enrollment3 = new Student_Course { St_Id = student3.St_Id, Crs_Id = course3.Crs_Id, Grade = 88 };
            //var enrollment4 = new Student_Course { St_Id = student1.St_Id, Crs_Id = course2.Crs_Id, Grade = 92 };
            //context.Student_Courses.AddRange(enrollment1, enrollment2, enrollment3, enrollment4);
           

            //// Insert Instructor-Courses 
            //var insCourse1 = new Ins_Crs { Ins_Id = instructor1.Ins_Id, Crs_Id = course1.Crs_Id, Evaluation = "Excellent" };
            //var insCourse2 = new Ins_Crs { Ins_Id = instructor2.Ins_Id, Crs_Id = course2.Crs_Id, Evaluation = "Very Good" };
            //var insCourse3 = new Ins_Crs { Ins_Id = instructor1.Ins_Id, Crs_Id = course3.Crs_Id, Evaluation = "Good" };
            //context.Ins_Cources.AddRange(insCourse1, insCourse2, insCourse3);
            //context.SaveChanges();




        }
    }
}
