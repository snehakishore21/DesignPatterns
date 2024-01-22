namespace DesignPatterns.Momento
{
    public class Momento
    {
        private string state;

        public Momento(string s)
        {
            this.state = s;
        }

        public string State
        {
            get { return state; }
        }

        public void SetState(string state)
        {
            this.state = state;
        }
    }
}
