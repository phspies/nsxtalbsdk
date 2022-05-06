# .net 6.0 SDK for NSX-T ALB 22.1.1

SDK compatable with .net 6.0 for NSX-T ALB 22.1.1. It uses RestSharp/Polly as the transport and Newtonsoft.Json for JSON handeling.

## Modules

The Manager and Policy modules are accesible from the same SDK root object in the following manner:

```dotnet
nsxtalb = new NSXTALBClient("10.0.100.18", "admin", "VMware1!", false);
var loginresponse = await nsxtalb.LoginAsync();

var se = nsxtalbClient.ServiceEngineModule.GetServiceengine();

```

All Types and Enums are prefixed with NSXTALB to avoid collisions in your projects.

## Custom JsonSerializerSettings

You can pass your own serialization settings as part of the client init code

```dotnet
NSXTALBClient nsxtClient = new NSXTALBClient("192.168.0.100", "admin", "password", false, new Newtonsoft.Json.JsonSerializerSettings() {  Formatting = Newtonsoft.Json.Formatting.None });
```

## Todo
1. Refesh session when expires in flight
2. Incoporate runtime API calls as being documentated by the Dev team at VMware
