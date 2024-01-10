namespace FP.Patterns.State.Exercice2
{
    public class YellowState : TrafficLightState
    {
        public YellowState(TrafficLight light) : base(light) { }
        public override void ChangeState()
        {
            Console.WriteLine("Changing to Red Light");
            _trafficLight.SetState(new RedState(_trafficLight));
        }

        public override void DisplayState()
        {
            Console.WriteLine("This is Yellow Light");
        }
    }
}
