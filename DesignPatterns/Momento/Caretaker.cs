namespace DesignPatterns.Momento
{
    public class Caretaker
    {
        List<Momento> momentos = new List<Momento>();

        public void Add(Momento momento)
        {
            momentos.Add(momento);
        }

        public Momento? Undo()
        {
            if (momentos.Count == 0)
            { return null; }
            Momento momento = momentos[momentos.Count - 1];
            momentos.RemoveAt(momentos.Count - 1);
            return momento;
        }
    }
}
