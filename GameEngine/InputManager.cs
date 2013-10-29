using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace GameEngine
{
    public class InputManager
    {
        private Dictionary<string, Key> keys = new Dictionary<string, Key>();
        private Dictionary<string, KeyStates> previousStates = new Dictionary<string, KeyStates>();
        private Dictionary<string, KeyStates> currentStates = new Dictionary<string, KeyStates>();

        public void AddActionKey(string action, Key key)
        {
            keys.Add(action, key);
            previousStates[action] = KeyStates.None;
            currentStates[action] = KeyStates.None;
        }

        public bool IsActionPressed(string action)
        {
            return currentStates[action] == KeyStates.Down;
        }

        public bool IsActionUp(string action)
        {
            return !IsActionPressed(action);
        }

        public bool IsActionJustPressed(string action)
        {
            return IsActionPressed(action) && previousStates[action] != KeyStates.Down;
        }

        public void Update()
        {
            foreach (var entries in keys)
            {
                previousStates[entries.Key] = currentStates[entries.Key];
                currentStates[entries.Key] = Keyboard.GetKeyStates(entries.Value);
            }
        }
    }
}
