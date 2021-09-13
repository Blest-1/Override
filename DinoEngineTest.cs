using System;
namespace Method.Override
{
    public class DinoEngineTest:Engines
    {
        public override void Engine()
        {
            base.Engine();
            Console.WriteLine("Dino Test Engine.");
        }
    }
}
