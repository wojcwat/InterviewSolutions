﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public interface ILogOutput
    {
        void Save(string serializedLogEntry);
    }
}
