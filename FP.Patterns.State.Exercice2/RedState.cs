namespace FP.Patterns.State.Exercice2
{
    public class RedState : TrafficLightState
    {
        public RedState(TrafficLight light): base(light) { }

        public override void ChangeState()
        {
            Console.WriteLine("Changing to Green Light");
            _trafficLight.SetState(new GreenState(_trafficLight));
        }

        public override void DisplayState()
        {
            Console.WriteLine("This is Red Light");
        }
    }
}
