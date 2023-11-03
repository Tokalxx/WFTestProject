using System;
using System.Collections.Generic;
using System.IO;

namespace WFTestProject.Tree
{
    internal class TreeMethods
    {
        private static readonly TreeMethods _instance = new TreeMethods();
        string filePath = "C:\\Users\\tokal\\Documents\\BCAD\\Year 3\\Seme 2\\PROG7312\\Assignments\\PROG7312 Part 3\\WFTestProject\\WFTestProject\\TextFile\\TextFile1.txt";
        CallNumberTree cnt = new CallNumberTree(new CallNumberNode("0", ".", null));
        Random ran1 = new Random();



        private TreeMethods()
        {
            genTree(filePath, cnt);
        }

        public static TreeMethods GetInstance()
        {
            return _instance;
        }

        public CallNumberTree GetTree()
        {
            return cnt;
        }


        public List<CallNumberNode> genQuestion1(CallNumberNode node)
        {
            int level1 = Convert.ToInt32(node.Parent.Parent.Num.Substring(0, 1));
            CallNumberNode tempCallNum = cnt.Root.Children[level1];
            List<CallNumberNode> tempList = new List<CallNumberNode>();
            tempList.Add(tempCallNum);

            for (int i = 0; i < 3; ++i)
            {
                CallNumberNode tempAddValue = cnt.Root.Children[ran1.Next(0, 10)];
                if (tempAddValue != tempCallNum && !tempList.Contains(tempAddValue))
                {
                    tempList.Add(tempAddValue);
                }
                else
                {
                    --i;
                }
            }
            return tempList;
        }

        public List<CallNumberNode> genQuestion2(CallNumberNode node)
        {
            int level1 = Convert.ToInt32(node.Parent.Parent.Num.Substring(0, 1));
            int level2 = Convert.ToInt32(node.Parent.Num.Substring(1, 1));
            CallNumberNode tempCallNum = cnt.Root.Children[level1].Children[level2];
            List<CallNumberNode> tempList = new List<CallNumberNode>();
            tempList.Add(tempCallNum);

            for (int i = 0; i < 3; ++i)
            {
                CallNumberNode tempAddValue = cnt.Root.Children[level1].Children[ran1.Next(0, 9)];
                if (tempAddValue != tempCallNum && !tempList.Contains(tempAddValue))
                {
                    tempList.Add(tempAddValue);
                }
                else
                {
                    --i;
                }
            }
            return tempList;
        }

        public List<CallNumberNode> genQuestion3(CallNumberNode node)
        {
            int level1 = Convert.ToInt32(node.Parent.Parent.Num.Substring(0, 1));
            int level2 = Convert.ToInt32(node.Parent.Num.Substring(1, 1));
            int level3 = Convert.ToInt32(node.Num.Substring(2, 1));
            List<CallNumberNode> tempList = new List<CallNumberNode>();
            tempList.Add(node);

            for (int i = 0; i < 3; ++i)
            {
                CallNumberNode tempAddValue = cnt.Root.Children[level1].Children[level2].Children[ran1.Next(1, 9)];
                if (tempAddValue != node && !tempList.Contains(tempAddValue))
                {
                    tempList.Add(tempAddValue);
                }
                else
                {
                    --i;
                }
            }
            return tempList;
        }

        public static void genTree(string filePath, CallNumberTree tr)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subline;
                while ((line = reader.ReadLine()) != null)
                {
                    int level1 = 0;
                    int level2 = 0;

                    if (line.Contains(" - "))
                    {
                        subline = line.Split(new[] { '-' }, 2);
                        tr.Root.addNode(subline[0], subline[1]);
                    }
                    else
                    {
                        subline = line.Split(new[] { ',' }, 2);
                        level1 = Convert.ToInt32(subline[0].Substring(0, 1));
                        int callNumber = Convert.ToInt32(subline[0]);

                        if (callNumber % 10 == 0)
                        {
                            tr.Root.Children[level1].addNode(subline[0], subline[1]);
                        }
                        else
                        {
                            level2 = Convert.ToInt32(subline[0].Substring(1, 1));

                            tr.Root.Children[level1].Children[level2].addNode(subline[0], subline[1]);
                        }
                    }
                }

            }
        }


    }
}
