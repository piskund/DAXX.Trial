// -------------------------------------------------------------------------------------------------------------
//  JsonTradesInfoReader.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using CodeContracts;
using Daxx.Trial.DAL.JsonBasedImpl.Models;
using Newtonsoft.Json;

namespace Daxx.Trial.DAL.JsonBasedImpl
{
    internal static class JsonTradesInfoReader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonTradesInfoReader"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public static JsonTradesListModel ReadTradesFromFile(string fileName)
        {
            Requires.NotNullOrEmpty(fileName, nameof(fileName));

            if (!File.Exists(fileName))
            {
                throw new ArgumentException("Wrong path to the json file.");
            }

            var data = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<JsonTradesListModel>(data);
        }
    }
}