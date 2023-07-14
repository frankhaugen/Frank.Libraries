using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public struct Matrix : IEquatable<Matrix>
{
    public float M11;

    public float M12;

    public float M13;

    public float M14;

    public float M21;

    public float M22;

    public float M23;

    public float M24;

    public float M31;

    public float M32;

    public float M33;

    public float M34;

    public float M41;

    public float M42;

    public float M43;

    public float M44;
    private static Matrix identity = new Matrix(1f, 0.0f, 0.0f, 0.0f, 0.0f, 1f, 0.0f, 0.0f, 0.0f, 0.0f, 1f, 0.0f, 0.0f, 0.0f, 0.0f, 1f);

    public Matrix(
        float m11,
        float m12,
        float m13,
        float m14,
        float m21,
        float m22,
        float m23,
        float m24,
        float m31,
        float m32,
        float m33,
        float m34,
        float m41,
        float m42,
        float m43,
        float m44)
    {
        this.M11 = m11;
        this.M12 = m12;
        this.M13 = m13;
        this.M14 = m14;
        this.M21 = m21;
        this.M22 = m22;
        this.M23 = m23;
        this.M24 = m24;
        this.M31 = m31;
        this.M32 = m32;
        this.M33 = m33;
        this.M34 = m34;
        this.M41 = m41;
        this.M42 = m42;
        this.M43 = m43;
        this.M44 = m44;
    }

    public static Matrix CreatePerspective(
        float width,
        float height,
        float nearPlaneDistance,
        float farPlaneDistance)
    {
        Matrix result;
        Matrix.CreatePerspective(width, height, nearPlaneDistance, farPlaneDistance, out result);
        return result;
    }

    public static void CreatePerspective(
        float width,
        float height,
        float nearPlaneDistance,
        float farPlaneDistance,
        out Matrix result)
    {
        if ((double) nearPlaneDistance <= 0.0)
            throw new ArgumentException("nearPlaneDistance <= 0");
        if ((double) farPlaneDistance <= 0.0)
            throw new ArgumentException("farPlaneDistance <= 0");
        if ((double) nearPlaneDistance >= (double) farPlaneDistance)
            throw new ArgumentException("nearPlaneDistance >= farPlaneDistance");
        float num = float.IsPositiveInfinity(farPlaneDistance) ? -1f : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
        result.M11 = 2f * nearPlaneDistance / width;
        result.M12 = result.M13 = result.M14 = 0.0f;
        result.M22 = 2f * nearPlaneDistance / height;
        result.M21 = result.M23 = result.M24 = 0.0f;
        result.M33 = num;
        result.M31 = result.M32 = 0.0f;
        result.M34 = -1f;
        result.M41 = result.M42 = result.M44 = 0.0f;
        result.M43 = nearPlaneDistance * num;
    }

    public static Matrix CreatePerspectiveFieldOfView(
        float fieldOfView,
        float aspectRatio,
        float nearPlaneDistance,
        float farPlaneDistance)
    {
        Matrix result;
        Matrix.CreatePerspectiveFieldOfView(fieldOfView, aspectRatio, nearPlaneDistance, farPlaneDistance, out result);
        return result;
    }

    public static void CreatePerspectiveFieldOfView(
        float fieldOfView,
        float aspectRatio,
        float nearPlaneDistance,
        float farPlaneDistance,
        out Matrix result)
    {
        if ((double) fieldOfView <= 0.0 || (double) fieldOfView >= 3.1415929794311523)
            throw new ArgumentException("fieldOfView <= 0 or >= PI");
        if ((double) nearPlaneDistance <= 0.0)
            throw new ArgumentException("nearPlaneDistance <= 0");
        if ((double) farPlaneDistance <= 0.0)
            throw new ArgumentException("farPlaneDistance <= 0");
        if ((double) nearPlaneDistance >= (double) farPlaneDistance)
            throw new ArgumentException("nearPlaneDistance >= farPlaneDistance");
        float num1 = 1f / (float) Math.Tan((double) fieldOfView * 0.5);
        float num2 = num1 / aspectRatio;
        float num3 = float.IsPositiveInfinity(farPlaneDistance) ? -1f : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
        result.M11 = num2;
        result.M12 = result.M13 = result.M14 = 0.0f;
        result.M22 = num1;
        result.M21 = result.M23 = result.M24 = 0.0f;
        result.M31 = result.M32 = 0.0f;
        result.M33 = num3;
        result.M34 = -1f;
        result.M41 = result.M42 = result.M44 = 0.0f;
        result.M43 = nearPlaneDistance * num3;
    }

    public static Matrix CreateLookAt(
        Vector3 cameraPosition,
        Vector3 cameraTarget,
        Vector3 cameraUpVector)
    {
        Matrix result;
        Matrix.CreateLookAt(ref cameraPosition, ref cameraTarget, ref cameraUpVector, out result);
        return result;
    }
    public static void CreateLookAt(
        ref Vector3 cameraPosition,
        ref Vector3 cameraTarget,
        ref Vector3 cameraUpVector,
        out Matrix result)
    {
        Vector3 vector3_1 = Vector3.Normalize(cameraPosition - cameraTarget);
        Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector3_1));
        Vector3 vector3_2 = Vector3.Cross(vector3_1, vector2);
        result.M11 = vector2.X;
        result.M12 = vector3_2.X;
        result.M13 = vector3_1.X;
        result.M14 = 0.0f;
        result.M21 = vector2.Y;
        result.M22 = vector3_2.Y;
        result.M23 = vector3_1.Y;
        result.M24 = 0.0f;
        result.M31 = vector2.Z;
        result.M32 = vector3_2.Z;
        result.M33 = vector3_1.Z;
        result.M34 = 0.0f;
        result.M41 = -Vector3.Dot(vector2, cameraPosition);
        result.M42 = -Vector3.Dot(vector3_2, cameraPosition);
        result.M43 = -Vector3.Dot(vector3_1, cameraPosition);
        result.M44 = 1f;
    }

    public bool Equals(Matrix other) => M11 == other.M11 && M12 == other.M12 && M13 == other.M13 && M14 == other.M14 && M21 == other.M21 && M22 == other.M22 && M23 == other.M23 && M24 == other.M24 && M31 == other.M31 && M32 == other.M32 && M33 == other.M33 && M34 == other.M34 && M41 == other.M41 && M42 == other.M42 && M43 == other.M43 && M44 == other.M44;

    public override bool Equals(object? obj) => obj is Matrix other && Equals(other);

    public override int GetHashCode()
    {
        var batch1 = HashCode.Combine(M11, M12, M13, M14, M21, M22, M23, M24);
        var batch2 = HashCode.Combine(M31, M32, M33, M34, M41, M42, M43, M44);
        return HashCode.Combine(batch1, batch2);
    }

    public static bool operator ==(Matrix left, Matrix right) => left.Equals(right);

    public static bool operator !=(Matrix left, Matrix right) => !left.Equals(right);
}