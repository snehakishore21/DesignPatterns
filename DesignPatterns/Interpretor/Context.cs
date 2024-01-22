namespace DesignPatterns.Interpretor
{
    public class Context
    {
        public Context(string input, string expression)
        {
            Input = input;
            Expression = expression;
        }

        public string Input { get; set; }
        public string Expression { get; set; }
    }
}
