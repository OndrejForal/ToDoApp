using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise
{
    public class Asignee
    {
        [Key]
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Email { get; set; }

        public List<ToDo> Todos { get; set; }

        public Asignee(string name,string email)
        {
            Name = name;
            Email = email;
            Todos = new List<ToDo>();
        }
        public Asignee()
        {

        }
    
    }
}
