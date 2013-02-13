﻿using System.Collections.Generic;

namespace TMDbLib.Objects.Person
{
    public class Credits
    {
        public int Id { get; set; }
        public List<MovieRole> Cast { get; set; }
        public List<MovieJob> Crew { get; set; }
    }
}