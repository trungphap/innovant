    
    using  Newtonsoft.Json;


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Accuracy
    {
        public double precision { get; set; }
        public double recall { get; set; }

        [JsonProperty("f1-score")]
        public double f1score { get; set; }
        public double support { get; set; }
    }

    public class Benign
    {
        public double precision { get; set; }
        public double recall { get; set; }

        [JsonProperty("f1-score")]
        public double f1score { get; set; }
        public double support { get; set; }
    }

    public class MacroAvg
    {
        public double precision { get; set; }
        public double recall { get; set; }

        [JsonProperty("f1-score")]
        public double f1score { get; set; }
        public double support { get; set; }
    }

    public class Malignant
    {
        public double precision { get; set; }
        public double recall { get; set; }

        [JsonProperty("f1-score")]
        public double f1score { get; set; }
        public double support { get; set; }
    }

    public class ClassificationReport
    {
        public Malignant malignant { get; set; }
        public Benign benign { get; set; }
        public Accuracy accuracy { get; set; }

        [JsonProperty("macro avg")]
        public MacroAvg macroavg { get; set; }

        [JsonProperty("weighted avg")]
        public WeightedAvg weightedavg { get; set; }

        public string ReportName { get; set; }
    }

    public class WeightedAvg
    {
        public double precision { get; set; }
        public double recall { get; set; }

        [JsonProperty("f1-score")]
        public double f1score { get; set; }
        public double support { get; set; }
    }


    public class Reports
    {
        public List<ClassificationReport> ClassificationReports { get; set; }
    }