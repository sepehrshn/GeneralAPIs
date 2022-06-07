using System;
using System.IO;
using System.Net;
using System.Text;

namespace Public.Helper
{
    public class TelegramBot
    {
        public static void Send_Message_To_Dev(string message) 
        {
            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            string apiToken = "5448676316:AAHx8OQEBR7U5ZwSPL21jl8EVZQT_R1pb_A";
            string chatId = "@sepehrshn94";
            string text = message;
            urlString = String.Format(urlString, apiToken, chatId, text);
            WebRequest request = WebRequest.Create(urlString);
            Stream rs = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(rs);
            string line = "";
            StringBuilder sb = new StringBuilder();
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    sb.Append(line);
            }
            string response = sb.ToString();
            // Do what you want with response
        }
    }
}
