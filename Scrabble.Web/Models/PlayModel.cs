﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scrabble.Core.Types;

namespace Scrabble.Web.Models
{
    public class PlayModel
    {
        public PlayModel(String id, GameState s)
        {
            GameId = id;
            State = s;
        }

        public String GameId { get; private set; }

        public GameState State { get; private set; }
    }
}