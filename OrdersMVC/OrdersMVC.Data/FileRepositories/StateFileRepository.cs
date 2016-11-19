using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using OrdersMVC.Models;

namespace OrdersMVC.Data.FileRepositories
{
    public class StateFileRepository : IStateRepository
    {
        private string _fileName = "DataFiles/states.txt";

        public StateFileRepository()
        {
            // This code solves the problem between web and local file system.
            if (HttpContext.Current != null)
            {
                _fileName = HttpContext.Current.Server.MapPath("~/" + _fileName);
            }
        }

        public List<State> GetAll()
        {
            List<State> allStates = new List<State>();

            if (File.Exists(_fileName))
            {
                using (var reader = new StreamReader(_fileName))
                {
                    //read the header line
                    reader.ReadLine();

                    string inputLine;
                    while ((inputLine = reader.ReadLine()) != null)
                    {
                        var columns = inputLine.Split(',');
                        var state = new State()
                        {
                            Abbreviation = columns[0],
                            Name = columns[1]
                        };

                        allStates.Add(state);
                    }
                }
            }

            return allStates;
        }

        public State GetById(string id)
        {
            return GetAll().FirstOrDefault(c => c.Abbreviation == id);
        }
    }
}
