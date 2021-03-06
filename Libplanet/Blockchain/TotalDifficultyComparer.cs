#nullable enable
using System.Collections.Generic;
using Libplanet.Blockchain.Policies;
using Libplanet.Blocks;

namespace Libplanet.Blockchain
{
    /// <summary>
    /// The default canonical chain comparer (which purpose to be a <see
    /// cref="IBlockPolicy{T}.CanonicalChainComparer"/>).
    /// <para>The chain which has the most <see cref="Block{T}.TotalDifficulty"/> is considered
    /// the greatest, i.e., canonical chain.</para>
    /// </summary>
    /// <seealso cref="IBlockPolicy{T}.CanonicalChainComparer"/>
    /// <seealso cref="IBlockExcerpt"/>
    public class TotalDifficultyComparer : IComparer<IBlockExcerpt>
    {
        /// <inheritdoc cref="IComparer{T}.Compare(T, T)"/>
        public int Compare(IBlockExcerpt? x, IBlockExcerpt? y)
        {
            if (x is null)
            {
                return -1;
            }
            else if (y is null)
            {
                return 1;
            }

            return x.TotalDifficulty.CompareTo(y.TotalDifficulty);
        }
    }
}
