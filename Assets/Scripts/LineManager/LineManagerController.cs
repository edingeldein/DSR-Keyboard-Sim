﻿using UnityEngine;
using DSR.LineManager.Interfaces;
using DSR.Interpreter;
using DSR.Interpreter.Enums;
using DSR.Console;

namespace DSR.LineManager
{
    public class LineManagerController : MonoBehaviour, ILineManagerController
    {
        [SerializeField] private ConsoleController _consoleController;
        private Line _currentLine;
        private bool _newVal;

        private void Start()
        {
            _currentLine = new Line();
            _newVal = false;
        }

        private void Update()
        {
            if (_newVal)
            {
                // TODO post current line to console
                _consoleController.UpdateLine(_currentLine.Text, _currentLine.CursorText);
                _newVal = false;
            }
        }

        public void KeyValueInput(KeyValue keyValue)
        {
            _currentLine.AddChar(keyValue.Value);
            _newVal = true;
        }

        public void KeyCommandInput(KeyCommand keyCommand)
        {
            var command = keyCommand.Command;

            switch (command)
            {
                case CommandType.Backspace:
                    _currentLine.Backspace();
                    break;
                case CommandType.Clear:
                    _currentLine.ClearLine();
                    break;
                case CommandType.Enter:
                    // TODO Do something to submit current line...
                    break;
                case CommandType.FP:
                    // TODO PrintFP
                    break;
                case CommandType.Up:
                    break;
                case CommandType.Down:
                    break;
                case CommandType.Left:
                    break;
                case CommandType.Right:
                    break;
            }

            _newVal = true;
        }
    }
}