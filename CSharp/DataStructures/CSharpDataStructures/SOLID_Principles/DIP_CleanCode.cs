using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructures.SOLID_Principles
{
    // Abstraction
    interface IScreen
    {
        void Display(string content);
    }

    // Low-level module 1
    class TheLEDTV : IScreen
    {
        public void Display(string content)
        {
            Console.WriteLine("Showing on LED TV: " + content);
        }
    }

    // Low-level module 2
    class Projector : IScreen
    {
        public void Display(string content)
        {
            Console.WriteLine("Showing on Projector: " + content);
        }
    }

    // High-level module
    class TheMovie
    {
        private IScreen screen;

        public TheMovie(IScreen screen) // Injecting abstraction — GOOD!
        {
            this.screen = screen;
        }

        public void Play()
        {
            screen.Display("Movie is playing");
        }
    }
}
