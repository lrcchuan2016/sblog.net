﻿#region Disclaimer/License Info

/* *********************************************** */

// sBlog.Net

// sBlog.Net is a minimalistic blog engine software.

// Homepage: http://sblogproject.net
// Github: http://github.com/karthik25/sBlog.Net

// This project is licensed under the BSD license.  
// See the License.txt file for more information.

/* *********************************************** */

#endregion
using System.Configuration;
using sBlog.Net.Configuration;

namespace sBlog.Net.FluentExtensions
{
    public static class ContentInterpretationExtensions
    {
        public static bool IsMarkDown()
        {
            return BlogStaticConfig.EditorType == "markdown";
        }

        private static readonly SblogNetSettingsConfiguration BlogStaticConfig = ConfigurationManager.GetSection("sblognetSettings")
                                                 as SblogNetSettingsConfiguration;

    }
}