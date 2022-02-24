# EmailSender - EmailController - WEB API Controller for Emailer project

This is the Web API Controller for Emailer.dll
This repo contains a controller to show an example of how to utilize the Emailer.dll emailing capability

In the `async Task SendEmailAsync(MailRequest mailRequest);`
The MailRequest instance is populated through form-data from the [FromForm] call in EmailController

Make sure to look at appsettings.json to edit the configurations to your liking.
I have a test email and password already set which you are more than welcome to use.

I already said this in the Emailer class library README.md, but I will say it again here: 
  
  It can easily be modified to work with a GUI/Windows Form Application by utilizing an action/event listener on a button click "send"
Simply get rid of the HttpPost and [FromForm] before the MailRequest object is populated when the POST method is sent.
Instead, call the [HttpPost] function on a button click and populate the MailRequest properties from the text fields instead of form-data.
If the task's status code is returned as 200 it essentially means it was a "Success!" and vice-versa

Required Libraries/Nuget Packages utilized in this project: .

`MailKit` standard Emailing library,  System.Net.Mail functionality could be utilized in place of this, but after doing research I decided this was the best practice to go with
`Microsoft.Extensions.Options` Had a confliction with Swashbuckle.AspNetCore and Micrsoft.AspNetCore. Utilizing the Options extension made sure Project and Emailer are using the same Options<T> pattern
`Swashbuckle.AspNetCore` This is utilizing Swagger for a nice UI to retrieve and test the form-data as well as return the result of the asychronous task SendEmailAsync
'Emailer.dll' This is the meat of the code project. See Emailer project's README.md for information on how it works.

## Compiling

    Pull this project or import it into Visual Studio (I used 2019)
    Reference Emailer.dll and make sure you have the Libraries that are utilized in this project
    Build the project
    Libraries/NuGet Packages: MailKit, Microsoft.Extensions.Options, and Emailer.DLL (See Emailer project README.md)

## Usage

   public async Task<IActionResult> Send([FromForm] MailRequest request)

  After successfully building and running the project:
    On the neat UI provided by Swagger, simply fill the form-data with specified ToEmail, Subject, and Body Text. Attachments are optional
    Simply click Execute and viola! Your POST request is sent.
    The email day, month, year, and timestamp is logged to the LogPath and LogFile you configured in appsettings.json
    (For logging functionality, see Logger's README.md)
    
