using System;
using System.Diagnostics;

namespace HideAndSeekGraph.NodeParts
{
    /// 

    /// A simple identifiable vertex.
    /// 
    [DebuggerDisplay("{ID}-{IsMale}")]
    public class GVertex
    {
        public string ID { get; private set; }

        public GVertex(string id,string color)
        {
            ID = id;
            VertexColor = color;
        }

        public String VertexColor{get; set;}

        public override string ToString()
        {
            return string.Format("{0}", ID);
        }
    }

}
