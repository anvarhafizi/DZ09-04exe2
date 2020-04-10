using System;

namespace _09_04exe2
{
    class Program
    {
        static void Main(string[] args)
        {
           Player pl=new Player();
           pl.Play();
           (pl as IPlayable).Stop();
           pl.Record();
           (pl as IRecodable).Stop();
           Console.ReadKey();
        }
    }
    interface IPlayable 
    {
        void Play();  void Pause(); void Stop();
    }
    interface IRecodable
    {
        void Record();  void Pause(); void Stop();
    }
    public class Player: IPlayable, IRecodable
    {
        public void Play() => Console.WriteLine("Play the music!");
        public void Pause() => Console.WriteLine("Pause the music!");
        public void Stop() => Console.WriteLine("Stop the music!");
        public void Record() => Console.WriteLine("Record the music!");

    }
}