using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordProgBeadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_acceptInput_Click(object sender, EventArgs e)
        {
            if (tb_input.Text.Length > 0)
            {
                lbl_output.Text = Regex.Replace(tb_input.Text, "[0-9]+", "i");
            }
            else
            {
                MessageBox.Show("Irjon be egy kifejezést.");
            }
        }

        private void Bt_openCsv_Click(object sender, EventArgs e)
        {
            try
            {
                openCsvFile.ShowDialog();

                dgv_ruleTable.DataSource = CsvReader.GetRules(openCsvFile.FileName);

                dgv_ruleTable.Font = new Font("Microsoft Sans Serif", 12);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Válasza ki a megfelelő csv filet.");                
            }
           
        }

        private void Bt_Analyze_Click(object sender, EventArgs e)
        {
            bool isAnalyzable = false;
            string exp = "";

            if (lbl_output.Text != "output")
            {
                if (lbl_output.Text.Substring(lbl_output.Text.Length - 1, 1) == "#")
                {
                    exp = lbl_output.Text;
                    isAnalyzable = true;
                }
                else
                {
                    exp = lbl_output.Text + '#';
                    isAnalyzable = true;
                }
            }
            else
            {
                MessageBox.Show("Irjon be egy kifejezést.");
            }



            if (isAnalyzable)
            {
                Analyze(exp);
            }
        }

        List<string> terminalSymbols = new List<string>();
        List<string> ruleNumeber = new List<string>();
        Stack<string> rules = new Stack<string>();

        int index = 0;

        private void Analyze(string expression)
        {
            InitTerminalSymbols(expression);
            InitRuleStack();

            string terminal = terminalSymbols[0];
            int symbolIndex = getTerminalSymbolIndex(terminal);

            string noneTerminal = rules.Pop();
            int ruleIndex = getRuleIndex(noneTerminal);

            string rule = getCellRule(symbolIndex, ruleIndex);

            string[] ruleAndRuleNum = rule.Split(';');

            
        }


        private int getTerminalSymbolIndex(string symb)
        {
            for (int i = 0; i < dgv_ruleTable.Columns.Count; i++)
            {
                if (dgv_ruleTable.Columns[i].HeaderText == symb)
                {
                    return i;
                }
            }

            throw new TerminalSymbolNotFoundException();
        }

        private int getRuleIndex(string rule)
        {
            for (int i = 0; i < dgv_ruleTable.Rows.Count; i++)
            {
                if (dgv_ruleTable.Rows[i].Cells[0].Value.ToString() == rule)
                {
                    return i;
                }
            }

            throw new RuleNotFoundException();
        }

        private string getCellRule(int symbolIndex, int ruleIndex)
        {
            return (string)dgv_ruleTable.Rows[ruleIndex].Cells[symbolIndex].Value;
        }

        private void InitRuleStack()
        {
            rules.Push("#");
            rules.Push("E");
        }

        private void InitTerminalSymbols(string exp)
        {
            foreach (var c in exp)
            {
                terminalSymbols.Add(c.ToString());
            }
        }


        // TODO: ezt megoldani (lisát vermet foreachel bejárni és vissza adni stringbe)
        /*
        private string CollectionToString(object collection)
        {
            string temp = "";

            foreach (var c in collection)
            {
                temp += c;
            }

            return temp;
        }
        */

    }
}
