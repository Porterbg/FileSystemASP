using System;

namespace FileSystemApi.App_Code
{
    public class DTDException : Exception
    {
        public DTDException(string msg) : base(msg) { }
    }
}