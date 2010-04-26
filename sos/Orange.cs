using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace SOS
{
    class Orange
    {
        const string urlLogin = "http://www.orange.ch/footer/login/loginForm";
        const string urlSMS = "http://www.orange.ch/myorange/sms/smsForm";

        const string checkerLogged = "<div id=\"alreadyLoggedText\">";

        string lastResult = "<none>";
        public string LastResult
        {
            get
            { return this.lastResult; }
        }

        const string orangeSignature = " (www.orange.ch)\r\n";
        const int messageMaxLength = 160;

        static public int userMessageMaxLength
        {
            get
            { return messageMaxLength - orangeSignature.Length; }
        }

        bool isLogged = false;
        public bool IsLogged
        {
            get { return this.isLogged; }
        }
        CookieContainer cookies = new CookieContainer();

        public string Time
        {
            get  { return ((long)(System.DateTime.UtcNow.ToFileTimeUtc() / 100000)).ToString(); }
        }

        public bool login(string username, string password)
        {
            string data = "";
            data += "wui_target_id=loginButton";
            data += "&wui_event_id=onclick";
            data += "&username=" + username;
            data += "&password=" + password;

            string res = this.postRequest(urlLogin + "?ts=" + this.Time, data);
            this.isLogged = res.Contains(checkerLogged);
            return this.isLogged;
        }

        public bool send(string numbers, string message, string signature)
        {
            if (!this.isLogged)
                return false;

            string data = "";
            data += "wui_target_id=sendButton";
            data += "&wui_event_id=onclick";
            data += "&destinationNumberInput=" + numbers;
            data += "&messageInput=" + message;
            data += "&charNumberLeftOutput=" + new StringBuilder().Append(160 - 10 - message.Length).ToString();
            data += "&signatureInput=" + signature;

            string res = this.postRequest(urlSMS + "?ts=" + this.Time, data);

            return true;
        }

        public bool logout()
        {
            return true;
        }

        private string postRequest(string url, string data)
        {            
            byte[] dataToPost = new ASCIIEncoding().GetBytes(data);

            // Creation de la requete
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = dataToPost.Length;
            request.CookieContainer = this.cookies;

            // Envoie des donnees
            Stream myStream = request.GetRequestStream();
            myStream.Write(dataToPost, 0, dataToPost.Length);
            myStream.Close();
                        
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            System.IO.StreamReader reader = new StreamReader(response.GetResponseStream());

            this.lastResult = reader.ReadToEnd();
            return this.lastResult;
        }

        public override string ToString()
        {
            string res = "--- COOKIE ---" + "\n";
            foreach (Cookie cook in this.cookies.GetCookies(new System.Uri(urlLogin)))
            {
                res += "Cookie:" + "\n";
                res += cook.Name + " = " + cook.Value + "\n";
                res += "Domain: " + cook.Domain + "\n";
                res += "Path: " + cook.Path + "\n";
                res += "Port: " + cook.Port + "\n";
                res += "Secure: " + cook.Secure + "\n";

                res += "When issued: " + cook.TimeStamp + "\n";
                res += "Expires: " + cook.Expires + "(expired? " + cook.Expired + ")" + "\n";
                res += "Don't save: " + cook.Discard + "\n";
                res += "Comment: " + cook.Comment + "\n";
                res += "Uri for comments: " + cook.CommentUri + "\n";
                res += "Version: RFC " + (cook.Version == 1 ? "2109" : "2965") + "\n";

                // Show the string representation of the cookie.
                res += "String: " + cook.ToString() + "\n";
            }

            res += "\n--- RESULT ---" + "\n";
            res += this.lastResult + "\n";
            res += "\n--- LOGGED ---" + "\n" + this.isLogged;

            return res;
        }
    }
}
