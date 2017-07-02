﻿using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ListAddFailureEnum
    {
        LIST_ADD_FAILURE_UNKNOWN = 0,
        LIST_ADD_FAILURE_OVER_QUOTA = 1,
        LIST_ADD_FAILURE_NOT_FOUND = 2,
        LIST_ADD_FAILURE_EGOCENTRIC = 3,
        LIST_ADD_FAILURE_IS_DOUBLE = 4
    }
}