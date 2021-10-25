using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Images;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
//using httpswww.themoviedb.orgdocumentationapimvc.DTO;

namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
{
    public interface ICollectionApi
    {

        //18.7.2021. I try to learn to use version control and object oriented
        //programming because Unicus company's employer suggested me to practice
        //on those areas. Therefor I try to learn to use git desktop so I open it,
        //current repository is still httpdeveloper.marvel which was for my earlier solution
        //so I push ingit git desktop menu view-repository list and push add-add existing repository
        //but I can't find local git repository so I clone instead add-clone repository
        //but suprise is that then I find the path "C:\Users\Attila\Documents\GitHub\httpswww.themoviedb.orgdocumentationapimvc"
        //of the not yet existing local repository when cloning the repository
        //from Github website.. Now I now where the local repository
        //files will be created. I clone the repository.
        //But on the main page of github desktop is text "No local changes" 
        //so I try to make a local commit in Visual Studio's Git Changes but Visual Studio freezes
        //so I just check that local and remote repository setting are directing the push in
        //right repository from menu git-repository settings-remotes and change from httpswww.themoviedb.orgdocumentationapi
        //to httpswww.themoviedb.orgdocumentationapimvc and add rest of files from TmdbEasy project to
        //this project httpswww.themoviedb.orgdocumentationapimvc

        //20.7.2021. Git changes are too slow for one big commit so I
        //just staged Attila/Android map files to begin with

        /// <summary>
        /// Get collection details by id.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="apiKey"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        Task<Collections> GetDetailsAsync(int collectionId, string apiKey = null, string language = null);
        /// <summary>
        /// Get the images for a collection by id.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="apiKey"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        Task<Images> GetImagesAsync(int collectionId, string apiKey = null, string language = null);
    }
}
