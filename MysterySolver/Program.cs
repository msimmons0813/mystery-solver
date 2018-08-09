using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysterySolver {
    class Program {       

        static void Main(string[] args) {
            string filepath = "../../participants.txt";

            var fileLines = File.ReadAllLines(filepath).Skip((1)).ToList();

            List<string> personlst = new List<string>();
            List<string> liarlst = new List<string>();

            foreach (string line in fileLines) {
                if (line.Contains(",")){
                    string person = line.Substring(0, line.IndexOf(','));
                    personlst.Add(person);
                }
                else {
                    liarlst.Add(line);
                }
            }

            var truthful = personlst.Except(liarlst);
            var liars = personlst.Except(truthful);

            foreach (string p in truthful) {
                Console.WriteLine(p + " is truthful");
            }

            foreach (string p in liars) {
                Console.WriteLine(p + " is a liar");
            }


        }
    }
}
