using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public int? AsigneeId { get; set; }
        public Asignee Asignee { get; set; }

        public ToDo(string title,bool isUrgent,bool isDone, string description)
        {
            Title = title;
            IsUrgent = isUrgent;
            IsDone = isDone;
            Description = description;
            
        }
        public ToDo()
        {
        }
    }
}
