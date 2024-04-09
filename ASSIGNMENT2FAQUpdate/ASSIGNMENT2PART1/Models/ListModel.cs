namespace ASSIGNMENT2PART1.Models
{
    public class ListModel : Model
    {
        public List<FAQs> FAQs { get; set; }

        private List<Topic> topics;
       
        public List<Topic> Topics
        {
            get => topics;
            set
            {
                topics = new List<Topic> {
                    new Topic { Url = "all", Name = "All FAQs" }
                };
                topics.AddRange(value);
            }
        }

        private List<Category> categories;

        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = new List<Category> { new Category { Url="all", Name="All category" } };
                categories.AddRange(value);
            }
        }

        // set active link
        public string CheckActiveConfig(string c) =>
            c.ToLower() == ActiveConfiguration.ToLower() ? "active" : "";
        public string CheckActiveDivision(string d) =>
            d.ToLower() == ActiveDivision.ToLower() ? "active" : "";
    }
}

