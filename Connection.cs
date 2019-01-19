using System;
using System.Net;
using EventStore.ClientAPI;

namespace EventStoreExample
{
public static class EventStoreConnectionConfiguration
{
    public static IEventStoreConnection GetConnection()
    {
        var connection = EventStoreConnection.Create(
            IPEndPointConfiguration.DefaultTcpPortAndIpAddress());
        connection.ConnectAsync();
        return connection;
    }
}

internal class IPEndPointConfiguration
{
    private const string _ipAddress = "127.0.0.1";
    private const int _port = 1113;

    public static IPEndPoint DefaultTcpPortAndIpAddress()
    {
        var address = IPAddress.Parse(_ipAddress);
        return new IPEndPoint(address,_port);    
    }

    public static IPEndPoint CustomTcpPortAndIpAdress(string ipAddress, int port)
    {
        return new IPEndPoint(IPAddress.Parse(ipAddress), port);
    }
}
}