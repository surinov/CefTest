using System.Collections.Generic;

namespace CefTest
{
    public class Model
    {
        public string name { get; set; }
        public string route { get; set; }
        public string defLogin { get; set; }
        public string defPass { get; set; }
        public Steps steps { get; set; }
    }

    public class Login
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int? count { get; set; }
        public string text { get; set; }
        public int del { get; set; }
    }

    public class Wifi
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int? count { get; set; }
        public string text { get; set; }
        public int del { get; set; }
    }

    public class Apn
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int? count { get; set; }
        public string text { get; set; }
        public int del { get; set; }
    }

    public class Remote
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int? count { get; set; }
        public string text { get; set; }
        public int del { get; set; }
    }

    public class Steps
    {
        public List<Login> login { get; set; }
        public List<Wifi> wifi { get; set; }
        public List<Apn> apn { get; set; }
        public List<Remote> remote { get; set; }
    }
}
