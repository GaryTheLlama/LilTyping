using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilTyping
{
    public static class Resources
    {
        #region Versioning

        private const int MajorVersion = 0;
        private const int MinorVersion = 0;
        private const int RevisionVersion = 1;

        public static string Version = String.Format("{0}.{1}.{2}", MajorVersion, MinorVersion, RevisionVersion);

        #endregion

        #region Strings

        public const string GameTitle = "Li'l Typing";

        #endregion

        #region Graphics

        public const string PaperLlamaLogo = "Assets/PaperLlamaLogo.png";

        #endregion
    }
}
