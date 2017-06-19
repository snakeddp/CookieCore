using System.Collections.Generic;
using System.Collections.Immutable;
using Cookie.ProtocolBuilder.Helpers;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Builders
{
    public class ProtocolClassBuilder
    {
        public ImmutableList<IClassWriter> ClassWriters { get; }

        /// <summary>
        /// Simple wrapper wich allow you to do operations on a list of protocol classes
        /// </summary>
        /// <param name="classWriters">The <see cref="IClassWriter"/> list of protocol class writer</param>
        /// <seealso cref="ProtocolClass"/>
        /// <seealso cref="IEnumerable{T}"/>
        public ProtocolClassBuilder(IEnumerable<IClassWriter> classWriters)
        {
            ClassWriters = classWriters.ToImmutableList();
        }

        /// <summary>
        /// Create repositories for each protocol class in <see cref="ClassWriters"/>
        /// </summary>
        /// <remarks>Repositories are created on current directory (where you lauch the exe)</remarks>
        public void CreateRepositories()
            => ClassWriters.ForEach(cw => Throw.If(!cw.TryCreateRepositories(), nameof(cw)));

        /// <summary>
        /// Create .cs file for each protocol class in <see cref="ClassWriters"/>
        /// </summary>
        /// <remarks>Files are created on their proper directory</remarks>
        public void CreateFiles()
            => ClassWriters.ForEach(cw => Throw.If(!cw.TryCreateFile(), nameof(cw)));

        /// <summary>
        /// Write content of class for each protocol class in <see cref="ClassWriters"/>
        /// </summary>
        /// <remarks>Content is written on his relative file</remarks>
        public void WriteFiles()
            => ClassWriters.ForEach(cw => cw.WriteFile());
    }
}
