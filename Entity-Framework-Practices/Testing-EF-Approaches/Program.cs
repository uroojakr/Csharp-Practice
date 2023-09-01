using Testing_EF_Approaches.Data;
using Testing_EF_Approaches.Model;

StudentAppDBContext obj = new StudentAppDBContext();
Student studentobj = new Student()
{
    Name = "Urooj Akram",
    MobileNo = "433-33333",
};
obj.Add(studentobj);
obj.SaveChanges();
Console.WriteLine("Learning Entity Framework");