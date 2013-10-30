using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GameEngine
{
    public class InputManager
    {
        private byte[] keys = new byte[256];
        private Dictionary<string, Keys> keyMap = new Dictionary<string, Keys>();
        private Dictionary<string, bool> previousStates = new Dictionary<string, bool>();
        private Dictionary<string, bool> currentStates = new Dictionary<string, bool>();

        public void AddActionKey(string action, Keys key)
        {
            keyMap.Add(action, key);
            previousStates[action] = false;
            currentStates[action] = false;
        }

        public bool IsActionPressed(string action)
        {
            return currentStates[action];
        }

        public bool IsActionUp(string action)
        {
            return !IsActionPressed(action);
        }

        public bool IsActionJustPressed(string action)
        {
            return IsActionPressed(action) && !previousStates[action];
        }

        public void Update()
        {
            keys = new byte[256];
            GetKeyboardState(keys);

            foreach (var entries in keyMap)
            {
                previousStates[entries.Key] = currentStates[entries.Key];
                currentStates[entries.Key] = IsKeyDown(entries.Value);
            }
        }

        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] keystate);

        public bool IsKeyDown(Keys key)
        {
            return keys[(int)key] >=128;
        }
    }
}
