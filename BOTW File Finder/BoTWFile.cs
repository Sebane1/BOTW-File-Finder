using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTW_File_Finder {
    public class BoTWFile {
        public BoTWFile(string name, string filepath) {
            Name = name;
            Filepath = filepath;
        }

        [OLVColumn()]
        public string Name { get; set; }
        public string Filepath { get; set; }
        public bool AddedToList { get; set; }
    }
}
