using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraProject
{
    
        public class Album
        {
            public string _name { get; set; }
            public string _composer { get; set; }
            public DateTime _Release_date { get; set; }
            public int _track_count { get; set; }
            public Album()
            {
            }

            public Album(string name, string composer)
            {
                _name = name;
                _composer = composer;
            }
            public Album(string name, string composer, int track_count)
            {
                _name = name;
                _composer = composer;
                _track_count = track_count;
            }
        }
}
