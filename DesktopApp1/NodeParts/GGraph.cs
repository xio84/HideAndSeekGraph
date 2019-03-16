using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace HideAndSeekGraph.NodeParts
{
    public class GGraph : BidirectionalGraph<GVertex, GEdge>
    {
        public GGraph() { }

        public GGraph(bool allowParallelEdges)
            : base(allowParallelEdges) { }

        public GGraph(bool allowParallelEdges, int vertexCapacity)
            : base(allowParallelEdges, vertexCapacity) { }
    }
}
