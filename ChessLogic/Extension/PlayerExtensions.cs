﻿using Chess.Common.Enum;

namespace ChessLogic.Extension
{
    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.Black => Player.White,
                Player.White => Player.Black,
                _ => Player.None,
            };
        }
    }
}