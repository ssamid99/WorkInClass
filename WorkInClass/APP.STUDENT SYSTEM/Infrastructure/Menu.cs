﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.STUDENT_SYSTEM.Infrastructure
{
    public enum Menu:byte
    {
        GroupAdd = 1,
        GroupEdit,
        GroupRemove,
        GroupSingle,
        GroupsAll,


        StudentAdd,
        StudentEdit,
        StudentRemove,
        StudentSingle,
        StudentsAll,
        Exit,
    }
}
