using LogicLayer.BusinessLogic;
using LogicLayer.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentHandler handler = new StudentHandler();
            List<Student> studentList = handler.GetAll();
            return View(studentList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            StudentHandler handler = new StudentHandler();
            Student studentInfo = handler.GetById(id);
            return View(studentInfo);
            
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Student temp = new Student();

                temp.Name = collection["Name"];
                temp.StudentID = collection["StudentID"];
                
                StudentHandler handler = new StudentHandler();
                if (handler.Insert(temp) == true)
                    return RedirectToAction("Index");

                else
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            StudentHandler temp = new StudentHandler();
            Student studentInfo = temp.GetById(id);
            return View(studentInfo);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                Student temp = new Student();
                StudentHandler handler = new StudentHandler();
                temp.Id = id;
                temp.Name = collection["Name"];
                temp.StudentID = collection["StudentID"];
                
                if (handler.Update(temp) == true)
                {
                    return RedirectToAction("Index");
                }
                else
                    return RedirectToAction("Edit");


            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            StudentHandler temp = new StudentHandler();
            Student studentInfo = temp.GetById(id);
            return View(studentInfo);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                StudentHandler handler = new StudentHandler();
                handler.DeleteById(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
