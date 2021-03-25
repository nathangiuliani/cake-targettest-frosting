using Cake.Common.Diagnostics;
using Cake.Frosting;

[TaskName("Another")]
public sealed class Another : FrostingTask<Context>
{
    public override void Run(Context context)
    {
        context.Information("Another Hello World");
    }
}