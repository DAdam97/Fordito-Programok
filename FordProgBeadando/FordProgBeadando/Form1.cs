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
                lbl_output.Text = Regex.Replace(tb_input.Text, "[0-9]+|[A-z]+", "i");
            }
            else
            {
                MessageBox.Show("Irjon be egy kifejezést.");
            }
        }

        bool isTableLoaded = false;

        private void Bt_openCsv_Click(object sender, EventArgs e)
        {
            try
            {
                openCsvFile.ShowDialog();

                dgv_ruleTable.DataSource = CsvReader.GetRules(openCsvFile.FileName);

                dgv_ruleTable.Font = new Font("Microsoft Sans Serif", 12);

                isTableLoaded = true;

                
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


            if (isAnalyzable && isTableLoaded)
            {
                Analyze(exp);
            }
            else
            {
                MessageBox.Show("Töltse be a táblát.");
            }
        }

        List<string> terminalSymbols = new List<string>();
        List<string> ruleNumeber = new List<string>();
        Stack<string> rules = new Stack<string>();

        int index = 0;

        private void Analyze(string expression)
        {
            ResetEverything();

            InitTerminalSymbols(expression);
            InitRuleStack();
            try
            {
                while (!(rules.Peek() == "#" && terminalSymbols[0] == "#"))
                {
                    string terminal = terminalSymbols[0];
                    int symbolIndex = getTerminalSymbolIndex(terminal);

                    string noneTerminal = rules.Peek();
                    int ruleIndex = getRuleIndex(noneTerminal);

                    string cellData = getCellRule(symbolIndex, ruleIndex);
                    ProcessCell(cellData);

                    ListBoxDataRow dataRow = new ListBoxDataRow(CollectionToString(terminalSymbols),
                                                                CollectionToString(rules),
                                                                CollectionToString(ruleNumeber));

                    lb_steps.Items.Add(dataRow.ToString());
                }
                MessageBox.Show("Helyes a kifejezés!");
            }
            catch (WrongInputException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (TerminalSymbolNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
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

            throw new TerminalSymbolNotFoundException(String.Format($"HIBA: Nem létező termináls szimbólum a kifejezésben: {symb}"));
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
            string cell = (string)dgv_ruleTable.Rows[ruleIndex].Cells[symbolIndex].Value;

            if (cell == "") { throw new WrongInputException(String.Format($"HIBA: {terminalSymbols[0]} és {rules.Peek()} Alkalmazásánál.")); }

            return cell;
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

        private string CollectionToString(IEnumerable<string> collection)
        {
            string temp = "";

            foreach (var c in collection)
            {
                temp += c;
            }

            return temp;
        }

        private void ProcessCell(string cellData)
        {
            string[] temp = cellData.Split(';');

            switch (temp[0])
            {
                case "pop":
                    rules.Pop();
                    terminalSymbols.RemoveAt(0);
                    break;

                case "eps":
                    rules.Pop();
                    ruleNumeber.Add(temp[1]);
                    break;

                case "":
                    break;

                case "accept":
                    break;

                default:
                    AddRuleAndRuleNum(temp[0], temp[1]);
                    break;
            }
        }

        public void AddRuleAndRuleNum(string rule, string number)
        {
            ruleNumeber.Add(number);
            rules.Pop();

            for (int i = rule.Length - 1; i >= 0; i--)
            {
                rules.Push(rule[i].ToString());
            }
        }

        public void ResetEverything()
        {
            lb_steps.Items.Clear();
            terminalSymbols.Clear();
            rules.Clear();
            ruleNumeber.Clear();
        }

        bool isAnalyzable = false;
        string exp = "";

        private void bt_StepAnalyze_Click(object sender, EventArgs e)
        {
            if (!isAnalyzable)
            {
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
            }

            if (isAnalyzable && isTableLoaded)
            {
                AnalyzeStepByStep(exp);
            }
            else
            {
                MessageBox.Show("Töltse be a táblát.");
            }
        }

        bool isAnalyzeBegan = false;
        bool isFinished = false;

        private void AnalyzeStepByStep(string expression)
        {
            if (!isAnalyzeBegan)
            {
                ResetEverything();

                InitTerminalSymbols(expression);
                InitRuleStack();
                isAnalyzeBegan = true;
            }

            try
            {
                if (!isFinished)
                {
                    string terminal = terminalSymbols[0];
                    int symbolIndex = getTerminalSymbolIndex(terminal);

                    string noneTerminal = rules.Peek();
                    int ruleIndex = getRuleIndex(noneTerminal);

                    string cellData = getCellRule(symbolIndex, ruleIndex);
                    ProcessCell(cellData);

                    ListBoxDataRow dataRow = new ListBoxDataRow(CollectionToString(terminalSymbols),
                                                                CollectionToString(rules),
                                                                CollectionToString(ruleNumeber));

                    lb_steps.Items.Add(dataRow.ToString());
                    isFinished = rules.Peek() == "#" && terminalSymbols[0] == "#";
                }
                else
                {
                    isAnalyzeBegan = false;
                    isFinished = false;
                    isAnalyzable = false;
                    MessageBox.Show("Helyes a kifejezés!");
                }
            }
            catch (WrongInputException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (TerminalSymbolNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
