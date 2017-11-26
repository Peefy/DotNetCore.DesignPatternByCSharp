
using System;

namespace VsCodeProOne.Patterns.MementoPattern
{
    public static class MementoPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("备忘录模式测试...");
            var originator = new Originator();
            var cakeTaker = new CareTaker();
            originator.State = "State #1";
            originator.State = "State #2";
            cakeTaker.Add(originator.SaveStateToMemento());
            originator.State = "State #3";
            cakeTaker.Add(originator.SaveStateToMemento());
            originator.State = "State #4";

            Console.WriteLine("Current State: " + originator.State);
            originator.GetStateFromMemento(cakeTaker.Get(0));
            Console.WriteLine("First Saved State: " + originator.State);
            originator.GetStateFromMemento(cakeTaker.Get(1));
            Console.WriteLine("Second saved State: " + originator.State);
            
            Console.WriteLine("");
        }
    }

}
