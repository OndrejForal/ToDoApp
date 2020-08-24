using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDbExercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstDbExercise.Controllers
{
    public class HomeController : Controller
    {
        public ToDoService toDoService;
        public AsigneeService asigneeService;
        public HomeController(ToDoService service, AsigneeService asignee)
        {
            this.toDoService = service;
            this.asigneeService = asignee;
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View(toDoService.ReadFromDb());
        }

        [HttpGet("add")]
        public IActionResult AddToDatabase()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult SaveToDatabase(ToDo todo)
        {
            toDoService.SaveToDb(todo);
            return RedirectToAction("List", "Home");
        }

        [HttpGet("delete")]
        public IActionResult DeleteFromDatabase(int id)
        {
            toDoService.DeteteFromDb(id);
            return RedirectToAction("List", "Home");
        }

        [HttpGet("edit")]
        public IActionResult EditInDatabase(int id)
        {
            var model = new IndexViewModel();
            model.Todo = toDoService.LoadByID(id);
            model.Asignees = asigneeService.ReadAssFromDb();

            return View(model);
        }

        [HttpPost("edit")]
        public IActionResult SaveEditInDatabase(ToDo todo)
        {
            toDoService.UpdateInDatabase(todo);
            return RedirectToAction("List", "Home");
        }

        [HttpPost("search")]
        public IActionResult SearchInDB(string searchedText)
        {
            return View(toDoService.SearchInDb(searchedText));
        }

        [HttpGet("listOfAss")]
        public IActionResult ListOfAssignes()
        {
            return View(asigneeService.ReadAssFromDb());
        }

        [HttpGet("addAss")]
        public IActionResult AddAssToDatabase()
        {
            return View();
        }

        [HttpPost("addAss")]
        public IActionResult SaveAssToDatabase(Asignee ass)
        {
            asigneeService.SaveAssToDb(ass);

            return RedirectToAction("ListOfAssignes", "Home");
        }
        [HttpGet("deleteASS")]
        public IActionResult DeleteAssFromDatabase(int id)
        {
            asigneeService.DeteteAssFromDb(id);
            return RedirectToAction("ListOfAssignes", "Home");
        }
        [HttpGet("update")]
        public IActionResult UpdateAssInDB(string name, string email)
        {
            return View(asigneeService.context.Asignees.FirstOrDefault(d => d.Name == name && d.Email == email));
        }

        [HttpPost("update")]
        public IActionResult SaveUpdateInDatabase(Asignee ass)
        {
            asigneeService.UpdateAssInDatabase(ass);
            return RedirectToAction("ListOfAssignes", "Home");
        }
        [HttpGet("asignedList")]
        public IActionResult ShowAsignedList(int id)
        {
            return View(toDoService.ReadAsignedToDoFromDb(id));
        }
    }
}
