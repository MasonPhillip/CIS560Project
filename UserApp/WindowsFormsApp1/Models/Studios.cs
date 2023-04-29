using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Studios
    {
        public int StudioId { get; }
        public string StudioName { get; }
        internal Studios(int studioId, string studioName) 
        {
            StudioId = studioId;
            StudioName = studioName;
        }

        public override string ToString()
        {
            return StudioName;
        }
    }
}
