﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.RedisCon
{
    class Todo
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        public bool Done { get; set; }
    }
}
