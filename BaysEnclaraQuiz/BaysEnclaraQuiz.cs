using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BaysEnclaraQuiz
{
    public partial class BaysEnclaraQuiz : Form
    {

        List<string> ParagraphWordList { get; set; }
        List<string> ParagraphSentenceList { get; set; }
        List<string> DistinctWordList = new List<string>();
        List<int> SentencesThatContainDistinctWordList = new List<int>();
        int distinctWordCount { get; set; }

        public BaysEnclaraQuiz()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {   
            GetDistinctWordResults();
        }

        private void SplitInputParagraph()
        {
            string paragraph = rtbParagraphInput.Text.ToLower();
            string paragraphTrimmed = Regex.Replace(paragraph, @"[—,'.]", " ");
            string[] paragraphWords = paragraphTrimmed.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            ParagraphWordList = new List<string>(paragraphWords);

            string[] paragraphSentences = paragraph.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            ParagraphSentenceList = new List<string>(paragraphSentences);
        }

        private void GetDistinctWords()
        {
            var distinctWords = ParagraphWordList.OrderBy(d => d).Select(d => d).Distinct();
            foreach (var word in distinctWords)
            {
                DistinctWordList.Add(word);
            }
        }

        private int GetDistinctWordCount(string word)
        {
            distinctWordCount = ParagraphWordList.Count(w => w == word);
            return distinctWordCount;
        }
       
        private void GetDistinctWordSentences(string word)
        {
           SentencesThatContainDistinctWordList.Clear();
           int paragraphSentenceCount = 0;
            
           foreach (string sentence in ParagraphSentenceList)
            {
                paragraphSentenceCount++;
                var distinctWordSearch = @"\b" + Regex.Escape(word) + @"\b";
                if (Regex.IsMatch(sentence,distinctWordSearch))
                {
                    SentencesThatContainDistinctWordList.Add(paragraphSentenceCount);
                }
            }
        }
        private void GetDistinctWordResults()
        {
            SplitInputParagraph();
            GetDistinctWords();
            foreach (var word in DistinctWordList)
            {
                GetDistinctWordCount(word);
                GetDistinctWordSentences(word);
                rtbResults.AppendText($"{Environment.NewLine}Word: {word}  Word Count:  {distinctWordCount}  Sentence(s) Containing Word: {String.Join(",", SentencesThatContainDistinctWordList)}");
            }
        }
}
}