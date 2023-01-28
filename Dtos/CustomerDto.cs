using System.Text.Json.Serialization;

namespace ESFCustomersData.Dtos
{
    public class CustomerDto
    {
        [JsonPropertyName("Κωδικος")]
        public string CustomerCode { get; set; }
        [JsonPropertyName("Ονομα")]
        public string CustomerName { get; set; }
        [JsonPropertyName("ΑΦΜ")]
        public string Afm { get; set; }
        [JsonPropertyName("Τηλεφωνο 1")]
        public string Phone1 { get; set; }
        [JsonPropertyName("Τηλεφωνο 2")]
        public string Phone2 { get; set; }
        [JsonPropertyName("Συμβασεις")]
        public string Symvaseis { get; set; }
        [JsonPropertyName("Συμβαση Εταιριας")]
        public string SymvasiEtairias { get; set; }
        [JsonPropertyName("Συμβαση Epsilon")]
        public string SymvasiEpsilon { get; set; }
        [JsonPropertyName("Συμβαση Cloud")]
        public string CloudHosting { get; set; }
        [JsonPropertyName("Τελευταια Συμβαση Εταιριας")]
        public string LastSaleDateSymvasiEtairias { get; set; }
        [JsonPropertyName("Τελευταια Συμβαση Epsilon")]
        public string LastSaleDateSymvasiEpsilon { get; set; }
        [JsonPropertyName("Τελευταια Συμβαση Cloud")]
        public string LastSaleDateCloudHosting { get; set; }
        [JsonPropertyName("Τιμη Συμβασης Εταιριας")]
        public decimal PriceSymvasiEtairias { get; set; }
        [JsonPropertyName("Τιμη Συμβασης Epsilon")]
        public decimal PriceSymvasiEpsilon { get; set; }
        [JsonPropertyName("Τιμη Συμβασης Cloud")]
        public decimal PriceCloudHosting { get; set; }
        [JsonPropertyName("Εκτπωση Συμβασης Εταιριας")]
        public decimal DiscountPriceSymvasiEtairias { get; set; }
        [JsonPropertyName("Εκτπωση Συμβασης Epsilon")]
        public decimal DiscountPriceSymvasiEpsilon { get; set; }
        [JsonPropertyName("Εκτπωση Συμβασης Cloud")]
        public decimal DiscountPriceCloudHosting { get; set; }
        [JsonPropertyName("Διαρκεια Συμβολαιου Εταιριας Σε Μηνες")]
        public int DurationOfSymvasiEtairias { get; set; }
        [JsonPropertyName("Διαρκεια Συμβολαιου Epsilon Σε Μηνες")]
        public int DurationOfSymvasiEpsilon { get; set; }
        [JsonPropertyName("Διαρκεια Συμβολαιου Cloud Σε Μηνες")]
        public int DurationOfCloudHosting { get; set; }
        public string DateSymvasiEtairias { get; set; }
        public string DateSymvasiEpsilon { get; set; }
        public string DateCloudHosting { get; set; }
        public decimal FpriceSymvasiEtairias { get; set; }
        public decimal FpriceSymvasiEpsilon { get; set; }
        public decimal FpriceCloudHosting { get; set; }
        public int TDurationOfSymvasiEtairias { get; set; }
        public int TDurationOfSymvasiEpsilon { get; set; }
        public int TDurationOfCloudHosting { get; set; }
        public string FpistOfSymvasiEtairias { get; set; }
        public string FpistOfSymvasiEpsilon { get; set; }
        public string FpistOfCloudHosting { get; set; }

    }
}
