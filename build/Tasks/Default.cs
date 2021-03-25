using Cake.Common.Diagnostics;
using Cake.Frosting;

[TaskName("Default")]
public sealed class Default : FrostingTask<Context>
{
    public override void Run(Context context)
    {
        context.Information("Default Hello World");
    }
}