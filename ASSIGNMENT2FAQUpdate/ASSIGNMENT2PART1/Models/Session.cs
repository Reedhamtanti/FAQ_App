namespace ASSIGNMENT2PART1.Models
{
    public class Session
    {
       
        private const string CategoryKey = "category";
        private const string TopicKey = "topic";

        private ISession session { get; set; }
        public Session(ISession session)
        {
            this.session = session;
        }

        public void SetActiveConfiguration(string category) => session.SetString(CategoryKey, category);
        public string GetActiveConfiguration() => session.GetString(CategoryKey);

        public void SetActiveDivision(string topic) => session.SetString(TopicKey, topic);
        public string GetActiveDivision() => session.GetString(TopicKey);

      
    }

}

