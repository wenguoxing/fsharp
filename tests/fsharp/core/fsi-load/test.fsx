//namespace global

//See https://github.com/Microsoft/visualfsharp/issues/2871
module MyModule =
    type MyType = A of string

module OtherModule = 
  open MyModule

  open System.Collections.Generic

  let foo () = [ for (k: KeyValuePair<string,MyType>) in []    -> () ]


  let _ =
          stdout.WriteLine "Test Passed"
          System.IO.File.WriteAllText("test.ok","ok")
          exit 0

