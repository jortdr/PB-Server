using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace PaintballServer
{
    class Player
    {
        public int id;
        public string username;

        public Player(int _id, string _username)
        {
            id = _id;
            username = _username;
        }
    }
}
