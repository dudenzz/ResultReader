using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, ResultFile> resultFiles;

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultFiles = new Dictionary<string, ResultFile>();
            lb_results.Items.Clear();
            foreach (ListViewItem item in lv_files.Items)
            {
                ResultFile r = new ResultFile(item.Text);
                resultFiles.Add(item.Text, r);
                lb_results.Items.Add(item.Text);
                lb_results2.Items.Add(item.Text);
                item.SubItems[4] = new ListViewItem.ListViewSubItem(lv_files.Items[item.Text], "True");
            }
        }

        private void lb_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultFile r = resultFiles[lb_results.SelectedItem.ToString()];
            dgv_Answers.Rows.Clear();
            dgv_Answers.Refresh();
            int iter = 0;
            foreach (Question q in r.questions)
            {
                iter++;
                if (q.answered)
                    dgv_Answers.Rows.Add(new object[] { iter, q.question, q.question_word, q.correct_answer, q.chosen_answer, q.answers[0], q.answers[1], q.answers[2], q.answers[3], q.similarities[0], q.similarities[1], q.similarities[2], q.similarities[3], q.correct });
                else
                    dgv_Answers.Rows.Add(new object[] { iter, q.question, q.question_word, q.correct_answer, "NA", q.answers[0], q.answers[1], q.answers[2], q.answers[3], 0.0, 0.0, 0.0, 0.0, true });
            }
            label1.Text = r.correct().ToString();
        }

        private void btn_hybrid_Click(object sender, EventArgs e)
        {
            ResultFile r1 = resultFiles[lb_results.SelectedItem.ToString()];
            ResultFile r2 = resultFiles[lb_results2.SelectedItem.ToString()];
            ResultFile r = r1.merge(r2);
            dgv_Answers.Rows.Clear();
            dgv_Answers.Refresh();
            int iter = 0;
            foreach (Question q in r.questions)
            {
                iter++;
                if (q.answered)
                    dgv_Answers.Rows.Add(new object[] { iter, q.question, q.question_word, q.correct_answer, q.chosen_answer, q.answers[0], q.answers[1], q.answers[2], q.answers[3], q.similarities[0], q.similarities[1], q.similarities[2], q.similarities[3], q.correct });
                else
                    dgv_Answers.Rows.Add(new object[] { iter, q.question, q.question_word, q.correct_answer, "NA", q.answers[0], q.answers[1], q.answers[2], q.answers[3], 0.0, 0.0, 0.0, 0.0, true });
            }
            label1.Text = r.correct().ToString();
            listBox1.Items.Clear();
            int i = 1;
            foreach (string s in r.source)
            {
                listBox1.Items.Add(i.ToString() + " " + s);
                i++;
            }
        }
    }
}
