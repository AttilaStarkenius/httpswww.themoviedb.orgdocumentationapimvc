using System.Threading.Tasks;

//namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces

{
    //internal interface IRequestHandler
    public interface IRequestHandler
    {
        //Request CreateRequest();
        public Request CreateRequest();
        //24.7.2021. public Request CreateRequest(); gives me error CS8703:
        //Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS8703  The modifier 'public' is not valid for this item in C# 7.3. 
        //Please use language version '8.0' or greater.	
        //httpswww.themoviedb.orgdocumentationapimvc	C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Interfaces\IRequestHandler.cs	10	Active
        //so I try to fix the error with the help of this website:
        //https://www.thecodebuzz.com/modifier-not-valid-this-item-c-use-language-version-greater/
        //but I can't find langversion property in any file of project so with the help of this website:
        //https://www.thecodebuzz.com/modifier-not-valid-this-item-c-use-language-version-greater/ in the
        //TmdbEasy.csproj file I add <LangVersion>Latest</LangVersion> and it did not solve the error CS8703 mentioned before
        //so I change TmdbEasy.csproj file name to httpswww.themoviedb.orgdocumentationapimvc.csproj but I get 
        //the error that httpswww.themoviedb.orgdocumentationapimvc.csproj already exists so I push in
        //Solution Explorer "Show all files" and search
        //for httpswww.themoviedb.orgdocumentationapimvc.csproj and find four files matching the search,
        //all in the httpswww.themoviedb.orgdocumentationapimvc\obj\Debug map:
        //httpswww.themoviedb.orgdocumentationapimvc.csproj.CopyComplete,
        //httpswww.themoviedb.orgdocumentationapimvc.csproj.CoreCompileInputs.cache,
        //httpswww.themoviedb.orgdocumentationapimvc.csproj.FileListAbsolute.txt and
        //httpswww.themoviedb.orgdocumentationapimvc.csprojAssemblyReference.cache
        //I can open all files except for cache so I google how to open cache files
        //I try to get help from this website: https://stackoverflow.com/questions/58751275/how-to-use-new-c-sharp-8-0-features-in-razor-views
        //But I can't find nuget package or extension to download latest c# so I
        //use this website: https://gunnarpeipman.com/select-csharp-version/
        //but in project's build properties is only text "Why can't I choose C# version"
        //with link to this website: https://docs.microsoft.com/sv-se/dotnet/csharp/language-reference/configure-language-version
        //so I use this website to my help: https://www.thecodebuzz.com/modifier-not-valid-this-item-c-use-language-version-greater/
        //I unload both projects(httpswww.themoviedb.orgdocumentationapimvc
        //and httpswww.themoviedb.orgdocumentationapimvc.Tests) and add both to 
        //httpswww.themoviedb.orgdocumentationapimvc.csproj
        //and httpswww.themoviedb.orgdocumentationapimvc.Tests.csproj
        //This property that didn't exist in those files at all: <LangVersion>Latest</LangVersion>
        //And then reload both mentioned projects. I have a test project
        //because I want to practice unit tetsting because Unicus employer gave
        //me the fantastic tip to practice on unit testing
        //26.7.2021. I get directly when I start the solution message "Do you want to normalize line endings?"
        //And I click yes. Sometimes a row is very long and I think it's easier to
        //read when you don't need to scroll sideways much - to each her own.





        Task<TmdbEasyModel> ExecuteAsync<TmdbEasyModel>(Request request);
    }
}
