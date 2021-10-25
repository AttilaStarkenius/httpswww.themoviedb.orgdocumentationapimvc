using System;
using System.Net.Http;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.Configurations;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc
{
    public class TmdbEasyClient : ITmdbEasyClient
    //  public class TmdbEasyClient : ITmdbEasyClient gives me error CS0738: 
    //  Severity	Code	Description	Project	File	Line	Suppression State
    //  Error   CS0738	'TmdbEasyClient' does not implement interface member
    //  'ITmdbEasyClient.Options'. 'TmdbEasyClient.Options' cannot implement 'ITmdbEasyClient.Options'
    //  because it does not have the matching return type of 'TmdbEasyOptions'.	
    //  httpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\TmdbEasyClient.cs	9	Active
    //I fix it by adding all interfaces also in an Interface map to the project
    ////8.7.2021. I try to get information from https://www.themoviedb.org/documentation/api
    //I download c# wrapper for themoviedb.org: https://www.nuget.org/packages/TMdbEasy/
    //I write in Package Manager Console: Install-Package TMdbEasy -Version 1.1.0
    //I get message in package manager console: Successfully installed
    //'TmdbEasy 1.1.0' to httpswww.themoviedb.orgdocumentationapimvc
    //I download the corresponding source code from https://github.com/tonykaralis/TMdbEasy and
    //add it to my project
    //8.7.2021. when I run project I get error CS0122: Severity	Code	Description	Project	File	Line	Suppression State
    //Error CS0122  'IRequestHandler' is inaccessible due to its protection level   httpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Apis\CreditApi.cs    9   Active
    //so I ad using System.Data.Services; in CreditApi.cs file and every other file in Apis map
    //13.7.2021. I am about replace even Homecontroller with Tmdbeasy homecontroller but the I 
    //notice there isn't tmdbeasy controllers with that file name but they are spread in tmdbeasy project

    {
        private readonly IJsonDeserializer _jsonDeserializer;
        private readonly HttpClient _httpClient;

        public TmdbEasyClient(TmdbEasyOptions options)
        {          
            Options = options ?? throw new ArgumentNullException(nameof(options));

            _jsonDeserializer = options.JsonDeserializer;

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Options.UseSsl ? Constants.TmdbUrl3Ssl : Constants.TmdbUrl3)
            };
        }

        public TmdbEasyOptions Options { get; }

        public async Task<TmdbEasyModel> GetResponseAsync<TmdbEasyModel>(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
                throw new ArgumentException($"{nameof(TmdbEasyClient)} query param null or empty");

            string jsonResult = await _httpClient.GetStringAsync(query);

            return _jsonDeserializer.DeserializeTo<TmdbEasyModel>(jsonResult);
        }
    }
}
