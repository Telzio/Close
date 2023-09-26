# Close
[![NuGet](https://img.shields.io/nuget/v/close?color=blue)](https://www.nuget.org/packages/close/)
![MIT](https://img.shields.io/github/license/telzio/close)

A .NET Core API client for [Close](https://close.com), supporting .NET Core 6/7/8. This is _not_ an official project by Close. It's created and maintained by [Telzio](https://telzio.com), because the API client [mentioned](https://developer.close.com/topics/api-clients/#c) in Close' docs hasn't been updated in 7+ years.


## Usage
The client currently targets .NET Core 6+.

### Dependency Injection
Add the client to your service collection and specify your [API Key](https://help.close.com/docs/api-keys). 

```builder.Services.AddCloseClient("xxxxxxxxxxxx");```

*Important: You should never keep your credentials in your source code. Use a secrets manager instead!*

### Custom Fields
You can specify custom fields for leads, contacts, opportunities, and custom objects by creating your own classes that inherit from these main classes and decorating your properties with ```[JsonPropertyName("custom.cf_XXXXXXXXXX")]```. The client will automatically serialize and deserialize the custom fields for you.
``` 
public class AccountCustomObject : CustomObject
{
    [JsonPropertyName("custom.cf_XXXXXXXXXXXXXXXXXXX")]
    public string AccountId { get; set; }

    [JsonPropertyName("custom.cf_YYYYYYYYYYYYYYYYYYY")]
    public string AccountStatus { get; set; }
} 
```

---

## Work In Progress
We are currently working on migrating code from a client library we made internally at Telzio. Below is a list of what's currently implemented and what's in progress.

#### Leads
- [x] List leads
- [x] Create a new lead
- [x] Retrieve a single lead
- [x] Update an existing lead
- [x] Delete a lead
- [ ] Merge two leads

#### Contacts
- [x] List contacts
- [x] Create a new contact 
- [x] Retrieve a single contact
- [x] Update an existing contact
- [x] Delete a contact

#### Pipelines
- [x] List or filter pipelines
- [x] Create a pipeline
- [x] Retrieve a pipeline
- [x] Update a pipeline
- [x] Delete a pipeline

#### Opportunities
- [x] List or filter opportunities
- [x] Create an opportunity
- [x] Retrieve an opportunity
- [x] Update an existing opportunity
- [x] Delete an opportunity

#### Custom Object Instances
- [x] List custom object instances
- [x] Create a custom object instance
- [x] Retrieve a custom object instance
- [x] Update a custom object instance
- [x] Delete a custom object instance

#### Tasks
- [x] List or filter tasks
- [x] Create a task
- [x] Retrieve a task
- [x] Update an existing task
- [x] Delete a task

#### Lead Statuses
- [x] List lead statuses for your organization
- [x] Create new status that can be applied to leads
- [x] Rename a lead status
- [x] Delete a lead status

#### Opportunity Statuses
- [x] List opportunity statuses for your organization
- [x] Create new status tht can be applied to opportunities
- [x] Rename an opportunity status
- [x] Delete an opportunity status

#### Integration Links
- [x] List integration links
- [x] Create an integration link
- [x] Update an integration link
- [x] Delete an integration link

#### Event Log
- [x] List Events
- [x] Retrieve Event

#### Not Yet Implemented
- [ ] Groups
- [ ] Reporting
- [ ] Email Templates
- [ ] SMS Templates
- [ ] Connected Accounts
- [ ] Memberships
- [ ] Users
- [ ] Organizations
- [ ] Roles
- [ ] Custom Fields
- [ ] Send As
- [ ] Sequences
- [ ] Dialer
- [ ] Smart Views
- [ ] Bulk Actions
- [ ] Integration Links
- [ ] Exports
- [ ] Phone Numbers
- [ ] Webhook Subscriptions
- [ ] Custom Activities