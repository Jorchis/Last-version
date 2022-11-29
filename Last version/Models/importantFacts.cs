//importantFacts module

using System.ComponentModel.DataAnnotations;

namespace JWST_PWEB.Models
{
    public class importantFacts
    {
        public int Id { get; set; }
        public string? IFTitle { get; set; }
        public string? IFText { get; set; }
        public string pictureURL { get; set; }
        public string userID { get; set; }
    }
}