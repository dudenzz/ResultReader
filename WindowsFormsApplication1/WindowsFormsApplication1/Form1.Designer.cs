namespace ResultReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "toefl/cosine.txt",
            "TOEFL",
            "False",
            "False",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "toefl/wordnet_retro.txt",
            "TOEFL",
            "Wordnet",
            "False",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem(new string[] {
            "toefl/wordnet_retro_hubness.txt",
            "TOEFL",
            "Wordnet",
            "True",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "toefl/ppdb_retro.txt",
            "TOEFL",
            "ppdb",
            "False",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem(new string[] {
            "toefl/ppdb_retro_hubness.txt",
            "TOEFL",
            "ppdb",
            "True",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(new string[] {
            "esl/cosine.txt",
            "ESL",
            "False",
            "False",
            "False",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem(new string[] {
            "esl/wordnet_retro.txt",
            "ESL",
            "wordnet",
            "False",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem(new string[] {
            "esl/wordnet_retro_hubness.txt",
            "ESL",
            "wordnet",
            "True",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem(new string[] {
            "esl/ppdb_retro.txt",
            "ESL",
            "ppdb",
            "False",
            "False"}, -1);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "esl/ppdb_retro_hubness.txt",
            "ESL",
            "ppdb",
            "True",
            "False"}, -1);
            this.lv_files = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Questions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Retrofit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hubness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loaded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lb_results2 = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv_Answers = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChosenAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer1Sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer2Sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer3Sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer4Sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_results = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.btn_hybrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Answers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_files
            // 
            this.lv_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Questions,
            this.Retrofit,
            this.Hubness,
            this.Loaded});
            this.lv_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_files.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30});
            this.lv_files.Location = new System.Drawing.Point(0, 0);
            this.lv_files.Name = "lv_files";
            this.lv_files.Size = new System.Drawing.Size(554, 221);
            this.lv_files.TabIndex = 0;
            this.lv_files.UseCompatibleStateImageBehavior = false;
            this.lv_files.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 164;
            // 
            // Questions
            // 
            this.Questions.Text = "Questions Type";
            // 
            // Retrofit
            // 
            this.Retrofit.Text = "Retrofit";
            this.Retrofit.Width = 71;
            // 
            // Hubness
            // 
            this.Hubness.Text = "Hubness";
            // 
            // Loaded
            // 
            this.Loaded.Text = "Loaded";
            this.Loaded.Width = 126;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_hybrid);
            this.splitContainer1.Panel1.Controls.Add(this.lb_results2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_files);
            this.splitContainer1.Size = new System.Drawing.Size(836, 221);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 1;
            // 
            // lb_results2
            // 
            this.lb_results2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_results2.FormattingEnabled = true;
            this.lb_results2.Location = new System.Drawing.Point(0, 0);
            this.lb_results2.Name = "lb_results2";
            this.lb_results2.Size = new System.Drawing.Size(120, 221);
            this.lb_results2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_Answers);
            this.splitContainer2.Panel1.Controls.Add(this.lb_results);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(836, 450);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 2;
            // 
            // dgv_Answers
            // 
            this.dgv_Answers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Answers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Question,
            this.QuestionWord,
            this.CorrectAnswer,
            this.ChosenAnswer,
            this.Answer1,
            this.Answer2,
            this.Answer3,
            this.Answer4,
            this.Answer1Sim,
            this.Answer2Sim,
            this.Answer3Sim,
            this.Answer4Sim,
            this.Correct});
            this.dgv_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Answers.Location = new System.Drawing.Point(120, 24);
            this.dgv_Answers.Name = "dgv_Answers";
            this.dgv_Answers.Size = new System.Drawing.Size(716, 179);
            this.dgv_Answers.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            // 
            // QuestionWord
            // 
            this.QuestionWord.HeaderText = "Question Word";
            this.QuestionWord.Name = "QuestionWord";
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.HeaderText = "Correct Answer";
            this.CorrectAnswer.Name = "CorrectAnswer";
            // 
            // ChosenAnswer
            // 
            this.ChosenAnswer.HeaderText = "Chosen Answer";
            this.ChosenAnswer.Name = "ChosenAnswer";
            // 
            // Answer1
            // 
            this.Answer1.HeaderText = "Answer 1";
            this.Answer1.Name = "Answer1";
            // 
            // Answer2
            // 
            this.Answer2.HeaderText = "Answer 2";
            this.Answer2.Name = "Answer2";
            // 
            // Answer3
            // 
            this.Answer3.HeaderText = "Answer 3";
            this.Answer3.Name = "Answer3";
            // 
            // Answer4
            // 
            this.Answer4.HeaderText = "Answer 4";
            this.Answer4.Name = "Answer4";
            // 
            // Answer1Sim
            // 
            this.Answer1Sim.HeaderText = "Answer 1 Similarity";
            this.Answer1Sim.Name = "Answer1Sim";
            // 
            // Answer2Sim
            // 
            this.Answer2Sim.HeaderText = "Answer 2 Similarity";
            this.Answer2Sim.Name = "Answer2Sim";
            // 
            // Answer3Sim
            // 
            this.Answer3Sim.HeaderText = "Answer 3 Similarity";
            this.Answer3Sim.Name = "Answer3Sim";
            // 
            // Answer4Sim
            // 
            this.Answer4Sim.HeaderText = "Answer 4 Similarity";
            this.Answer4Sim.Name = "Answer4Sim";
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Correct";
            this.Correct.Name = "Correct";
            // 
            // lb_results
            // 
            this.lb_results.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_results.FormattingEnabled = true;
            this.lb_results.Location = new System.Drawing.Point(0, 24);
            this.lb_results.Name = "lb_results";
            this.lb_results.Size = new System.Drawing.Size(120, 179);
            this.lb_results.TabIndex = 3;
            this.lb_results.SelectedIndexChanged += new System.EventHandler(this.lb_results_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 203);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.fileToolStripMenuItem.Text = "Load Files";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 428);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(836, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // btn_hybrid
            // 
            this.btn_hybrid.Location = new System.Drawing.Point(127, 4);
            this.btn_hybrid.Name = "btn_hybrid";
            this.btn_hybrid.Size = new System.Drawing.Size(75, 23);
            this.btn_hybrid.TabIndex = 1;
            this.btn_hybrid.Text = "merge";
            this.btn_hybrid.UseVisualStyleBackColor = true;
            this.btn_hybrid.Click += new System.EventHandler(this.btn_hybrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(120, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(76, 160);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.splitContainer2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Answers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_files;
        private System.Windows.Forms.ColumnHeader Retrofit;
        private System.Windows.Forms.ColumnHeader Loaded;
        private System.Windows.Forms.ColumnHeader Questions;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Hubness;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ListBox lb_results;
        private System.Windows.Forms.DataGridView dgv_Answers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChosenAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer1Sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer2Sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer3Sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer4Sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correct;
        private System.Windows.Forms.ListBox lb_results2;
        private System.Windows.Forms.Button btn_hybrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

