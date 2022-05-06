using nsxtalbsdk;
using nsxtalbsdk.Models;
using Xunit;
namespace Testing
{
    public class BaseTests
    {
        NSXTALBClient nsxtalb;
        [Fact]
        public async void Login()
        {
            nsxtalb = new NSXTALBClient("10.0.100.18", "admin", "VMware1!", false);
            LoginResponseType loginresponse = await nsxtalb.LoginAsync();
            Assert.NotNull(loginresponse);
            ClusterRuntimeType runtimerespone = await nsxtalb.ClusterRuntimeModule.GetRuntimeAsync();
            Assert.NotNull(runtimerespone);
            NSXTALBServiceEngineApiResponseType se = await nsxtalb.ServiceEngineModule.GetServiceengineAsync();
            Assert.NotNull(se);
            nsxtalb.Logout();
        }
    }
}