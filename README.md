# Close
[![NuGet](https://img.shields.io/nuget/v/close.svg)](https://www.nuget.org/packages/close/)
![MIT](https://img.shields.io/github/license/telzio/close)

The unofficial .NET Core API client for [Close](https://close.com), supporting .NET Core 6+

This is _not_ an official project by Close. It's created and maintained by [Telzio](https://telzio.com), because the API client [mentioned](https://developer.close.com/topics/api-clients/#c) in Close' docs hasn't been updated in 7+ years.

---

## Work In Progress
We are currently working on migrating code from a client library we made internally at Telzio. Most functionality should be available in next release.

---

## Usage
The client currently targets .NET Core 6+.

### Dependency Injection
Add the client to your service collection and specify your [API Key](https://help.close.com/docs/api-keys). 

```builder.Services.AddCloseClient("xxxxxxxxxxxx");```

*Important: You should never keep your credentials in your source code. Use a secrets manager instead!*
