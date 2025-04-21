using Microsoft.AspNetCore.Components;

namespace DavidTrmota.Models
{
    public class ContactInfoItem
    {
        public string Label { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string Href { get; set; } = string.Empty;
        public RenderFragment? Icon { get; set; }
    }
}
