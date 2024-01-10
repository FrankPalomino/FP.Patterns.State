namespace FP.Patterns.State.Exercice2
{
    public abstract class TrafficLightState
    {
        protected TrafficLight _trafficLight;
        protected TrafficLightState(TrafficLight light)
        {
            _trafficLight = light;
        }
        public abstract void ChangeState();
        public abstract void DisplayState();
    }
}
