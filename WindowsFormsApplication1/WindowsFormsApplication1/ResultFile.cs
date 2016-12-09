using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ResultReader
{
    class ResultFile
    {
        public List<Question> questions;
        public List<string> source = new List<string>();
        public ResultFile(string filename)
        {
            questions = new List<Question>();
            string[] lines = File.ReadAllLines(filename);
            lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string QuestionString = "";
            foreach (string line in lines)
            {
               
                if ((line.Split(' ')[0] == "Question:" || line.Split(' ')[0] == "Total(flat):" ) && !string.IsNullOrEmpty(QuestionString))
                {
                    questions.Add(new Question(QuestionString));
                    QuestionString = "";
                }
                QuestionString += line + "\n";
            }
        }
        public int correct()
        {
            int c = 0;
            foreach(Question q in questions)
            {
                if (q.correct)
                    c++;
            }
            return c;
        }
        public ResultFile()
        {
            questions = new List<Question>();
        }
        public ResultFile merge(ResultFile r)
        {
            source = new List<string>();
            ResultFile ret = new ResultFile();
            foreach(Question q in questions)
            {
                foreach(Question q2 in r.questions)
                {
                    if (q.question == q2.question)
                    {
                        Question n = new Question();
                        n.question = q2.question;
                        n.question_word = q2.question_word;
                        n.correct_answer = q2.correct_answer;
                        n.answers = q2.answers;
                        n.answered = true;
                        n.similarities = new List<double>();
                        string[] ss = new string[4];
                        if (q.answered && q2.answered)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Math.Abs(q.similarities[i]) > Math.Abs(q2.similarities[i]))
                                {
                                    ss[i] = "1";
                                    n.similarities.Add(Math.Abs(q.similarities[i]));
                                }
                                else
                                {
                                    ss[i] = "2";
                                    n.similarities.Add(Math.Abs(q2.similarities[i]));
                                }
                            }
                            double max = -100;
                            int max_index = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (n.similarities[i] > max)
                                {
                                    max_index = i;
                                    max = n.similarities[i];
                                }
                            }
                            ret.source.Add(ss[max_index]);
                            n.chosen_answer = n.answers[max_index];
                            if (n.chosen_answer == n.correct_answer)
                                n.correct = true;
                            else
                                n.correct = false;
                        }
                        else
                        {
                            if (q.answered)
                            {
                                ret.source.Add("1");
                                n.similarities = q.similarities;
                                n.chosen_answer = q.chosen_answer;
                                n.correct = q.correct;
                            }
                            else
                            {
                                if (q2.answered)
                                {
                                    ret.source.Add("2");
                                    n.similarities = q2.similarities;
                                    n.chosen_answer = q2.chosen_answer;
                                    n.correct = q2.correct;
                                }
                                else
                                {
                                    ret.source.Add("NA");
                                    n.answered = false;
                                    n.similarities = new List<double>() { 0.0, 0.0, 0.0, 0.0 };
                                    n.correct = true;
                                    n.chosen_answer = "not answered";
                                }
                            }
                        }
                        ret.questions.Add(n);
                    }
                }
            }
            return ret;
        }
    }
}
