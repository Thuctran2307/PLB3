﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace PBLLibrary
{
    public static class SoundConfig
    {
        public enum Voice
        {
            Male, Female
        }

        private static SpeechSynthesizer _Synthesizer = new SpeechSynthesizer();

        public static bool IsSpeaking = false;

        public static void Speak(string sentence)
        {
            _Synthesizer.Speak(sentence);
        }

        public static void ChangeVolumn(int volumn)
        {
            _Synthesizer.Volume = volumn;
        }

        public static void ChangeVoice(Voice voice)
        {
            string voiceString = "";
            switch (voice)
            {
                case Voice.Male:
                    voiceString = "Microsoft David Desktop";
                    break;
                case Voice.Female:
                    voiceString = "Microsoft Zira Desktop";
                    break;

            }

            _Synthesizer.SelectVoice(voiceString);
        }
    }
}
