using Sentence_Rating.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Rating
{
    public class DataItemWithImage : DataItem
    {
        public string image {set;get;}


        public DataItemWithImage(int _id, string _topic, string _content, string _img):base(_id, _topic,  _content)
        {
            image = _img;
        }

    }
}
