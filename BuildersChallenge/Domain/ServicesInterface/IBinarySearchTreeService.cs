using BuildersChallenge.Domain.Entities;

namespace BuildersChallenge.Domain.ServicesInterface
{
    public interface IBinarySearchTreeService
    {
        bool Contains(Node root, int value, int step);
        string Show();

    }
}
