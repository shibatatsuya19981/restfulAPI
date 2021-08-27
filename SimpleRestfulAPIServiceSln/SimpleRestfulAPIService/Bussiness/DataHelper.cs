using Newtonsoft.Json;
using SimpleRestfulAPIService.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestfulAPIService.Bussiness
{
    public class DataHelper
    {
        public IEnumerable<UserDTO> Load_Data()
        {
            //string pathOfData = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "MOCK_DATA.json"); ;
            string pathOfData = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName+"\\SimpleRestfulAPIService".ToString(), "MOCK_DATA.json"); ;
            //Debug.Write(File.ReadAllText(pathOfData));

            List<UserDTO> items = new List<UserDTO>();
            using (StreamReader streamReader = new StreamReader(pathOfData))
            {
                string json = streamReader.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<UserDTO>>(json);
            }
            return items;
        }
    }
}
