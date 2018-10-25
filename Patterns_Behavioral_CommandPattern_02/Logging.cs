using System;
using System.Diagnostics;

namespace Design_Patterns_Behavioral_Command_02
{
    /// <summary>
    /// Houses all logging methods for various debug outputs.
    /// </summary>
    public static class Logging
    {
        /// <summary>
        /// Determines type of output to be generated.
        /// </summary>
        internal class StopwatchProxy
        {
            private readonly Stopwatch _stopwatch;
            private static readonly StopwatchProxy _stopwatchProxy = new StopwatchProxy();

            private StopwatchProxy()
            {
                _stopwatch = new Stopwatch();
            }

            public Stopwatch Stopwatch { get { return _stopwatch; } }

            public static StopwatchProxy Instance
            {
                get { return _stopwatchProxy; }
            }
        }
        public enum OutputType
        {
            /// <summary>
            /// Default output.
            /// </summary>
            Default,
            /// <summary>
            /// Output includes timestamp prefix.
            /// </summary>
            Timestamp
        }

        /// <summary>
        /// Outputs to <see cref="Debug.WriteLine(String)"/>.
        /// </summary>
        /// <param name="value">Value to be output to log.</param>
        /// <param name="outputType">Output type.</param>
        public static void Log(string value, OutputType outputType = OutputType.Default)
        {
            Debug.WriteLine(outputType == OutputType.Timestamp
                ? $"[{StopwatchProxy.Instance.Stopwatch.Elapsed}] {value}"
                : value);
        }
    }
}
