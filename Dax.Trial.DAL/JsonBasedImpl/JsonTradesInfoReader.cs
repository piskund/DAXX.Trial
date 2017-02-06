// -------------------------------------------------------------------------------------------------------------
//  JsonTradesInfoReader.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using CodeContracts;
using Daxx.Trial.DAL.JsonBasedImpl.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

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
            CheckPreconditions(fileName);

            var data = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<JsonTradesListModel>(data);
        }

        /// <summary>
        /// Reads trades from the file asynchronously.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public static async Task<JsonTradesListModel> ReadTradesFromFileAsync(string fileName)
        {
            CheckPreconditions(fileName);

            string data;

            using (var streamReader = File.OpenText(fileName))
            {
                data = await streamReader.ReadToEndAsync();
            }

            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<JsonTradesListModel>(data));
        }

        /// <summary>
        /// Checks the preconditions.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="System.ArgumentException">Wrong path to the json file.</exception>
        private static void CheckPreconditions(string fileName)
        {
            Requires.NotNullOrEmpty(fileName, nameof(fileName));

            if (!File.Exists(fileName))
            {
                throw new ArgumentException("Wrong path to the json file.");
            }
        }
    }
}