using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Polly;
using Polly.Retry;
using Polly.Timeout;
using Polly.Wrap;

namespace Frank.Libraries.Logging.Http.Polly;

public static class Policies
{
    private static AsyncTimeoutPolicy<HttpResponseMessage> TimeoutPolicy
    {
        get
        {
            return Policy.TimeoutAsync<HttpResponseMessage>(2, (context, timeSpan, task) =>
            {
                Debug.WriteLine($"[App|Policy]: Timeout delegate fired after {timeSpan.Seconds} seconds");
                return Task.CompletedTask;
            });
        }
    }

    private static AsyncRetryPolicy<HttpResponseMessage> RetryPolicy
    {
        get
        {
            return Policy
                   .HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                   .Or<TimeoutRejectedException>()
                   .WaitAndRetryAsync(new[]
                                      {
                                          TimeSpan.FromSeconds(1),
                                          TimeSpan.FromSeconds(2),
                                          TimeSpan.FromSeconds(5)
                                      },
                                      (delegateResult, retryCount) =>
                                      {
                                          Debug.WriteLine(
                                              $"[App|Policy]: Retry delegate fired, attempt {retryCount}");
                                      });
        }
    }

    public static AsyncPolicyWrap<HttpResponseMessage> PolicyStrategy => Policy.WrapAsync(RetryPolicy, TimeoutPolicy);
}