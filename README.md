# Close
[![NuGet](https://img.shields.io/nuget/v/close.svg)](https://www.nuget.org/packages/close/)
![MIT](https://img.shields.io/github/license/telzio/close)

The unofficial .NET Core API client for [Close](https://close.com), supporting .NET Core 6+

This is _not_ an official project by Close. It's created and maintained by [Telzio](https://telzio.com), because the API client [mentioned](https://developer.close.com/topics/api-clients/#c) in Close' docs hasn't been updated in 7+ years.



## Usage
The client currently targets .NET Core 6+.

### Dependency Injection
Add the client to your service collection and specify your [API Key](https://help.close.com/docs/api-keys). 

```builder.Services.AddCloseClient("xxxxxxxxxxxx");```

*Important: You should never keep your credentials in your source code. Use a secrets manager instead!*



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
- [ ] List contacts
- [x] Create a new contact _(Currently only implemented when creating a new lead)_
- [ ] Retrieve a single contact
- [ ] Update an existing contact
- [ ] Delete a contact

#### Activities
- Nothing implemented yet

#### Opportunities
- [x] List or filter opportunities
- [x] Create an opportunity
- [x] Retrieve an opportunity
- [x] Update an existing opportunity
- [x] Delete an opportunity

#### Tasks
- [ ] List or filter tasks
- [ ] Create a task
- [ ] Bulk-update tasks
- [ ] Retrieve a task
- [ ] Update an existing task
- [ ] Delete a task

#### Memberships
- Nothing implemented yet

#### Users
- Nothing implemented yet

#### Organizations
- Nothing implemented yet

#### Roles
- Nothing implemented yet

#### Custom Fields
- Nothing implemented yet

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

#### Pipelines
- [x] List pipelines for your organization
- [x] Create a pipeline
- [x] Update a pipeline
- [x] Delete a pipeline

#### Groups
- Nothing implemented yet

#### Reporting
- Nothing implemented yet

#### Email Templates
- Nothing implemented yet

#### SMS Templates
- Nothing implemented yet

#### Connected Accounts
- Nothing implemented yet

#### Send As
- Nothing implemented yet

#### Sequences
- Nothing implemented yet

#### Dialer
- Nothing implemented yet

#### Smart Views
- Nothing implemented yet

#### Bulk Actions
- Nothing implemented yet

#### Integration Links
- Nothing implemented yet

#### Exports
- Nothing implemented yet

#### Phone Numbers
- Nothing implemented yet

#### Event Log
- [x] List Events
- [x] Retrieve Event

#### Webhook Subscriptions
- Nothing implemented yet

#### Custom Activities
- Nothing implemented yet
