using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using httpswww.themoviedb.orgdocumentationapimvc.Controllers;


namespace httpswww.themoviedb.orgdocumentationapimvc.Controllers
{
    //22.7.2021. I test to create class MovieController to get information from moviedb
    //with the help of this website: https://github.com/tonykaralis/TmdbEasy
    public class MovieController : Controller
    {
        private readonly IMovieApi _movieApi;

        public HomeController(IMovieApi movieApi)
        //public HomeController IMovieApi(IMovieApi movieApi)
        //public HomeController Void(IMovieApi movieApi)


        //22.7.2021. public HomeController(IMovieApi movieApi) gives me error CS1520:
        //Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS1520  Method must have a return type httpswww.themoviedb.orgdocumentationapimvc  
        //            C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Controllers\MovieController.cs   15	Active
        //so I change public HomeController(IMovieApi movieApi) to public HomeController IMovieApi(IMovieApi movieApi)
        //but I get error  CS0161: Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS0161	'MovieController.IMovieApi(IMovieApi)': not all code paths return a value   
        //httpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Controllers\MovieController.cs	16	Active
        //so I change to public HomeController Void(IMovieApi movieApi) but I still
        //get error CS0161: Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS0161	'MovieController.Void(IMovieApi)': not all code paths return a value    
        //httpswww.themoviedb.orgdocumentationapimvc 
        //C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Controllers\MovieController.cs	17	Active
        //so I change back to public HomeController(IMovieApi movieApi) and
        //add using httpswww.themoviedb.orgdocumentationapimvc.Controllers; thinking it would help
        //to access Homecontroller but it doesn't help...
        //Because website mentions registering all the services like this: public void ConfigureServices(IServiceCollection services)
        //{
        //    // Typically get these options from IConfiguration, Environment variables etc
        //    var options = new TmdbEasyOptions();

        //    // Adds TmdbEasy to your app
        //    services.AddTmdbEasy(options);
        //}
        //and I don't have startup.cs class I use this website as help https://stackoverflow.com/questions/43076150/asp-net-web-api-startup-cs-doesnt-exist
        //and 


        //26.10.2021. I first commit all and then push all in git changes I notice
        //notice same issue as person on this website:
        //https://stackoverflow.com/questions/56014634/create-git-repo-with-new-project-in-visual-studio-2019
        //"not being given the option to save your code to git, when you're creating a new project"
        //I do same "Add to source cotrol" -> Push to Remote Repository.

        {
            _movieApi = movieApi;
        }

        public async Task<IActionResult> Index()
        {
            int movieId = 550; //taken from the UI or wherever

            var movie = await _movieApi.GetDetailsAsync(movieId);

            return View(movie);
        }
    }
}