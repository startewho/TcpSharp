﻿namespace TcpSharp.Events;

public class OnClientReconnectedEventArgs : EventArgs
{
    public IPAddress ServerIPAddress
    {
        get { return IPAddress.Parse(ServerHost); }
    }

    public string ServerHost { get; internal set; }

    public int ServerPort { get; internal set; }
}