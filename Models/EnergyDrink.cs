namespace WebsiteProject.Models
{
    public class EnergyDrink
    {   
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Flavor { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double CaffeineContent { get; set; }
        public string Ingredients { get; set; } = string.Empty;
        public string ServingSize { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int ClickCount { get; set; }
    }
} 
