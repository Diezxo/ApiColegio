using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Domain.Entities.Models
{
    [Table("Estudiante")]
    public class Student: EntityBase
    {
        public Student()
        {
            // Materias= new HashSet<Subject>();
            Grades = new HashSet<Grade>();
            Services = new HashSet<Services>();
        }
        [Column("Nombre")]
        public string FirstName { get; set; } = null!;
        [Column("Apellido")]
        public string LastName { get; set; } = null!;
        [Column("FechaDeNacimiento")]
        public DateTime Date { get; set; }
        [Column("NumeroDeTelefono")]
        public string? PhoneNumber { get; set; }
        [Column("TutorLegal")]
        public string? Tutor { get; set; } = null!;
        [Column("IdCurso")]
        public int IdCourse { get; set; }
        [ForeignKey(nameof(IdCourse))]
        public virtual Course Course { get; set; } = null!;

        // public virtual ICollection<Subject> Materias { get;}

        public virtual ICollection<Grade> Grades { get; set; }

        
        public virtual ICollection<Services> Services { get; set; }
        public virtual short Age => (short)Math.Floor((DateTime.Now - Date).TotalDays / 365);

        public virtual string NameBuilder()
        {
            var name = new StringBuilder();
            name.Append(FirstName);
            name.Append(' ');
            name.Append(LastName);

            return name.ToString();
        }


    }
}
