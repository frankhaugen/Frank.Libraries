using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class EdgeExtensions
{
    public static bool Intersect(this Edge edge, Edge other, out Vector3? intersectionPoint)
    {
        intersectionPoint = new Vector3(0, 0, 0);

        Vector3 da = new Vector3(edge.B.X - edge.A.X, edge.B.Y - edge.A.Y, edge.B.Z - edge.A.Z);
        Vector3 db = new Vector3(other.B.X - other.A.X, other.B.Y - other.A.Y, other.B.Z - other.A.Z);
        Vector3 dc = new Vector3(edge.A.X - other.A.X, edge.A.Y - other.A.Y, edge.A.Z - other.A.Z);

        if (Vector3.Dot(Vector3.Cross(da, db), dc) != 0) // lines are not coplanar
            return false;

        Vector3 nda = Vector3.Normalize(da);
        Vector3 ndb = Vector3.Normalize(db);

        var dp = Vector3.Dot(nda, ndb);
        if (Math.Abs(dp - 1f) < 0.0001f || Math.Abs(dp + 1f) < 0.0001f)// lines are parallel
            return false;

        Vector3 c = Vector3.Cross(da, db);
        var t1 = Vector3.Dot(Vector3.Cross(dc, db), c) / Vector3.Dot(c, c);
        if (t1 < 0 || t1 > 1) // intersection not within first line segment
            return false;

        float t2;
        if (Math.Abs(dp - 1f) < 0.0001f || Math.Abs(dp + 1f) < 0.0001f)
            t2 = (Vector3.Dot(dc, nda) - Vector3.Dot(Vector3.Multiply(other.A - edge.A, ndb), nda)) / (1 - dp * dp);
        else
            t2 = Vector3.Dot(Vector3.Cross(dc, da), c) / Vector3.Dot(c, c);
        if (t2 < 0 || t2 > 1) // intersection not within second line segment
            return false;

        intersectionPoint = new Vector3(edge.A.X + t1 * da.X, edge.A.Y + t1 * da.Y, edge.A.Z + t1 * da.Z);

        return true;
    }
}