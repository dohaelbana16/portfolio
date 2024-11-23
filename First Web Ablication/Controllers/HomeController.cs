using Microsoft.AspNetCore.Mvc;
using First_Web_Ablication.Models;
using System.Collections.Generic;
using First_Web_Ablication.ViewModels;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.WelcomeMessage = "Welcome to My Portfolio";
        ViewBag.Description = "I am Doha Elbana, a .NET Developer with a passion for creating dynamic web applications.";
        return View();
    }

    public IActionResult Skills()
    {
       
        var skills = new List<Skill>
{
    new Skill { Title = ".NET Development", Description = "Expertise in building web applications using ASP.NET Core and .NET Framework, MVC, Web APIs, and Entity Framework.", Icon = "fas fa-dot-circle" },
    new Skill { Title = "Front-End Technologies", Description = "Proficient in Angular, HTML, CSS, JavaScript, and responsive design using Bootstrap.", Icon = "fab fa-angular" },
    new Skill { Title = "Database Management", Description = "Experienced in SQL Server, MySQL, and handling complex queries, database design, and optimization.", Icon = "fas fa-database" },
    new Skill { Title = "Version Control", Description = "Experience in using Git and GitHub for version control and collaboration in team projects.", Icon = "fab fa-github" },
    new Skill { Title = "Agile Methodology", Description = "Familiar with Agile practices, Scrum, and using tools like Jira for project management.", Icon = "fas fa-sync-alt" },
    new Skill { Title = "Problem Solving", Description = "Strong analytical and problem-solving skills in various software development tasks.", Icon = "fas fa-lightbulb" }
};


        return View(skills);
    }

    public IActionResult Contact()
    {
        string inp = "Feel free to reach out for any inquiries or collaborations.";
        return View("Contact",inp);
    }

    public IActionResult Projects()
    {
     
        var projects = new List<ProjectViewModel>
    {
        new ProjectViewModel
        {
            Title = "Portfolio Website",
            Description = "Developed a personal portfolio website using Html,css, showcasing my skills, projects, and contact information.",
            ImageUrl = "~/images/1.png",
            ProjectLink = "https://github.com/dohaelbana16/web-portfolio.git"
        },
        new ProjectViewModel
        {
           Title = "My Portfolio",
          Description = "An MVC-based portfolio project built to showcase my latest work, leveraging dynamic content rendering, enhanced user experience, and responsive design using ASP.NET Core MVC.",
          ImageUrl = "~/images/2.png",
            ProjectLink = "https://github.com/dohaelbana16/portfolio"
        }
    };

        return View(projects);
    }

}
