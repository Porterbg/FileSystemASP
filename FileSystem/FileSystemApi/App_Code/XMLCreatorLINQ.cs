using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace FileSystemApi.App_Code
{
    public class XMLCreatorLINQ
    {
        private XDocument doc;

        //public void CreateFileSystemXmlDocument(String path, string dtd, Bookstores store)
        public void CreateFileSystemXmlDocument(String path, string dtd, string store)
        {
            XDocumentType type = new XDocumentType("FileSystem", null, dtd, null);
            doc = new XDocument(type);
        }
    }
}