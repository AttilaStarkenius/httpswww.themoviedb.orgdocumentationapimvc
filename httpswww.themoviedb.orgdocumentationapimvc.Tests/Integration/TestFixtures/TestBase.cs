﻿using System;
using System.Runtime.InteropServices;
using httpswww.themoviedb.orgdocumentationapimvc.Configurations;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration.TestFixtures
{
    public abstract class TestBase
    {
        private const string ApiKeyVariableName = "tmdbapikey";
        protected readonly ITmdbEasyClient _clientWithNoApiKey;
        protected readonly ITmdbEasyClient _clientWithApiKey;

        protected TestBase()
        {
            _clientWithNoApiKey = GetTestClient();
            _clientWithApiKey = GetTestClient(GetApiKey());
            _userApiKey = GetApiKey();
        }

        public readonly string _userApiKey;

        public ITmdbEasyClient GetTestClient(string sharedApiKey = null)
        {
            return new TmdbEasyClient(GetDefaultOptions(sharedApiKey));
        }

        public TmdbEasyOptions GetDefaultOptions(string sharedApiKey)
        {
            return new TmdbEasyOptions(sharedApiKey, useSsl: true, defaultLanguage: "en");
        }

        public string GetApiKey()
        {
            EnvironmentVariableTarget environmentVariableTarget = EnvironmentVariableTarget.User;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                environmentVariableTarget = EnvironmentVariableTarget.Process;
            }

            return Environment.GetEnvironmentVariable(ApiKeyVariableName, environmentVariableTarget);
        }
    }
}
