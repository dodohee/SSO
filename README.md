# SSO
Quick try to show SSO integration with mashup content display

The solution is based on Okta MVC sample.

Please make sure to run both sites simultaneously. - Modify solution property in Visual Studio to run both projects.

If you build and run the code, you will see two local websites, one says "Main Web", the other one is "Content". 
Before you try to login, please try to click "Okta Secured" menu on the "Main Web" which will not display anything but empty iframe.

The Main Web has "Login" link enabled where you can click to login with

user: aaa@aaa.com, password: Abcd1234  (case sensitive)

After login successfully, click "Okta Secured" menu again to see what happens.
