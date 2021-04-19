using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Seance0419
{
    public class ImageObject
    {
        public Image Picture { get; set; }
        public string From { get; set; }
        public string Author { get; set; }

        public ImageObject() { }

        public ImageObject(Image picture, string from, string author)
        {
            Picture = picture;
            From = from;
            Author = author;
        }
    }
}
