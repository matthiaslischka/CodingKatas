namespace TreeSerializer
{
    public class Leaf
    {
        public string Value { get; set; }

        public Leaf LeftLeaf { get; set; }

        public Leaf RightLeaf { get; set; }

        public Leaf(string value = "", Leaf leftLeaf = null, Leaf rightLeaf = null)
        {
            Value = value;
            LeftLeaf = leftLeaf;
            RightLeaf = rightLeaf;
        }
    }
}