using BuildersChallenge.Domain.Entities;
using BuildersChallenge.Domain.ServicesInterface;

namespace BuildersChallenge.Domain.Service
{
    public class BinarySearchTreeService : IBinarySearchTreeService
    {
        private int step { get; set; }
        public bool Contains(Node root, int value, int step)
        {
            this.step = step;

            if (root == null)
            {
                return false;
            }
            else
            {
                if (root.Value > value)
                {
                    root = root.Left;
                    step = step + 1;
                    return Contains(root, value, step);
                }
                else if (root.Value < value)
                {
                    root = root.Right;
                    step = step + 1;
                    return Contains(root, value, step);
                }
                else if (root.Value == value)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public string Show()
        {
            Node n1 = new Node(1, null, null);            
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            var tree = new BinarySearchTreeService();
            tree.step = 0;
            return(tree.Contains(n2, 3, tree.step) + " " + tree.step);
        }
    }
}
