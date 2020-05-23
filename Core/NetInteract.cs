using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HackerTargetPublicAPI.Core
{
    public class NetInteract
    {
        public string DnsLookup(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/dnslookup/?q=" + domain);
            client.Dispose();
            return result;
        }
        public string GeoIp(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/geoip/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string TcpScan(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/nmap/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string ReverseIpLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/reverseiplookup/?q=" + ip);
            client.Dispose();
            return result;
        }

        public string ReverseDNSLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/reversedns/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string SubNetLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/subnetcalc/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string BannerLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/bannerlookup/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string ASNLookup(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/aslookup/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string SharedServer(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/findshareddns/?q=" + ip);
            client.Dispose();
            return result;
        }
        public string ZoneTransfer(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/zonetransfer/?q=" + domain);
            client.Dispose();
            return result;
        }
        public string Whois(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/whois/?q=" + domain);
            client.Dispose();
            return result;

        }

        public string Ping(string domain)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/nping/?q=" + domain);
            client.Dispose();
            return result;
        }
        public string TraceRoute(string ip)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("https://api.hackertarget.com/mtr/?q=" + ip);
            client.Dispose();
            return result;
        }
    }
}
