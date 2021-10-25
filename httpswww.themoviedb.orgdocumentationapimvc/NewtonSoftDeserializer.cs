using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

[assembly: InternalsVisibleTo("httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit")]
namespace httpswww.themoviedb.orgdocumentationapimvc
{
    //21.7.2021. I try to commit the stages change in C/Attila/Android map
    //22.7.2021. When finding out my visual studio freezes even of that simple task I do a git commit from
    //a normal command prompt like this: cd C:\Users\Attila\Documents\GitHub\httpswww.themoviedb.orgdocumentationapimvc
    //and then git add --all and then git commit -m "comment" but
    //git commit -m "comment" gives message "nothing to commit"
    //I test git add -A && git commit -m "Your Message" but it also gives
    //message "nothing to commit" so I test
    //cd C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc and then
    //but I get error "could not open directory permission denied" even though I have launched command prompt
    //as an administrator


    internal class NewtonSoftDeserializer : IJsonDeserializer
    {
        public TmdbEasyModel DeserializeTo<TmdbEasyModel>(string json)
        {
            if (string.IsNullOrEmpty(json) || string.IsNullOrWhiteSpace(json))
                throw new ArgumentNullException("Cannot deserialize null or empty json value");

            return JsonConvert.DeserializeObject<TmdbEasyModel>(json);
        }
    }
}
