using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddOpenTelemetry()
    .WithTracing(b => {
        b.SetResourceBuilder(
            ResourceBuilder.CreateDefault()
            .AddService(builder.Environment.ApplicationName))
         .AddAspNetCoreInstrumentation()
         .AddOtlpExporter(opts => { opts.Endpoint = new Uri("http://localhost:4317"); });
});

var app = builder.Build();

int SleepFunction()
{
    int i = Random.Shared.Next(100, 1000);
    Thread.Sleep(i);
    return i;
}

app.MapGet("/rolldice/{player?}", SleepFunction);

app.Run();