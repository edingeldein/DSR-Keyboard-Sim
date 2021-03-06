﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomEnums
{
    public enum KeyType
    {
        Command,
        Value
    }

    public enum Commands
    {
        Backspace,
        Clear,
        Tab,
        NewLine,
        Enter,
        CursorUp,
        CursorDown,
        CursorLeft,
        CursorRight,
        FP,
        AM,
        RTE,
        None
    }

    public enum ActionToken
    {
        AircraftID,
        AircraftType,
        BeaconCode,
        FiledTrueAirspeed,
        PointWhereProcessingBegins,
        CoordinationTimeAtFix,
        AssignedAltitude,
        RequestedAltitude,
        RouteOfFlight,
        PertinentRemarks,
        FLID,
        FDB,
        EDST,
        ACL
    }
}
