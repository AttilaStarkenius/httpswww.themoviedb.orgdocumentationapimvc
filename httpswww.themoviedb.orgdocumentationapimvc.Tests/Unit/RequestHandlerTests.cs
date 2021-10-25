using System;
using NUnit.Framework;
using httpswww.themoviedb.orgdocumentationapimvc.Configurations;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit
{
    [TestFixture]
    public class RequestHandlerTests
    {
        [Test]
        public void Constructor_WithNullClient_ShouldThrowArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new RequestHandler(null));
            //22.7.2021. var exception = Assert.Throws<ArgumentNullException>(() => new RequestHandler(null));
            // gives me error CS0122: Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0122  'RequestHandler' is inaccessible due to its protection level    
            //httpswww.themoviedb.orgdocumentationapimvc.Tests C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc.Tests\Unit\RequestHandlerTests.cs    13  Active
            //24.7.2021.to fix mentioned problem I change in IRequestHandler.cs file "internal interface IRequestHandler"
            //to "public interface IRequestHandler" but it gives additional error CS0050:
            //Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0050  Inconsistent accessibility: return type 'Request' is less accessible 
            //than method 'IRequestHandler.CreateRequest()'  
            //httpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Interfaces\IRequestHandler.cs    9   Active
            //so I change in IRequestHandler.cs file "Request CreateRequest();" to public Request CreateRequest();
            //but I still have error CS0122: Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0122  'RequestHandler' is inaccessible due to its protection level    
            //httpswww.themoviedb.orgdocumentationapimvc.Tests C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc.Tests\Unit\RequestHandlerTests.cs    13  Active
            //so I change in RequestHandler.cs from internal class RequestHandler : IRequestHandler
            //to public class RequestHandler : IRequestHandler
            //so I test to unload project "httpswww.themoviedb.orgdocumentationapimvc" and 
            //project "httpswww.themoviedb.orgdocumentationapimvc.Tests" and 





            Assert.That(exception.Message, Is.EqualTo("Value cannot be null. (Parameter 'client')"));
        }

        [Test]
        public void CreateRequest_CreatesValidRequest()
        {
            var handlerUnderTest = new RequestHandler(new TmdbEasyClient(new TmdbEasyOptions("apiKey")));

            Request request = handlerUnderTest.CreateRequest();

            Assert.IsNotNull(request);
        }
    }
}
