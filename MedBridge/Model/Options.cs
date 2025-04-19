using System;

namespace MedBridge.Model;

public enum Duration
{
    two,
    seven,
    fourteen,
    fifteen

}
public enum Options
{
    Yes,
    No,
    Dontknow
}

public enum Severity
{
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    ten
}


public enum TransferStatus
{
    Requested,
    Approved,
    Booked,
    Completed
}

public enum Status
{
    Active,
    Resolved
}