﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServerlessFuncs
{
    public class Todo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public DateTime CreateDateTime { get; set; } = DateTime.UtcNow;
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class TodoCreateModel
    {
        public string TaskDescription { get; set; }
    }

    public class TodoUpdateModel
    {
        public bool IsCompleted { get; set; }
        public string TaskDescription { get; set; }
       
    }
}
