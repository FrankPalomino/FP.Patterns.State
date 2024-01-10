namespace FP.Patterns.State.Exercice2
{
    public class TrafficLight
    {
        private TrafficLightState _state;

        public TrafficLight()
        {
            _state = new RedState(this);
        }

        public void SetState(TrafficLightState state)
        {
            _state = state;
        }
        public void ChangeState()
        {
            _state.ChangeState();
        }

        public void CurrentState()
        {
            _state.DisplayState();
        }
    }
}
