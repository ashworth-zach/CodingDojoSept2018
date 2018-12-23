using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8= new Galaxy("s8",100,"Sprint","DING DING DINGADONGDINGDING");
            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Iphone x = new Iphone("x",5,"at&t","MARIMBA");
            x.DisplayInfo();
            Console.WriteLine(x.Ring());
            Console.WriteLine(x.Unlock());

        }
        public abstract class Phone
        {
            public string _versionNumber;
            public int _batteryPercentage;
            public string _carrier;
            public string _ringTone;
            public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            {
                _versionNumber = versionNumber;
                _batteryPercentage = batteryPercentage;
                _carrier = carrier;
                _ringTone = ringTone;
            }
            // abstract method. This method will be implemented by the subclasses
            public abstract void DisplayInfo();
            // public getters and setters removed for brevity. Please implement them yourself
        }
        interface IRingable
        {
            string Ring();
        }
        public class Iphone : Phone, IRingable
        {
            public Iphone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
               : base(versionNumber, batteryPercentage, carrier, ringTone) { }
            public string Ring()
            {
                Console.WriteLine(_ringTone);
                return _ringTone;
            }
            public string Unlock()
            {
                return "unlocked with facial recognition";
            }
            public override void DisplayInfo()
            {
                Console.WriteLine("Version: " + _versionNumber + " , battery percentage: " + _batteryPercentage + " , carrier: " + _carrier + " , ringtone: " + _ringTone);
            }
        }
        public class Galaxy : Phone, IRingable
        {
            public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
                : base(versionNumber, batteryPercentage, carrier, ringTone) { }
            public string Ring()
            {
                Console.WriteLine(_ringTone);
                return _ringTone;
            }

            public string Unlock()
            {
                return "unlocked with keypad";
            }
            public override void DisplayInfo()
            {
                Console.WriteLine("Version: " + _versionNumber + " , battery percentage: " + _batteryPercentage + " , carrier: " + _carrier + " , ringtone: " + _ringTone);
            }
        }


    }
}
