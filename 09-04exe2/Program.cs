using System;

namespace _09_04exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        interface Iplayable
        {
            void Play(); void Pause(); void stop();
        }
        
        interface IRecordable
        {
            void Record(); void Pause(); void stop();
        }
    }
}
