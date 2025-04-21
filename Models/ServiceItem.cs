using Microsoft.AspNetCore.Components;

namespace DavidTrmota.Models
{
    public class ServiceItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RenderFragment Icon { get; set; } = default!;
    }
}
