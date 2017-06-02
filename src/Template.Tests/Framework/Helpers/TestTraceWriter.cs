using Microsoft.Azure.WebJobs.Host;
using System.Diagnostics;

namespace Template.Tests.Framework.Helpers
{
    internal class TestTraceWriter : TraceWriter
    {
        public TestTraceWriter(TraceLevel level) : base(level)
        {
        }

        public override void Trace(TraceEvent traceEvent)
        {
            Debug.WriteLine(traceEvent.Message);
        }
    }
}