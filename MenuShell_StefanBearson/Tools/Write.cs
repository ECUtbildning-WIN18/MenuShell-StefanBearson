using System;
using System.Speech.Synthesis;

namespace MenuShell_StefanBearson.Tools
{
    class Write
    {

        public static void WriteAt(int fromLeft, int fromTop, string text, bool speak)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            if (AccessibilitySpeak.wantSpeak && speak)
                synth.Speak(text);
            Console.SetCursorPosition(fromLeft, fromTop);
            Console.Write(text);
        }

        public static void WriteAt(int fromLeft, int fromTop, string text, ConsoleColor color, bool speak)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            if (AccessibilitySpeak.wantSpeak && speak)
                synth.Speak(text);
            Console.SetCursorPosition(fromLeft, fromTop);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void WriteAt(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void WriteAt(string text)
        {
            Console.Write(text);
        }
    }
}
