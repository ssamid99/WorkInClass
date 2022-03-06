﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.STUDENT_SYSTEM.Managers
{
    class GroupManager
    {
        Group[] data = new Group[0];

        public void Add(Group entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }
        public Group[] GetAll()
        {
            return data;
        }
    }
}
