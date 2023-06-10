using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace mainapi.models
{
    public partial class CityTime
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("date_time")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("date_time_txt")]
        public string DateTimeTxt { get; set; }

        [JsonProperty("time_24")]
        public DateTimeOffset Time24 { get; set; }

        [JsonProperty("time_12")]
        public string Time12 { get; set; }



        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }

        [JsonProperty("dst_savings")]
        public long DstSavings { get; set; }
    }


}
