//these are similar to C# using statements
open canopy.runner.classic
open canopy.configuration
open canopy.classic
open System.Diagnostics
open canopy

canopy.configuration.chromeDir <- System.AppContext.BaseDirectory
// Canopy Search order
// findByCss
// findByValue
// findByPath
// findByLabel
// findByText
// findByJQuery


// Configurations
elementTimeout <- 10.0
compareTimeout <-10.0
pageTimeout <- 10.0
configuredFinders <- finders.defaultFinders
optimizeBySkippingIFrameCheck <- true

//start an instance of chrome
start chrome

let timer = Stopwatch()
timer.Start()

//this is how you define a test
"Testing out sample website" &&&& fun _ ->
    //this is an F# function body, it's whitespace enforced

    //go to url
    url "http://localhost:8012/BusinessHierarchy/Canopy/"
    pin canopy.types.direction.FullScreen

    // Administrative Level - USING CssSelector
    // Board of Directors
    // Name
    ".mat-admin-level .mat-board-directors .mat-name .firstname" << "Jacob"
    ".mat-admin-level .mat-board-directors .mat-name .lastname" << "Thompson"

    // Country
    click ".mat-admin-level .mat-board-directors .mat-country .location1"

    // Office
    click ".mat-admin-level .mat-board-directors .mat-office .office1"

    // Vertical
    click ".mat-admin-level .mat-board-directors .mat-vertical .vertical1"

    // Horizontal
    click ".mat-admin-level .mat-board-directors .mat-horizontal .click1"

    // Chairman
    // Name
    ".mat-admin-level .mat-chairman .mat-name .firstname" << "Sherly"
    ".mat-admin-level .mat-chairman .mat-name .lastname" << "Matthews"

    // Country
    click ".mat-admin-level .mat-chairman .mat-country .location1"

    // Office
    click ".mat-admin-level .mat-chairman .mat-office .office2"

    // Vertical
    click ".mat-admin-level .mat-chairman .mat-vertical .vertical2"

    // Horizontal
    click ".mat-admin-level .mat-chairman .mat-horizontal .click2"

    // Managing Director
    // Name
    ".mat-admin-level .mat-managing-director .mat-name .firstname" << "Arun"
    ".mat-admin-level .mat-managing-director .mat-name .lastname" << "Shrivan"

    // Country
    click ".mat-admin-level .mat-managing-director .mat-country .location2"

    // Office
    click ".mat-admin-level .mat-managing-director .mat-office .office3"

    // Vertical
    click ".mat-admin-level .mat-managing-director .mat-vertical .vertical3"

    // Horizontal
    click ".mat-admin-level .mat-managing-director .mat-horizontal .click3"

    // CEO
    // Name
    ".mat-admin-level .mat-ceo .mat-name .firstname" << "Anju"
    ".mat-admin-level .mat-ceo .mat-name .lastname" << "Ricmund"

    // Country
    click ".mat-admin-level .mat-ceo .mat-country .location2"

    // Office
    click ".mat-admin-level .mat-ceo .mat-office .office4"

    // Vertical
    click ".mat-admin-level .mat-ceo .mat-vertical .vertical1"

    // Horizontal
    click ".mat-admin-level .mat-ceo .mat-horizontal .click4"

    // Executive Level - Using XPATH
    // President
    // Name
    ".//*[@class='mat-executive-level']/div[1]/div[1]/input[1]" << "Arkson"
    ".//*[@class='mat-executive-level']/div[1]/div[1]/input[2]" << "Jenine"

    // Country
    click ".//*[@class='mat-executive-level']/div[1]/div[2]/input[1]"

    // Office
    click ".//*[@class='mat-executive-level']/div[1]/div[3]/input[1]"

    // Vertical
    click ".//*[@class='mat-executive-level']/div[1]/div[4]/select/option[2]"

    // Horizontal
    click ".//*[@class='mat-executive-level']/div[1]/div[5]/button[1]"

    // Vice President
    // Name
    ".//*[@class='mat-executive-level']/div[2]/div[1]/input[1]" << "Pietro"
    ".//*[@class='mat-executive-level']/div[2]/div[1]/input[2]" << "Axel"

    // Country
    click ".//*[@class='mat-executive-level']/div[2]/div[2]/input[1]"

    // Office
    click ".//*[@class='mat-executive-level']/div[2]/div[3]/input[2]"

    // Vertical
    click ".//*[@class='mat-executive-level']/div[2]/div[4]/select/option[3]"

    // Horizontal
    click ".//*[@class='mat-executive-level']/div[2]/div[5]/button[2]"

    // General Manager
    // Name
    ".//*[@class='mat-executive-level']/div[3]/div[1]/input[1]" << "Magestro"
    ".//*[@class='mat-executive-level']/div[3]/div[1]/input[2]" << "Folkson"

    // Country
    click ".//*[@class='mat-executive-level']/div[3]/div[2]/input[2]"

    // Office
    click ".//*[@class='mat-executive-level']/div[3]/div[3]/input[6]"

    // Vertical
    click ".//*[@class='mat-executive-level']/div[3]/div[4]/select/option[4]"

    // Horizontal
    click ".//*[@class='mat-executive-level']/div[3]/div[5]/button[3]"
    
    // Head of Department
    // Name
    ".//*[@class='mat-executive-level']/div[4]/div[1]/input[1]" << "Kutrik"
    ".//*[@class='mat-executive-level']/div[4]/div[1]/input[2]" << "Khan"

    // Country
    click ".//*[@class='mat-executive-level']/div[4]/div[2]/input[2]"

    // Office
    click ".//*[@class='mat-executive-level']/div[4]/div[3]/input[5]"

    // Vertical
    click ".//*[@class='mat-executive-level']/div[4]/div[4]/select/option[5]"

    // Horizontal
    click ".//*[@class='mat-executive-level']/div[4]/div[5]/button[4]"

//run all tests
run()

timer.Stop()
   
let totalTime = timer.ElapsedMilliseconds
sprintf "Total Time: %i" totalTime |> ignore
   
printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore
   
// Quits Browser
quit()



