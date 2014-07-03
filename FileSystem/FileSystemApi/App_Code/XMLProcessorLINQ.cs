using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace FileSystemApi.App_Code
{
    public class XMLProcessorLINQ
    {
        private FileSystem.Models.FileSystem filesystem;
        private XElement xFileSystem;

        public void LoadFile(String file)
        {
            xFileSystem = XElement.Load(file);
        }

        private void InitBookstore()
        {
            IEnumerable<XAttribute> attributes = from node in xFileSystem.Attributes()
                                                 select node;
            string name = null, id = null, parentFolderId = null;
            bool isMine = true, thumb = true, canRead = true, canModify = true,
                canDelete = true, canCreate = true, isShared = true;
            foreach (var item in attributes)
            {
                if (item.Name == "name") name = item.Value;
                if (item.Name == "id") id = item.Value;
                if (item.Name == "parentFolderId") parentFolderId = item.Value;
                if (item.Name == "isMine") isMine = (item.Value == "да")?true:false;
                if (item.Name == "thumb") thumb = (item.Value == "да") ? true : false;
                if (item.Name == "canRead") canRead = (item.Value == "да") ? true : false;
                if (item.Name == "canModify") canModify = (item.Value == "да") ? true : false;
                if (item.Name == "canDelete") canDelete = (item.Value == "да") ? true : false;
                if (item.Name == "canCreate") canCreate = (item.Value == "да") ? true : false;
                if (item.Name == "canCreate") isShared = (item.Value == "да") ? true : false;
            }
            this.filesystem = new FileSystem.Models.FileSystem();
            this.filesystem.Name = name;
            this.filesystem.Id = id;
            this.filesystem.ParentFolderId = parentFolderId;
            this.filesystem.IsMine = isMine;
            this.filesystem.Thumb = thumb;
            this.filesystem.CanRead = canRead;
            this.filesystem.CanModify = canModify;
            this.filesystem.CanDelete = canDelete;
            this.filesystem.CanCreate = canCreate;
            this.filesystem.IsShared = isShared;
        }

        public FileSystem.Models.FileSystem GetFileSystem()
        {
            InitBookstore();
            //SetAddress();
            //SetPhone();
            //SetEmail();
            //SetManager();
            //SetWorkingHours();
            //SetBooks();
            if (filesystem != null)
            {
                return this.filesystem;
            }
            else
            {
                throw new XMLFileSystemExepetion("the filesystem is null");
            }
        }
    }
}