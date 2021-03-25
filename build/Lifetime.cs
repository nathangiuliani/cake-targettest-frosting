using Cake.Common;
using Cake.Common.Diagnostics;
using Cake.Core;
using Cake.Frosting;
using System;

public sealed class Lifetime : FrostingLifetime<Context>
{
    public override void Setup(Context context)
    {
        context.Information("Setting things up...");

        try
        {
            context.Target = context.Argument<string>("target");
        }
        catch (Exception e)
        {
            throw new ArgumentNullException("Target argument is not available", e);
        }

        context.Information($"Target is {context.Target}");
    }

    public override void Teardown(Context context, ITeardownContext info)
    {
        context.Information("Tearing things down...");
    }
}