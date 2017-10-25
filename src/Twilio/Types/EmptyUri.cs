using System;

namespace Twilio.Types
{
    public class EmptyUri : Uri
    {
        public static readonly EmptyUri Uri = new EmptyUri("");

        public new string AbsoluteUri {
            get {
                return "";
            }
        }

        private EmptyUri(string s) : base("https://this.is.empty") {}
    }
}

