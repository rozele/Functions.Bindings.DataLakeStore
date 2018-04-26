﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace Functions.Bindings.DataLakeStore
{
    /// <summary></summary>
    public class DataLakeStoreOutput
    {
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        public string filename;

        /// <summary>
        /// Gets or sets the stream.
        /// </summary>
        public Stream stream;
          
    }
}
