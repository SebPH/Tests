//these are similar to C# using statements
open canopy.runner.classic
open canopy.configuration
open canopy.classic

canopy.configuration.chromeDir <- System.AppContext.BaseDirectory

//start an instance of chrome
start chrome

//this is how you define a test
"Testing out sample website" &&&& fun _ ->
   //this is an F# function body, it's whitespace enforced

   //go to url
   url "http://localhost:8012/SeleniumProject/"
   pin canopy.types.direction.FullScreen
   
   // Fill in first name
   "#firstName" << "John"                   //

   // Fill in last name
   "#lastName"  << "Snow"

   // Fill in address
   "#address"  << "4100 Fairfax Drive, Arlington VA"

   // Fill in email
   "#phone"  << "301-936-1085"

   // Fill in age
   "#age" << "25"

   // Gender Selection
   click "#gender1"

   // Transportation Selection
   click "#vehicle4"

   // Snack Selection
   click "#wine"

   // Create Login
   "#signup-email" << "JohnSnow@gmail.com"
   "#signup-password" << "Stark_Tygerian"

   // Submit
   click "#signup-submit"

   // go back
   navigate back
   sleep 2

   // Login
   "#signin-email" << "JohnSnow@gmail.com"
   "#signin-password" << "Stark_Tygerian"

   // Submit
   click "#signin-submit"
   navigate back
   reload()

//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

// Quits Browser
quit()