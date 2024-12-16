let mutable x = 1
let y = &x

let f () = 
    x <- 2
    !y

let z = f()
printf "%d %d" x z // prints 2 1 instead of 2 2