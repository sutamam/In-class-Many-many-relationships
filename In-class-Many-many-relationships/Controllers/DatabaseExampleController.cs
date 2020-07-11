using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using In_class_Many_many_relationships.DataAccess;
using Microsoft.EntityFrameworkCore;
using In_class_Many_many_relationships.Models;

namespace In_class_Many_many_relationships.Controllers
{
    public class DatabaseExampleController : Controller
    {
        public ApplicationDbContext dbContext;

        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ViewResult> DatabaseOperations()
        {
            Students student = new Students();
            student.StudentId = 1;
            student.StudentName = "Sutama";
            dbContext.Add(student);

            student = new Students();
            student.StudentId = 2;
            student.StudentName = "Shiva";
            dbContext.Add(student);

            student = new Students();
            student.StudentId = 3;
            student.StudentName = "Simon";
            dbContext.Add(student);

            student = new Students();
            student.StudentId = 4;
            student.StudentName = "Aurora";
            dbContext.Add(student);

            Courses course = new Courses();
            course.CourseId = 1;
            course.CourseName = "Distibuted Information System";
            dbContext.Add(course);

            course = new Courses();
            course.CourseId = 2;
            course.CourseName = "Database";
            dbContext.Add(course);

            course = new Courses();
            course.CourseId = 3;
            course.CourseName = "Distributed Management";
            dbContext.Add(course);

            course = new Courses();
            course.CourseId = 4;
            course.CourseName = "Advance System Analysis";
            dbContext.Add(course);

            course = new Courses();
            course.CourseId = 5;
            course.CourseName = "Data Mining";
            dbContext.Add(course);

            course = new Courses();
            course.CourseId = 6;
            course.CourseName = "Python Class";
            dbContext.Add(course);

            StudentCourseEnrollment sce = new StudentCourseEnrollment();
            sce.StudentId = 1;
            sce.CourseId = 1;
            dbContext.Add(sce);

            sce = new StudentCourseEnrollment();
            sce.StudentId = 1;
            sce.CourseId = 2;
            dbContext.Add(sce);

            sce = new StudentCourseEnrollment();
            sce.StudentId = 1;
            sce.CourseId = 3;
            dbContext.Add(sce);

            sce = new StudentCourseEnrollment();
            sce.StudentId = 2;
            sce.CourseId = 3;
            dbContext.Add(sce);

            sce = new StudentCourseEnrollment();
            sce.StudentId = 2;
            sce.CourseId = 4;
            dbContext.Add(sce);

            sce = new StudentCourseEnrollment();
            sce.StudentId = 3;
            sce.CourseId = 4;
            dbContext.Add(sce);

            dbContext.SaveChanges();
            return View();
        }


        }
    }
