using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService2017.Models
{
    public class CarCommand
    {
        String command;
        String target;
        String time;
        String host;
        String sourceType;

        public string Command { get => command; set => command = value; }
        public string Target { get => target; set => target = value; }
        public string Time { get => time; set => time = value; }
        public string Host { get => host; set => host = value; }
        public string SourceType { get => sourceType; set => sourceType = value; }
    }
}