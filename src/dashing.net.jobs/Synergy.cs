﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashing.net.jobs
{
    public class Synergy : Job
    {
        private readonly Random _rand;

        public Synergy(Action<string> sendMessage)
            : base(sendMessage, "synergy", TimeSpan.FromSeconds(2))
        {
            _rand = new Random();

            Start();
        }

        protected override object GetData()
        {
            return new {value = _rand.Next(100)};
        }
    }
}
