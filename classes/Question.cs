using Sentence_Rating.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Rating.classes
{
    public class Question
    {
        public int q_type;
        public int id;
        public string question;
        public List<Answer> Answers { get; set; }

        public Question(int _qtype,string _question, List<Answer> _answers)
        {
            question = _question;
            q_type = _qtype;
            Answers = _answers;
        }

        public List<Answer> WrongAnswers()
        {
            return Answers.FindAll(i => i.isCorrect == false);
        }
        public Answer rightAnswer()
        {
            return (Answer)Answers.Find(i => i.isCorrect == true);
        }


         public override string ToString()
        {
            string wrong_answers = string.Join(",", WrongAnswers());
            return "1"+','+q_type+ ','+question+','+ rightAnswer().ToString() + ',' + wrong_answers;
        }
        
        public void store()
        {
            File.AppendAllText(@"..\..\data\gameData.txt", ToString()+Environment.NewLine);

        }
    }

    public class QuestionWithImage : Question
    {

        public Image image;
        public QuestionWithImage(int q_type, string question, Image _image, List<Answer> _answers) : base(q_type, question, _answers)
        {
            image = _image;
        }
    }
    
}

 