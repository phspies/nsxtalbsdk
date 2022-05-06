using nsxtalbsdk;
using nsxtalbsdk.Models;
using Xunit;

namespace Testing
{
    public class BaseTests
    {
        NSXTALBClientAsync nsxtalb;
        [Fact]
        public async void Login()
        {
            nsxtalb = new NSXTALBClientAsync("10.0.100.18", "admin", "VMware1!", false);
            var loginresponse = await nsxtalb.LoginAsync();
            Assert.NotNull(loginresponse);
            var nsxalbrespone = await nsxtalb.ClusterRuntimeModule.GetRuntime();
            nsxtalb.Logout();
            Assert.NotNull(nsxalbrespone);
        }
    }
}