using System.ComponentModel;

namespace SampleWeb.Models
{
    public class SampleViewModel
    {
        [DisplayName("Test")]
        public string Text { get; set; }
    }
}
