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
            nsxtalb = new NSXTALBClientAsync();
            await nsxtalb.LoginAsync("10.0.100.18", "admin", "VMware1!", false);
            var nsxalbrespone = await nsxtalb.ClusterRuntimeModule.GetRuntime();
            await nsxtalb.LogoutAsync();
            Assert.NotNull(nsxalbrespone);
        }
    }
}