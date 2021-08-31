using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace MEMBERS_MANAGER
{
    class DBclass
    {
        //singleton pattern
        private static DBclass instance;
        //implementation of singleton pattern
        
        //method for getting data from JSON in the folder called bin
        public List<Member> GetData()
        {
            List<Member> members = null;
            JArray jsonArray = JArray.Parse(File.ReadAllText("membersArray"));
            members = jsonArray.ToObject<List<Member>>();
            return members;
      
        }

        //method for saving data, writing a file JSON in the folder bin
        public void SaveData(List<Member> members)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(members);
            File.WriteAllText("membersArray", jsonString);
        }
        public static DBclass GetInstance()
        {
            if (instance == null)
                instance = new DBclass();
            return instance;
        }


    }



}
