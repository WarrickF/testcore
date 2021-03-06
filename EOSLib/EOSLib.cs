﻿using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EOSLib
{

    //This interface must be implemented by any class wishing to be treated as a row of an EOS table. 
    public interface IEOSTable
    {
        EOSTableMetadata getMetadata();
    }

    //Defines the properties of a table. Any table implementing IEOSTable will need to return on of these in order to provide details of where table exists on the EOS chain. 
    public class EOSTableMetadata
    {
        public string primaryKey;
        public string contract;
        public string scope;
        public string table;       
    }


}

