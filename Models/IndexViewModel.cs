using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise.Models
{
    public class IndexViewModel
    {
        public ToDo Todo { get; set; }
        public List<Asignee> Asignees { get; set; }

        public IndexViewModel()
        {
            Asignees = new List<Asignee>();
        }
    }
}
