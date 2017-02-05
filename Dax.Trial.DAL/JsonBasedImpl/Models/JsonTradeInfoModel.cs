// -------------------------------------------------------------------------------------------------------------
//  JsonTradeInfoModel.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using Daxx.Trial.Abstractions.Interfaces;
using Newtonsoft.Json;

namespace Daxx.Trial.DAL.JsonBasedImpl.Models
{
    /// <summary>
    /// Represents model for serialize/deserialize trade info in json format.
    /// </summary>
    /// <seealso cref="ITradeInfoEntity" />
    internal class JsonTradeInfoModel : ITradeInfoEntity
    {
        private const string UrlPrefix = @"https://beta.twa.nl/nl";
        private string _salesUrl;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("i")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("stn")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        [JsonProperty("n")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [JsonProperty("c")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        [JsonProperty("cc")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the sales URL.
        /// </summary>
        /// <value>
        /// The sales URL.
        /// </value>
        [JsonProperty("url")]
        public string SalesUrl
        {
            get { return _salesUrl; }
            set
            {
                _salesUrl = value;
                Url = UrlPrefix + value;
            }
        }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonIgnore]
        public string Url { get; set; }
    }
}