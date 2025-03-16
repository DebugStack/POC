namespace CSharpDataStructures.SOLID_Principles
{
    /*
        Movie class is tightly coupled to LEDTV.
	    If we want to change to a Projector, we must modify Movie class — that’s bad design.
     */
    class LEDTV
    {
        public void Display(string content)
        {
            Console.WriteLine("Showing on LED TV: " + content);
        }
    }

    class Movie
    {
        private LEDTV tv;

        public Movie()
        {
            tv = new LEDTV(); // Direct dependency — BAD!
        }

        public void Play()
        {
            tv.Display("Movie is playing");
        }
    }
}
