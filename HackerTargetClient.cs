using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerTargetPublicAPI
{
    public class HackerTargetClient
    {

        public enum MethodsProperties { DnsLookup, GeoIPLookup, TcpScan, ReverseIPLookup, ReverseDNSLookup, SubnetLookup, BannerLookup, ASNLookup, SharedDNS, ZoneTransfer, Whois, Ping, TraceRoute }
        public static string GetInformation(MethodsProperties properties, string IpOrDomain)
        {
            string result = ValidateMethod(properties, IpOrDomain);
            return result;
        }
        private static string ValidateMethod(MethodsProperties prop, string arg)
        {
            Core.NetInteract net = new Core.NetInteract();

            if (prop == MethodsProperties.DnsLookup) { return net.DnsLookup(arg); }
            if (prop == MethodsProperties.GeoIPLookup) { return net.GeoIp(arg); }
            if (prop ==MethodsProperties.TcpScan) { return net.TcpScan(arg); }
            if (prop == MethodsProperties.ReverseIPLookup) { return net.ReverseIpLookup(arg); }
            if (prop == MethodsProperties.ReverseDNSLookup) { return net.ReverseDNSLookup(arg); }
            if (prop == MethodsProperties.SubnetLookup) { return net.SubNetLookup(arg); }
            if (prop == MethodsProperties.BannerLookup) { return net.BannerLookup(arg); }
            if (prop == MethodsProperties.ASNLookup) { return net.ASNLookup(arg); }
            if (prop == MethodsProperties.SharedDNS) { return net.SharedServer(arg); }
            if (prop == MethodsProperties.ZoneTransfer) { return net.ZoneTransfer(arg); }
            if (prop == MethodsProperties.Whois) { return net.Whois(arg); }
            if (prop == MethodsProperties.Ping) { return net.Ping(arg); }
            return "None";
        }
    }
}
