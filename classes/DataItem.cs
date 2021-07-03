namespace Sentence_Rating.forms
{
    public class DataItem
    {
       public int Id { set; get; }
       public string Topic { set; get; }
       public string Content { set; get; }

        public DataItem(int _id , string _topic, string _content)
        {
            Id = _id;
            Topic = _topic;
            Content = _content;
        }

        public override string ToString()
        {
            return Id + ',' + Topic + ',' + Content;
        }
    }
}