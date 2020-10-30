# 3dcart Sample Action App
This sample application implements a simple use case of the **Action** feature from a **3dcart App**. Find out more about building 3dcart Apps at https://developer.3dcart.com/build-an-app/.
The app is built using .Net Core 3.1.
### Overview
Using a basic MVC pattern this sample application receives parameterized requests, queries a store's API using `HttpClient` library and uses Razor views to show example information from the requested item.

Note that there are many possible use cases for the **Action** feature and this sample examplifies the scenario where a third party application integrates with a store using Rest Api to get more information.
### App Information
##### Controllers
###### HomeController
Displays a basic welcome page with some sample requests.
###### CheckStatusController
Receives parametized requests and displays item information.
##### Request Parameters
###### Id
Item identifier added to the request by default for any action integrations (e.g. Customer Id, Order Id or Product Id).
###### Token
Acccess token added to the request by default for all action integrations. Indentifies the store and grants access to the Rest Api.

To create a token add the **App** to the store. 

To get the token go to **Stores that are using this APP** section on the **App** configuration page on 3dcart's Developer Portal.
###### Page
Identifies the request source page.

It is used to query item information on the store Rest Api.

You can replace this with any other technique in order to identify the source page (e.g. path, refererr header, etc.).

Disregard it if your implementation will not require source page identification.

## Steps
### 1. Setup a 3dcart App
* Create a new App at [3dcart's Developer Portal](https://developer.3dcart.com/build-an-app/).
* On the **App** configuration page go to the **Action/Settings** section and add action items.
* Add the **App** to the 3dcart store. If you don't have one yet you can create a free trial store [here](https://3dcart.com)
### 2. Configure
Get the **Private Key** from the App configuration page  and update `ApplicationSettings:AppPrivateKey` setting on `appsettings.json` file.

You will also need to populate the `CheckStatusController.cs` file with the **Store Secure Url** and the **Token** so that the request gets identified, typically this would probably be done using database persisntence.  You will find these fields on **Stores that are using this APP** section on the **App** configuration page.
### 3. Run
Run your app.

Go to the store where you added the 3dcart app, login to the store admin, go to the page you selected when creating the action, click the **Action** button, find the action you created and click.

Check that the request was made to your sample app and item information was displayed.

Tip: Make sure that the action **Target Url** points to where your application is running (e.g. https://localhost:44307 or any valid domain you hosted the sample app at).