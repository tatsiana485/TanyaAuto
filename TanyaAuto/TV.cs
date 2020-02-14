using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class TV
    {
        public int CurrentChannel; // Field - Поле
        private int _minChannel = 1;
        private int _maxChannel = 100;

        public void NextChannel()
        {
            if (CurrentChannel <= _maxChannel)
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
            if (CurrentChannel >= _minChannel)
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
    }
}
