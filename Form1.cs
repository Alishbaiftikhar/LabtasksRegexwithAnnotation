using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab2task2RegexwithAnnotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            // take input from a richtextbox/textbox 

            String var = richTextBox1.Text;

            // split the input on the basis of space

            String[] words = var.Split(' ');

            // Regular Expression for operators

            Regex arithmetic = new Regex(@"^[+|\-|*|/]$");
            Regex digits = new Regex(@"^[0-9]{1,}$");
            Regex relational = new Regex(@"^[<=|>=|!=|==]{2}|[<|>]$");
            Regex assignment = new Regex(@"^[+=,\-=]{2}|[=]$");
            Regex equal = new Regex(@"^[=]");
            Regex logical = new Regex(@"^[&&,\|\|]$");
            Regex floating= new Regex(@"^[(\d+)?\.\d+]{0,7}$");
            Regex power = new Regex(@"^[0-9][0-9]*(([\.][0-9][0-9])?([e][+|-]?[0-9][0-9]*))$");
            Regex tm = new Regex(@"^[t|T][m|M][A-Za-z]*$");
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            int count8 = 0;


            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = arithmetic.Match(words[i]);
                Match match2 = digits.Match(words[i]);
                Match match3 = relational.Match(words[i]);
                Match match4 =assignment.Match(words[i]);
                Match match5 = equal.Match(words[i]);
                Match match6 = logical.Match(words[i]);
                Match match7 = floating.Match(words[i]);
                Match match8 = power.Match(words[i]);
                Match match9 = tm.Match(words[i]);

                if (match1.Success)
                {
                    if (words[i].Equals("+"))
                    {
                        count1 = count1+1;
                        Console.WriteLine(count1);
                        dataGridView1.Rows.Add(words[i], "arithmetic operator", count1);
                    }
                    else if (words[i].Equals('-'))
                    {
                        count2 = count2++;
                        dataGridView1.Rows.Add(words[i], "arithmetic operator", "0", count2);
                    }
                    else if (words[i].Equals('*'))
                    {
                        count3 = count3++;
                        dataGridView1.Rows.Add(words[i], "arithmetic operator", "0", "0",count3);
                    }
                    else if (words[i].Equals('/'))
                    {
                        count4 = count4++;
                        dataGridView1.Rows.Add(words[i], "arithmetic operator", "0", "0", "0",count4);
                    }

                }
                else if (match8.Success)
                {
                    dataGridView1.Rows.Add(words[i], "power");
                }
                else if (match2.Success)
                {
                    count5 = count5++;
                    dataGridView1.Rows.Add(words[i], "digit","0","0","0","0",count5);
                    

                }
                else if (match3.Success)
                {
                    dataGridView1.Rows.Add(words[i], "Relational");
                }
                else if (match4.Success)
                {

                    //dataGridView1.Rows.Add(words[i], "assignment operator");
                    if (words[i].Equals("+="))
                    {
                        count6 = count6 + 1;
                        dataGridView1.Rows.Add(words[i], "assignment operator", "0", "0", "0", "0","0",count6);
                    }
                   else if (words[i].Equals("-="))
                    {
                        count7 = count7 + 1;
                        dataGridView1.Rows.Add(words[i], "assignment operator", "0", "0", "0", "0", "0", "0",count7);
                    }
                    else if (words[i].Equals("="))
                    {
                        count8 = count8 + 1;
                        dataGridView1.Rows.Add(words[i], "assignment operator", "0", "0", "0", "0", "0", "0","0", count8);
                    }


                }

                else if (match5.Success)
                {
                    dataGridView1.Rows.Add(words[i], "assignment operator");
                }
                else if (match6.Success)
                {
                    dataGridView1.Rows.Add(words[i], "logical operator");
                }
                else if (match7.Success)
                {
                    dataGridView1.Rows.Add(words[i], "floating point");
                }
                else if (match8.Success)
                {
                    dataGridView1.Rows.Add(words[i], "power");
                }
                else if (match9.Success)
                {
                    dataGridView1.Rows.Add(words[i], "tm starting words");
                }

                else
                {
                    MessageBox.Show("invalid " + words[i]);
                }



            }
        }
    }
}

    
