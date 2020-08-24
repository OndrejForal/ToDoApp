using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise
{
    public class ToDoService
    {
        public ApplicationDbContext context;
        public ToDoService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<ToDo> ReadFromDb()
        {
            return context.Todo.Include(x => x.Asignee).Where(d => d.Id > 0).ToList();
        }
        public void SaveToDb(ToDo todo)
        {
            context.Todo.Add(todo);
            context.SaveChanges();
        }
        public void DeteteFromDb(int id)
        {
            context.Todo.Remove(context.Todo.FirstOrDefault(d => d.Id == id));
            context.SaveChanges();
        }
        public void UpdateInDatabase(ToDo todo)
        {
          var result = context.Todo.FirstOrDefault(d => d.Id ==todo.Id);
            if (result!= null)
            {
                result.IsUrgent = todo.IsUrgent;
                result.IsDone = todo.IsDone;
                result.Title = todo.Title;
                result.Description = todo.Description;
                result.AsigneeId = todo.AsigneeId;
            }
            context.SaveChanges();
        }
        public List<ToDo> SearchInDb(string searchedText)
        {
            return context.Todo.Where(r => r.Title.Contains(searchedText) || r.Description.Contains(searchedText)).ToList();
        }

        public ToDo LoadByID(int id)
        {
            return  context.Todo.FirstOrDefault(r => r.Id == id); 
        }
        public List<ToDo> ReadAsignedToDoFromDb(int id)
        {
            return context.Todo.Include(x => x.Asignee).Where(x => x.AsigneeId == id).ToList();
        }    
    }
}
