using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
    public class ImageRecord
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Location { get; set; } = "";

        public string ImagePath { get; set; } = "";
    }
}
