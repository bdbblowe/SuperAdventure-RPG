﻿using System;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _simpleGenerator = new Random();

        public static int SimpleNumberBetween(int minimumValue, int maximumValue)
        {
            return _simpleGenerator.Next(minimumValue, maximumValue + 1);
        }
    }
}
