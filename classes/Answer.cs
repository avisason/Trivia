using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Rating.classes
{

 
    public class Answer
    {
        public bool isCorrect { get; set; }
        public string text_content;
        public Image image_content;
        public Answer(bool _isCorrect)
        {
            isCorrect = _isCorrect;
        }
        public Answer(bool _isCorrect, string _text_content)
        {
            text_content = _text_content;
            isCorrect = _isCorrect;
        }

        public override string ToString()
        {
            return text_content;
        }
    }
    public class AnswerWithImage:Answer
    {
        public Image image { get; set; }

        public AnswerWithImage(bool _isCorrect, string _text, Image _image):base(_isCorrect)
        {
            image = _image;
        }
    }
    public class AnswerWithText : Answer
    {
        public string text { get; set; }

        public AnswerWithText(bool _isCorrect, string _text) : base(_isCorrect)
        {
            text = _text;
        }
    }
}
