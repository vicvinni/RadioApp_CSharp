using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1; 
        private bool _on = false;

        //getter and setter for the properties
        public int Channel {
            get { return _channel;  }
            set {
                if (value <= 4 && value >= 1 && _on)
                {
                    _channel = value; 
                }
            }
        }

        //empty/default Constructor
        public Radio() { }

        public Radio(bool ON, int Channel)
        {
            _on = ON;
            _channel = Channel; 
        }

        //methods
        public string Play()
        {
            if (!_on)
            {
                return $"Radio is off";
            }
            else {
                return $"Playing channel {Channel}";
            }
        }

        public void TurnOn()
        {
            _on = true; 
        }

        public void TurnOff()
        {
            _on = false;
        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}