using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultReader
{
    class Question
    {
        public bool answered;
        public List<string> answers;
        public string question;
        public string question_word;
        public string correct_answer;
        public List<double> similarities;
        public string chosen_answer;
        public bool correct;
        public Question()
        {

        }
        public Question(string Parse)
        {
            similarities = new List<double>();
            answered = false;
            foreach (string line in Parse.Split('\n'))
            {

                string working_line = line.Replace('\t', ' ').Trim();
                if (working_line.StartsWith("Question:"))
                    question = working_line;
                if (working_line.StartsWith("Question word:"))
                    question_word = working_line.Split(' ')[2];
                if (working_line.StartsWith("Possibilities:"))
                    answers = parsePossiblities(line);
                if (working_line.StartsWith("Correct Answer:"))
                    correct_answer = working_line.Split(' ')[2];
                if (working_line.StartsWith("Chosen answer:"))
                    chosen_answer = working_line.Split(' ')[2];
                if (working_line == "CORRECT!")
                {
                    answered = true;
                    correct = true;
                }
                if (working_line == "WRONG!")
                {
                    answered = true;
                    correct = false;
                }
                if (working_line.StartsWith("sim("))
                    similarities.Add(double.Parse(working_line.Split('=')[1].Replace('.', ',')));

            }
        }
        List<string> parsePossiblities(string line)
        {
            string jp = line.Split(':')[1];
            string[] pos = jp.Split(',');
            for (int i = 0; i<pos.Length; i++)
            {
                pos[i] = pos[i].Trim(new char[] { ' ', '[', ']', '\'' });
            }
            return pos.ToList();
        }
    }
}
