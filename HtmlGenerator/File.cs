using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator
{
    internal class File : IStorageObject
    {

        private string _name;

        private string _content;

        public File(string name, string content)
        {
            _name = name;
            _content = content;
        }

        public void ListName(string indentation)
        {
            Console.WriteLine(indentation + "<" + _name + ">" +  _content + "<" + _name + "/>");

        }
    }
    }
