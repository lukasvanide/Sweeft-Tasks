using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Task7;


 var teachers = GetAllTeachersByStudent("giorgi");
Console.WriteLine();
static  Teacher[] GetAllTeachersByStudent(string studentName)
{
    var db = new AplicationDbContext();
    return  db.TeacherPupils.Where(x => x.Pupil.FirstName == studentName)
    .Select(x => x.Teacher)
    .ToList().ToArray();
}



public class Teacher
{
    [Key]
    public int TeacherId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public string Subject { get; set; }
}

public class Pupil
{
    [Key]
    public int PupilId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public string Class { get; set; }
}

public class TeacherPupils
{
    [Key]
    public int Id { get; set; }

    public Teacher Teacher {  get; set; }
    public int TeacherId { get; set; }

    public Pupil Pupil { get; set; }
    public int PupilId { get; set; }

}
