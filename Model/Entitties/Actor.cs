using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitties
{
    public class Actor
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int YearsActive { get; set; }
        public ICollection<Movie> Movies { get; set; }

        public Actor() { }

        public Actor(string picture, string firstName, string lastName, string biography, DateTime? dob, int yearsActive)
        {
            Picture = picture;
            FirstName = firstName;
            LastName = lastName;
            Biography = biography;
            DateOfBirth = dob;
            YearsActive = yearsActive;
        }
    }
}
