﻿using LanguageExt.TypeClasses;
using System.Diagnostics.Contracts;
using static LanguageExt.Prelude;

namespace LanguageExt.ClassInstances
{
    /// <summary>
    /// Char equality
    /// </summary>
    public struct EqChar : Eq<char>
    {
        public static readonly EqChar Inst = default(EqChar);

        /// <summary>
        /// Equality test
        /// </summary>
        /// <param name="a">The left hand side of the equality operation</param>
        /// <param name="b">The right hand side of the equality operation</param>
        /// <returns>True if x and y are equal</returns>
        [Pure]
        public bool Equals(char a, char b) =>
            a == b;

        /// <summary>
        /// Get hash code of the value
        /// </summary>
        /// <param name="x">Value to get the hash code of</param>
        /// <returns>The hash code of x</returns>
        [Pure]
        public int GetHashCode(char x) =>
            x.GetHashCode();
    }
}
