﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSR.Interpreter;

namespace DSR.LineManager.Interfaces
{
    public interface ILineManagerController
    {
        void KeyValueInput(KeyValue keyValue);
        void KeyCommandInput(KeyCommand keyCommand);
    }
}