using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WFTestProject.Tree;

namespace WFTestProject
{
    public partial class Form1 : Form
    {
        List<RadioButton> multipleQuestion = new List<RadioButton>();
        TreeMethods cnObject;
        CallNumberNode answerLevel3;
        CallNumberTree treeObject;
        static CallNumberNode answerValue;
        bool check1 = true;
        int Level = 1;
        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
            cnObject = TreeMethods.GetInstance();
            treeObject = cnObject.GetTree();
        }

        private void GenButton_Click(object sender, EventArgs e)
        {

            CallNumberNode ranLevel3;



            if (Level == 1)
            {
                ranLevel3 = treeObject.Root.Children[ran.Next(0, 10)].Children[ran.Next(0, 10)].Children[ran.Next(0, 9)];
                answerLevel3 = ranLevel3;
                answerLabel.Text = answerLevel3.Num + " " + answerLevel3.Des;

                List<CallNumberNode> tempList = cnObject.genQuestion1(answerLevel3);

                List<CallNumberNode> level1List = tempList.OrderBy(x => ran.Next()).ToList();

                for (int i = 0; i < level1List.Count; ++i)
                {
                    ((RadioButton)MultiChoicePanel.Controls[i]).Text = level1List[i].Num + " " + level1List[i].Des;
                }

                Level++;
            }
            else if (Level == 2)
            {
                List<CallNumberNode> tempList = cnObject.genQuestion2(answerLevel3);

                List<CallNumberNode> level2List = tempList.OrderBy(x => ran.Next()).ToList();


                for (int i = 0; i < level2List.Count; ++i)
                {
                    ((RadioButton)MultiChoicePanel.Controls[i]).Text = level2List[i].Num + " " + level2List[i].Des;
                }

                Level++;
            }
            else
            {
                List<CallNumberNode> tempList = cnObject.genQuestion3(answerLevel3);

                List<CallNumberNode> level3List = tempList.OrderBy(x => ran.Next()).ToList();


                for (int i = 0; i < level3List.Count; ++i)
                {
                    ((RadioButton)MultiChoicePanel.Controls[i]).Text = level3List[i].Num + " " + level3List[i].Des;


                    Level = 1;
                }
            }

        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            string answer1 = answerLevel3.Num + " " + answerLevel3.Des;
            string answer2 = answerLevel3.Parent.Num + " " + answerLevel3.Parent.Des;
            string answer3 = answerLevel3.Parent.Parent.Num + " " + answerLevel3.Parent.Parent.Des;

            if (Level == 2)
            {
                foreach (RadioButton x in MultiChoicePanel.Controls)
                {
                    if (x.Checked == true)
                    {
                        if (x.Text == answer3)
                        {
                            MessageBox.Show("Correct");

                        }
                    }
                }
            }
            else if (Level == 3)
            {
                foreach (RadioButton x in MultiChoicePanel.Controls)
                {
                    if (x.Checked == true)
                    {
                        if (x.Text == answer2)
                        {
                            MessageBox.Show("Correct");

                        }
                    }
                }
            }
            else if (Level == 1)
            {
                foreach (RadioButton x in MultiChoicePanel.Controls)
                {
                    if (x.Checked == true)
                    {
                        if (x.Text == answer1)
                        {
                            MessageBox.Show("Correct");

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }
    }
}
