#region License
/* 
 * Copyright (C) 1999-2025 John Källén.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */
#endregion

namespace Reko.Analysis
{
    /// <summary>
    /// Names of heuristics that the decompiler can use during analysis.
    /// </summary>
    public class AnalysisHeuristics
    {
        /// <summary>
        /// Configuration key for the aggressive branch removal heuristic.
        /// </summary>
        public const string AggressiveBranchRemoval = "aggressive-branch-removal";

        /// <summary>
        /// Configuration key for the heuristic that assumes 
        /// procedure calls respect the ABI of the <see cref="Core.IPlatform"/>.
        /// </summary>
        public const string CallsRespectABI = "calls-respect-abi";
    }
}
