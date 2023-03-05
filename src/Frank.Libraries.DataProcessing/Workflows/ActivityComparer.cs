namespace Frank.Libraries.DataProcessing.Workflows;

public class ActivityComparer : IComparer<IActivity>
{
    public int Compare(IActivity x, IActivity y)
    {
        if (ReferenceEquals(x, y))
        {
            return 0;
        }

        if (ReferenceEquals(null, y))
        {
            return 1;
        }

        if (ReferenceEquals(null, x))
        {
            return -1;
        }

        return Nullable.Compare(x.Order, y.Order);
    }
}