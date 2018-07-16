using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PC_Admin_Panel.Classes
{
    class IP_Data
    {
        /// <summary>
        /// Method prepare query about user's IP
        /// </summary>
        /// <returns> query with full informations </returns>
        public static string Get_Data_From_IP()
        {
            string rows_name = string.Empty;
            string rows_data = string.Empty;

            string query = string.Empty;

            string comma = ",";

            var client = new RestClient("https://ipapi.co/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);

            int count = dictionary.Count;
            int nr = 0;

            foreach (var key in dictionary.Keys)
            {
                nr++;
                if (nr == 18)
                    comma = "";

                rows_name += $"{key.ToString()} {comma}";
                rows_data += $"'{dictionary[key]}' {comma}";
            }

            query = $"INSERT INTO ip_data ( admin_id, {rows_name}) VALUE ('{Session.Admin_Login}',{rows_data})";

            return query;

        }
    }
}
