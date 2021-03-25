using Cake.Common;
using Cake.Core;
using Cake.Frosting;

public class Context : FrostingContext
{
    public string Target { get; set; }

    public Context(ICakeContext context)
        : base(context)
    {
    }
}