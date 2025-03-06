using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkManager
{
    class LinkDetails
    {
        public string Title { get; set; }       // Link title
        public string URL { get; set; }         // Link URL
        public string FolderName { get; set; }  // Folder where the link is stored
    }

    class Link
    {
        public string Title { get; set; }       // Link title
        public string URL { get; set; }         // Link URL
        public string Folder { get; set; }      // Folder where the link is stored
        public string FolderName { get; internal set; }

        public Link() { }
        public Link(string title, string url, string folder)
        {
            Title = title;
            URL = url;
            Folder = folder;
        }
        public override string ToString()
        {
            return $"{Title} ({URL})";
        }
    }



}
