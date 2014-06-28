using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FileSystemApi.App_Code
{
    public class XMLFileSystemExepetion : Exception
    {
        public XMLFileSystemExepetion(string msg) : base(msg) { }
    }
}