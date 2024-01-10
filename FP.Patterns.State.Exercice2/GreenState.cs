namespace FP.Patterns.State.Exercice2
{
    public class GreenState : TrafficLightState
    {
        public GreenState(TrafficLight light) : base(light) { }
        public override void ChangeState()
        {
            Console.WriteLine("Changing to Yellow Light");
            _trafficLight.SetState(new YellowState(_trafficLight));
        }

        public override void DisplayState()
        {
            Console.WriteLine("This is Green Light");
        }
    }
}
