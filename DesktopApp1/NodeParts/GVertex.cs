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
        public bool IsMale { get; private set; }

        public GVertex(string id, bool isMale)
        {
            ID = id;
            IsMale = isMale;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", ID, IsMale);
        }
    }

}
