namespace DesignPatterns.Momento
{
    //Momento pattern is used to restore the state of an object to a previous state
    //behavioural pattern
    //used to implement undo functionality
    //used to implement rollback functionality
    //used to implement restore functionality
    //used to implement history functionality
    //used to implement snapshot functionality
    //used to implement checkpoint functionality
    //used to implement version control functionality
    //used to implement save functionality
    //used to implement recovery functionality
    //used to implement undo/redo functionality
    //used to implement transactional functionality
    //used to implement compensation functionality
    //used to implement rollback functionality
    //used to implement audit functionality
    //used to implement journal functionality
    //used to implement log functionality
    //used to implement state functionality
    //used to implement serialization functionality
    //used to implement deserialization functionality
    //used to implement serialization/deserialization functionality

    //do not expose the momento class to the client

    //major components: originator, momento, caretaker
    //originator: the object whose state needs to be saved
    //momento: the object that stores the state of the originator
    //caretaker: the object that is responsible for the safe keeping of the momento: it can save the momento, it can restore the momento, it can delete the momento, list the momento, etc.
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
        }

        public void SetState(string state)
        {
            this.state = state;
        }

        public Originator(string s)
        {
            state = s;
        }

        public Momento CreateMomento()
        {
            Momento momento = new Momento(state);
            return momento;
        }

        public void RestoreMomento(Momento momento)
        {
            state = momento.State;
        }
    }
}
