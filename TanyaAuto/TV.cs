using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class TV
    {
        public int CurrentChannel = 1; // Field - Поле
        public bool Mute;
        public int Volume = 15;
        private int _minChannel = 1;
        private int _maxChannel = 100;
        private int _minVolume = 10;
        private int _maxVolume = 20;

        public void NextChannel()
        {
            if (CurrentChannel < _maxChannel)
            {
                CurrentChannel += 1; // Current = Current + 1;
            }
            else
            {
                CurrentChannel = _minChannel;
            }
        }

        public void PrevChannel()
        {
            if (CurrentChannel > _minChannel)
            {
                CurrentChannel -= 1; // Current = Current - 1;
            }
            else
            {
                CurrentChannel = _maxChannel;
            }
        }

        public void SetChannel(int channel)
        {
            if (channel >= _minChannel && channel <= _maxChannel)
            {
                CurrentChannel = channel;
            }
            else
            {
                Console.WriteLine("Wrong channel."); // TODO Should not be there in real cases.
            }
        }

        public void SetMute()
        {
           // Mute = !Mute; // another way to do it SMART
            if (Mute == true)
            {
                Mute = false;
            }
            else
            {
                Mute = true;
            }
        }

        public void VolumeUp()
        {
            if (Volume < _maxVolume)
            {
                Volume = Volume + 1;
            }
        }

        public void VolumeDown()
        {
            if (Volume > _minVolume)
            {
                Volume = Volume - 1;
            }
        }
    }
}
