using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTW_File_Finder {
    public class MusicDescriptor {
        string filename;
        string category;
        string descriptor;

        public string Filename { get => filename; set => filename = value; }
        public string Category { get => category; set => category = value; }
        public string Descriptor { get => descriptor; set => descriptor = value; }

        public override string ToString() {
            return filename;
        }
    }
}
