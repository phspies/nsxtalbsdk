using nsxtalbsdk;
using nsxtalbsdk.Models;
using System.Collections.Generic;
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

            var healhmonitors = new List<NSXTALBHealthMonitorType>((await nsxtalb.HealthMonitorModule.GetHealthmonitorAsync()).Results);
            var networks = new List<NSXTALBNetworkType>((await nsxtalb.NetworkModule.GetNetworkAsync()).Results);
            var currentvs = await nsxtalb.VirtualServiceModule.GetVirtualserviceAsync();
            var clouds = new List<NSXTALBCloudType>((await nsxtalb.CloudModule.GetCloudAsync()).Results);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(currentvs.Results[0]);
            var pool = await nsxtalb.PoolModule.PostPoolAsync(new NSXTALBPoolType()
            {

                LbAlgorithm = "LB_ALGORITHM_LEAST_CONNECTIONS",
                Servers = new List<NSXTALBServerType>() { new NSXTALBServerType() {
                      Ip = new NSXTALBIpAddrType() { Addr = "10.0.0.10", Type = "V4" },  Description  = "Test Server" }
                },
                Description = "Test Server Pool",
                Name = "Test Server Pool",
                DefaultServerPort = 80,

                HealthMonitorRefs = new List<string>(new string[] { healhmonitors.Find(x => x.Name == "System-HTTP").Url })
            });

            Assert.NotNull(pool);
            var selectedNetwork = networks.Find(x => x.Name == "AVIDataPG");
            var applicationProfile = (new List<NSXTALBApplicationProfileType>((await nsxtalb.ApplicationProfileModule.GetApplicationprofileAsync()).Results)).Find(x => x.Name == "System-HTTP");
            var vservice = await nsxtalb.VirtualServiceModule.PostVirtualserviceAsync(new NSXTALBVirtualServiceType()
            {
                Name = "TestVS",
                Type = "VS_TYPE_NORMAL",
                PerformanceLimits = new NSXTALBPerformanceLimitsType() { MaxConcurrentConnections = 1000 },
                CloudRef = clouds.Find(x => x.Vtype == "CLOUD_VCENTER").Url,
                Enabled = true,
                Services = new List<NSXTALBServiceType>() { new NSXTALBServiceType() { Port = 80, EnableSsl = false } },
                ApplicationProfileRef = applicationProfile.Url,
                PoolRef = pool.Url,
                Vip = new List<NSXTALBVipType>() {
                    new NSXTALBVipType() {
                        AutoAllocateFloatingIp = false,
                        AutoAllocateIp = true,
                        AutoAllocateIpType = "V4_ONLY",
                        AvailabilityZone = null,
                        AviAllocatedFip = false,
                        AviAllocatedVip = false,
                        DiscoveredNetworks = new List<NSXTALBDiscoveredNetworkType>() { 
                            new NSXTALBDiscoveredNetworkType() {
                                NetworkRef = selectedNetwork.Url,
                                Subnet = new List<NSXTALBIpAddrPrefixType>() {
                                    new NSXTALBIpAddrPrefixType() {
                                        IpAddr = selectedNetwork.ConfiguredSubnets[0].Prefix.IpAddr,
                                        Mask = selectedNetwork.ConfiguredSubnets[0].Prefix.Mask,
                                    }
                                }
                            }
                        }
                    }
                }
            });
            Assert.NotNull(vservice);

            await nsxtalb.VirtualServiceModule.DeleteVirtualserviceUuidAsync(vservice.Uuid);

            await nsxtalb.PoolModule.DeletePoolUuidAsync(pool.Uuid);

            nsxtalb.Logout();
        }
    }
}