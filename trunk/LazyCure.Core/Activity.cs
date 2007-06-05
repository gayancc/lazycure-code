using System;
using System.Collections.Generic;
using System.Text;
using LifeIdea.LazyCure.Interfaces;

namespace LifeIdea.LazyCure.Core
{
    public class Activity:ActivityBase
    {
        public Activity(string name, DateTime start, TimeSpan duration)
        {
            this.name = name;
            this.start = start;
            this.duration = duration;
        }
    }

    public abstract class ActivityBase:IActivity
    {
        protected string name;
        protected TimeSpan duration;
        protected DateTime start;

        virtual public TimeSpan Duration { get { return duration; } set { duration = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime StartTime {get { return start; } set { start=value; } }
        public override string ToString()
        {
            string s = "<Records>" +
               "<Activity>"+Name+"</Activity>" + 
               "<Begin>"+Format.Time(StartTime)+"</Begin>"+
               "<Duration>"+Format.Duration(Duration)+"</Duration>"+
               "</Records>";
            return s;
        }
    }
}