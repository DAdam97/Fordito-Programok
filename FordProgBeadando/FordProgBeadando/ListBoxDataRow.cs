using System;

namespace FordProgBeadando
{
    class ListBoxDataRow
    {
        private string expression;

        public string Expression
        {
            get { return expression; }
            set { expression = value; }
        }

        private string rules;

        public string Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        private string numbers;

        public string Numbers
        {
            get { return numbers; }
            set { numbers = value; }            
        }

        public override string ToString()
        {
            return String.Format($"< {expression}, {rules}, {numbers} >");
        }

        public ListBoxDataRow(string exp, string rules, string numbers)
        {
            this.Expression = exp;
            this.Rules = rules;
            this.Numbers = numbers;
        }
    }
}
