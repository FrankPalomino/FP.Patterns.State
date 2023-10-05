namespace FP.Patterns.State
{
    public class ServerContext
    {
        private ServerState _state;

        public ServerState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Response()
        {
            _state.Response();
        }
    }
}
