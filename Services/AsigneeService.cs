using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise
{
    public class AsigneeService
    {
        public List<Asignee> Asignees { get; set; }
        public ApplicationDbContext context;
        public AsigneeService(ApplicationDbContext context)
        {
            Asignees = new List<Asignee>();
            this.context = context;
        }
        public List<Asignee> ReadAssFromDb()
        {
            return context.Asignees.Where(d => d.Id > 0).ToList();

        }
        public void SaveAssToDb(Asignee asignee)
        {
            context.Asignees.Add(asignee);
            context.SaveChanges();
        }
        public void DeteteAssFromDb(int id)
        {
            context.Asignees.Remove(context.Asignees.FirstOrDefault(d => d.Id == id));
            context.SaveChanges();
        }
        public void UpdateAssInDatabase(Asignee asignee)
        {
            var result = context.Asignees.FirstOrDefault(d => d.Id == asignee.Id);
            if (result != null)
            { 
                result.Name = asignee.Name;
                result.Email = asignee.Email;
            }
            context.SaveChanges();
        }
    }
}
